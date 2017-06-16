using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Tesla_Soft {
    
    
    public partial class Okno : Form {
        public Okno() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            tankMotors = new TankMotors();
            tankTurret = new Turret();
            centerPointMouseImage = new Point(pictureMouse.Size.Width / 2, pictureMouse.Size.Height / 2);
            Reset();
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            try {
                //image = Image.FromFile(@"images\mouse.png");
            } catch (System.IO.FileNotFoundException) {
               // MessageBox.Show("Nie znaleziono pliku mouse.png");
            }
            
        }
        /*
         
                Pola
                 
        */
        // flagi wcisnietych klawiszy
        private bool upKey, downKey, leftKey, rightKey, upMaxSpeed, downMaxSpeed, leftTurret, rightTurret, upTurret, downTurret;
        // flagi wcisnietych przyciskow
        private bool  turret, motors;
        // hamuler roboczy, podczas puszczenia klawiszy lub odlaczenia pracy myszki
        private bool workBrake = false;
        // flaga grybu pracy
        private bool mouseMove = false;
        // flaga odswiezenia progress barow
        private bool newProgress = false;
        OutFrame outFrame;
        // kolory
        Color brakeColor = Color.FromArgb(255, 200, 100, 0);
        Color forwardColor = Color.FromArgb(255, 0, 64, 0);
        Color stopColor = Color.Blue;
        Color backwardColor = Color.Red;

        private const int deltaMotorAcc = 4;
        private const int deltaMotorToGreaterAcc = 2;
        private const int deltaNoKeyBrake = 4;
        private const int deltaMotorToLessBrake = 6;
        private const int deltaMotorTurn = 7; // wiekszy od deltaMotorAcc + deltaMotorToGreaterAcc aby zniesc jednoczesne przyspieczenie
        private const int deltaTurret = 1;
        private const float stopTurningRatio = 0.5f;
        private Point centerPointMouseImage;
        private Point oldCursorPos;
        Image image;
        private TankMotors tankMotors;
        Graphics graph;
        //Point turretPos;
        Turret tankTurret;
        Thread myThread;
        /*
         
                Metody     
             
        */
        private void SetKeyboardDriving() {
            mouseMove = false;
            pictureMouse.Cursor = Cursors.Default;
            pictureMouse.BorderStyle = BorderStyle.None;
        }
        private void Reset() {
            //ButtonOnOff(buttonReset, true);
            upKey = false;
            downKey = false;
            leftKey = false;
            rightKey = false;
            upMaxSpeed = false;
            downMaxSpeed = false;
            leftTurret = false;
            rightTurret = false;
            upTurret = false;
            downTurret = false;
            workBrake = false;
            mouseMove = false;
            newProgress = false;
            pictureMouse.Cursor = Cursors.Default;
            pictureMouse.BorderStyle = BorderStyle.None;
            //tankMotors.Brake(255);
            outFrame.lights = false;
            ButtonOnOff(buttonLights, outFrame.lights);
            outFrame.laserLight = false;
            ButtonOnOff(buttonLaser, outFrame.laserLight);
            outFrame.camera = false;
            ButtonOnOff(buttonCamera, outFrame.camera);
            turret = false;
            ButtonOnOff(buttonTurret, turret);
            motors = false;
            ButtonOnOff(buttonMotors, motors);
            outFrame.brake = false;
            ButtonOnOff(buttonBrake, outFrame.brake);
            trackMaxSpeed.Value = 255;
            tankTurret.pos = new Point(128, 128);
            drawRadioTurret();
            groupTurret.Enabled = false;

            buttonStop.Enabled = false;
            buttonFind.Enabled = true;
            buttonFind.Text = "Skanuj";
            listIP.Items.Clear();
            buttonConnect.Enabled = false;
            buttonConnect.Text = "Połącz";
            //drawMaxSpeed();
        }

        private void drawMaxSpeed() {
            pictureMouse.Refresh();
            Graphics graph = pictureMouse.CreateGraphics();
            Rectangle rect = new Rectangle((278 - trackMaxSpeed.Value) / 2, (278 - trackMaxSpeed.Value) / 2, trackMaxSpeed.Value + 20, trackMaxSpeed.Value + 20);
            //graph.DrawEllipse(new Pen(Color.Green, 3.0f), rect);
            graph.DrawRectangle(new Pen(Color.Green, 3.0f), rect);
            graph.Dispose();
        }

        private void drawRadioTurret() {
            radioTurret.Location = new Point(pictureTurret.Location.X + (tankTurret.pos.X / 2) - 6, pictureTurret.Location.Y + pictureTurret.Size.Width - ((tankTurret.pos.Y / 2) + 6));
            radioTurret.BringToFront();
        }
        private void ButtonOnOff(Button button, bool isOn) {
            if (isOn == true) button.BackColor = Color.Green;
            else button.BackColor = Color.Red;
        }

        private void buttonLights_Click(object sender, EventArgs e) {
            outFrame.lights = !outFrame.lights;
            ButtonOnOff(buttonLights, outFrame.lights);
        }

        private void buttonLaser_Click(object sender, EventArgs e) {
            outFrame.laserLight = !outFrame.laserLight;
            ButtonOnOff(buttonLaser, outFrame.laserLight);
        }

        private void buttonCamera_Click(object sender, EventArgs e) {
           outFrame. camera = !outFrame.camera;
            ButtonOnOff(buttonCamera, outFrame.camera);
        }

        private void buttonCenterTurret_Click(object sender, EventArgs e) {
            tankTurret = new Turret();
            drawRadioTurret();
        }

        public void pinguj() {
            Ping myPing;
            PingReply myPingReply;
            buttonFind.Enabled = false;
            listIP.Items.Clear();
            for (int i = (int)numericNetStart.Value; i < numericNetEnd.Value; i++) {

                //if ((i % 10) == 0) MessageBox.Show(i.ToString());
                String ipname = String.Concat(textNetwork.Text,".", i.ToString());
               // String ipname = "192.168.1.101";
                buttonFind.Text = i.ToString();
                myPing = new Ping();
                try {
                    
                    myPingReply = myPing.Send(ipname, 100);
                    if ((myPingReply != null) && (myPingReply.Status == IPStatus.Success)) {
                        //ipAddr = IPAddress.Parse(ipname);
                        //ipHost = Dns.GetHostEntry(ipAddr);
                        // MessageBox.Show(myPingReply.Status.ToString());
                        listIP.Items.Add(ipname);
                    }
                        
                  // dataNetwork.Rows.Add("a", "d");
                } catch {
                    //MessageBox.Show("Coś poszło nie tak!");
                } 
            }
            buttonStop.Enabled = false;
            buttonFind.Enabled = true;
            buttonFind.Text = "Skanuj";
            //MessageBox.Show("Zakończono!");
        }

        private void buttonFind_Click_1(object sender, EventArgs e) {
            // dataNetwork.Rows.Add("asdf", "");
            myThread = new Thread(() => pinguj());
             buttonStop.Enabled = true;
            myThread.Start();
            //pinguj();
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            if (myThread != null) myThread.Abort();
            buttonFind.Enabled = true;
            buttonFind.Text = "Skanuj";
            buttonStop.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (myThread != null) myThread.Abort();
        }

        private void buttonServo_Click(object sender, EventArgs e) {
            turret = !turret;
            ButtonOnOff(buttonTurret, turret);
            if(turret) groupTurret.Enabled = true;
            else groupTurret.Enabled = false;
        }

        private void buttonMotors_Click(object sender, EventArgs e) {
            motors = !motors;
            ButtonOnOff(buttonMotors, motors);
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void buttonReset_Click(object sender, EventArgs e) {
            //Reset();
            //tankTurret = new Turret();
            // drawRadioTurret();
            
        }

        private void buttonBrake_Click(object sender, EventArgs e) {
            outFrame.brake = !outFrame.brake;
            ButtonOnOff(buttonBrake, outFrame.brake);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            tankMotors.maxSpeed = trackMaxSpeed.Value;
            if ((mouseMove == true) && (!outFrame.brake)) {
                tankMotors.MoveFromCursor(centerPointMouseImage, oldCursorPos);
                newProgress = true;
            }
            if (mouseMove) drawMaxSpeed();
            //rysowanie kola
            //pictureMouse.Image = image;
            //drawMaxSpeed();
            //labelMaxSpeed.Text = tankMotors.maxSpeed.ToString();
        }


        private void pictureMouse_MouseMove(object sender, MouseEventArgs e) {

            //MessageBox.Show(centerPoint.ToString());
            //isBrake = false;
            if((mouseMove == true) && (!outFrame.brake)) {
                tankMotors.MoveFromCursor(centerPointMouseImage, e.Location);
                newProgress = true;
            }
            //if (MouseMovePoint.isInside(centerPointMouseImage, e.Location, 10)) label1.Text = "true";
            //else label1.Text = "false";
            oldCursorPos = e.Location;
            label1.Text = tankMotors.MotorL.deltaAbsSpeed(tankMotors.MotorR).ToString();
            //if (mouseMove) drawMaxSpeed();
            //labelMouseX.Text = String.Concat("X: ", e.X);
            //labelMouseY.Text = String.Concat("Y: ", e.Y);
        }

        private void pictureMouse_MouseLeave(object sender, EventArgs e) {
            workBrake = true;
            SetKeyboardDriving();
            //drawMaxSpeed();
            //else {
            //isBrake = true;
            //pictureMouse.Cursor = Cursors.Default;
            //}
        }

        private void pictureMouse_Click(object sender, EventArgs e) {
            //mouseMove = !mouseMove;
            if (MovePoint.isInside(centerPointMouseImage, oldCursorPos, 10)) {
                mouseMove = !mouseMove;
            } else mouseMove = false;
            
            workBrake = !mouseMove;
            if (mouseMove == false) {
                pictureMouse.Cursor = Cursors.Default;
                pictureMouse.BorderStyle = BorderStyle.None;
            } else {
                pictureMouse.Cursor = Cursors.NoMove2D;
                pictureMouse.BorderStyle = BorderStyle.FixedSingle;
                drawMaxSpeed();
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            //isPressed = false;
            if (e.KeyData.Equals(Keys.Up)) upKey = false;
            if (e.KeyData.Equals(Keys.Down)) downKey = false;
            if (e.KeyData.Equals(Keys.Left)) leftKey = false;
            if (e.KeyData.Equals(Keys.Right)) rightKey = false;
            if (e.KeyData.Equals(Keys.Oemcomma)) downMaxSpeed = false;
            if (e.KeyData.Equals(Keys.OemPeriod)) upMaxSpeed = false;

            if(e.KeyData.Equals(Keys.A)) leftTurret = false;
            if(e.KeyData.Equals(Keys.D)) rightTurret = false;
            if(e.KeyData.Equals(Keys.W)) upTurret = false;
            if(e.KeyData.Equals(Keys.S)) downTurret = false;
           // Console.WriteLine(e.KeyData.ToString());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
           // label1.Text = keyData.ToString();
            if (keyData.Equals(Keys.Up)) upKey = true;
            if (keyData.Equals(Keys.Down)) downKey = true;
            if (keyData.Equals(Keys.Left)) leftKey = true;
            if (keyData.Equals(Keys.Right)) rightKey = true;
           
            // if (keyData.Equals(Keys.oem)) rightKey = true;
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            //isPressed = true;
            if (e.KeyData.Equals(Keys.L))  buttonLights_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.E)) buttonLaser_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.V)) buttonCamera_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.T)) buttonServo_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.M)) buttonMotors_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.R)) buttonReset_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.B)) buttonBrake_Click(sender, (EventArgs)e);
            //if(e.KeyData.Equals(Keys.C)) buttonCenterTurret_Click(sender, (EventArgs)e);
            if (e.KeyData.Equals(Keys.Oemcomma)) downMaxSpeed = true;
            if (e.KeyData.Equals(Keys.OemPeriod)) upMaxSpeed = true;
            if(e.KeyData.Equals(Keys.A)) leftTurret = true;
            if(e.KeyData.Equals(Keys.D)) rightTurret = true;
            if(e.KeyData.Equals(Keys.W)) upTurret = true;
            if(e.KeyData.Equals(Keys.S)) downTurret = true;

        }

        private void timerMotor_Tick(object sender, EventArgs e) {
            // obsluga klawiatury
            if (upMaxSpeed) {
                if (trackMaxSpeed.Value < 254) trackMaxSpeed.Value += 2;
                else if (trackMaxSpeed.Value == 254) trackMaxSpeed.Value = 255;
                //if (mouseMove == true) tankMotors.MoveFromCursor(centerPoint, oldCursorPos);
            }
            if (downMaxSpeed) {
                if (trackMaxSpeed.Value > 11) trackMaxSpeed.Value -= 2;
                else if (trackMaxSpeed.Value == 11) trackMaxSpeed.Value = 10;
                //if (mouseMove == true) tankMotors.MoveFromCursor(centerPoint, oldCursorPos);
            }

            if(turret) {

                if(leftTurret) {
                    tankTurret.toLeft(deltaTurret);
                    drawRadioTurret();
                }
                if(rightTurret) {
                    tankTurret.toRight(deltaTurret);
                    drawRadioTurret();
                }
                if(upTurret) {
                    tankTurret.toUp(deltaTurret);
                    drawRadioTurret();
                }
                if(downTurret) {
                    tankTurret.toDown(deltaTurret);
                    drawRadioTurret();
                }
            }
            if ((mouseMove == false) && (!outFrame.brake)) {
                
                //obsluga przyspieszenia
                if (upKey.Equals(true)) {
                    tankMotors.Accelerate(deltaMotorAcc, deltaMotorToGreaterAcc, deltaNoKeyBrake);
                    newProgress = true;
                }
                if (downKey.Equals(true)) {
                    tankMotors.Accelerate(-deltaMotorAcc, -deltaMotorToGreaterAcc, -deltaNoKeyBrake);
                    newProgress = true;
                }
                if (leftKey.Equals(true)) {
                    tankMotors.Left(deltaMotorTurn, stopTurningRatio);
                    newProgress = true;
                }
                if (rightKey.Equals(true)) {
                    tankMotors.Right(deltaMotorTurn, stopTurningRatio);
                    newProgress = true;
                }
                if ((upKey == false) && (downKey == false) && (leftKey == false) && (rightKey == false)) {
                    workBrake = true;
                } else workBrake = false;
            } 
            

            // obsluga hamowania
            if ((workBrake == true) || (outFrame.brake == true)) {
                tankMotors.Brake(deltaNoKeyBrake, deltaMotorToLessBrake);
                if (outFrame.brake) SetKeyboardDriving();
                if ((tankMotors.MotorL.absSpeed == 0) && (tankMotors.MotorR.absSpeed == 0)) {
                    workBrake = false;
                }
                newProgress = true;
            }
            // ladowanie danych silnikow do ramki danych
            if(tankMotors.MotorL.direction == Direction.Backward)
                outFrame.motorLDirection = true;
            else outFrame.motorLDirection = false;

            if(tankMotors.MotorR.direction == Direction.Backward)
                outFrame.motorRDirection = true;
            else outFrame.motorRDirection = false;

            outFrame.motorLSpeed = (byte)tankMotors.MotorL.absSpeed;
            outFrame.motorRSpeed = (byte)tankMotors.MotorR.absSpeed;
            outFrame.verticalTurret = (byte)tankTurret.pos.Y;
            outFrame.horizontalTurret = (byte)tankTurret.pos.X;
            //Console.WriteLine(String.Format(Convert.ToString(outFrame.GetFrameOne(), 2)));
            // obsluga progress barow
            if(newProgress) {

                newProgress = false;
                // tył L
                progressMotorLBack.Refresh();
                graph = progressMotorLBack.CreateGraphics();
                if (tankMotors.MotorL.direction == Direction.Backward) graph.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, progressMotorLBack.Size.Width, (progressMotorLBack.Size.Height * tankMotors.MotorL.absSpeed) / 255);
                else graph.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, 0, 0);
                graph.Dispose();

                // tył R
                progressMotorRBack.Refresh();
                graph = progressMotorRBack.CreateGraphics();
                if(tankMotors.MotorR.direction == Direction.Backward) graph.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, progressMotorRBack.Size.Width, (progressMotorRBack.Size.Height * tankMotors.MotorR.absSpeed) / 255);
                else graph.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, 0, 0);
                graph.Dispose();

                // przód L
                progressMotorLFront.Refresh();
                graph = progressMotorLFront.CreateGraphics();
                if(tankMotors.MotorL.direction == Direction.Forward) graph.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), 0, progressMotorLFront.Size.Height - (progressMotorLFront.Size.Height * tankMotors.MotorL.absSpeed) / 255, progressMotorLFront.Size.Width, progressMotorLFront.Size.Height);
                else graph.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), 0, 0, 0, 0);
                graph.Dispose();

                // przód R
                progressMotorRFront.Refresh();
                graph = progressMotorRFront.CreateGraphics();
                if(tankMotors.MotorR.direction == Direction.Forward) graph.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), 0, progressMotorRFront.Size.Height - (progressMotorRFront.Size.Height * tankMotors.MotorR.absSpeed) / 255, progressMotorRFront.Size.Width, progressMotorRFront.Size.Height);
                else graph.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), 0, 0, 0, 0);
                graph.Dispose();

            }
            /*switch (tankMotors.MotorL.direction) {
                case Direction.Stop: {
                    progressMotorLForward.Value = 0;
                    progressMotorLBackward.Value = 0;
                } break;
                case Direction.Forward: {
                    progressMotorLForward.Value = tankMotors.MotorL.speed;
                    progressMotorLBackward.Value = 0;
                }
                break;
                case Direction.Backward: {
                    progressMotorLForward.Value = 0;
                    progressMotorLBackward.Value = tankMotors.MotorL.speed;
                }
                break;
            }
            switch (tankMotors.MotorR.direction) {
                case Direction.Stop: {
                    progressMotorRForward.Value = 0;
                    progressMotorRBackward.Value = 0;
                } break;
                case Direction.Forward: {
                    progressMotorRForward.Value = tankMotors.MotorR.speed;
                    progressMotorRBackward.Value = 0;
                }
                break;
                case Direction.Backward: {
                    progressMotorRForward.Value = 0;
                    progressMotorRBackward.Value = tankMotors.MotorR.speed;
                }
                break;
            }*/

            // wyswietlanie na labelach
            
            if (!outFrame.brake) {
                switch(tankMotors.MotorR.direction) {
                    case Direction.Stop: {
                        labelMotorR.ForeColor = stopColor;
                    }
                    break;
                    case Direction.Forward: {
                        labelMotorR.ForeColor = forwardColor;
                    }
                    break;
                    case Direction.Backward: {
                        labelMotorR.ForeColor = backwardColor;
                    }
                    break;

                }
                switch(tankMotors.MotorL.direction) {
                    case Direction.Stop: {
                        labelMotorL.ForeColor = stopColor;
                    }
                    break;
                    case Direction.Forward: {
                        labelMotorL.ForeColor = forwardColor;
                    }
                    break;
                    case Direction.Backward: {
                        labelMotorL.ForeColor = backwardColor;
                    }
                    break;

                }
                labelMotorL.Text = tankMotors.MotorL.ToString(true);
                labelMotorR.Text = tankMotors.MotorR.ToString(false);
            } else {
                labelMotorL.ForeColor = brakeColor;
                labelMotorR.ForeColor = brakeColor;
                labelMotorL.Text = "0 B";
                labelMotorR.Text = "B 0";
            }

            labelSterMode.Text = string.Concat("Tryb pracy: ", (mouseMove == true ? "mysz" : "klawiatura"));
            labelMaxSpeed.Text = tankMotors.maxSpeed.ToString();
            
            //labelMouseX.Text = String.Concat("X: ", Cursor.Position.X.ToString());
            //labelMouseY.Text = String.Concat("Y: ", Cursor.Position.Y.ToString());
        }
    }
}
