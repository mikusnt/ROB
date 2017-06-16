using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tesla_Soft {
    class TankMotors {
        /*
         
            Pola     
             
        */
        // martwe pole na środku mouseImage
        private const int deadBoxCursor = 10;
        // mnoznik px myszki aby otrzymac predkosc 
        private const float mouseRatio = 2.0f;
        
        public Motor MotorL { get; set; }
        public Motor MotorR { get; set; }
        // jesli poprzedni stan to Stop
        private bool fromStop = false;
        // mozliwa predkosc maksymalna
        private int _maxSpeed;
        public int maxSpeed {
            get {
                return _maxSpeed;
            }
            set {
               
                if (value > 255) _maxSpeed = 255;
                else if (value < 0) _maxSpeed = 0;
                else _maxSpeed = value;
                MotorL.maxSpeed = _maxSpeed;
                MotorR.maxSpeed = _maxSpeed;
            }
        } // END public int maxSpeed
        
        /*
         
            Metody     
             
        */
        public void Accelerate(int delta, int deltaToGreater, int brakeDelta) {
            fromStop = false;
            int deltaL = delta, deltaR = delta;
           if (MotorL.direction == MotorR.direction) {
                if(MotorL < MotorR) {
                    deltaL = delta + deltaToGreater;
                } else if(MotorL > MotorR) {
                    deltaR = delta + deltaToGreater;  
                }
            } 
            if (delta > 0) {
                if (MotorL.direction == Direction.Backward) MotorL.Accelerate(deltaL+brakeDelta);
                else MotorL.Accelerate(deltaL);
                if(MotorR.direction == Direction.Backward) MotorR.Accelerate(deltaR + brakeDelta);
                else MotorR.Accelerate(deltaR);
            } else if (delta < 0) {
                if(MotorL.direction == Direction.Forward) MotorL.Accelerate(deltaL + brakeDelta);
                else MotorL.Accelerate(deltaL);
                if(MotorR.direction == Direction.Forward) MotorR.Accelerate(deltaR + brakeDelta);
                else MotorR.Accelerate(deltaR);
            }
        } // END public void Accelerate

        public void Brake(int delta, int deltaToLess) {
            MotorL.Brake(delta);
            MotorR.Brake(delta);
            if (MotorL.direction == MotorR.direction) {
                if (MotorL.absSpeed > MotorR.absSpeed) MotorL.Brake(deltaToLess);
                else if(MotorL.absSpeed < MotorR.absSpeed) MotorR.Brake(deltaToLess);
            }
        } // END public void Brake

        public void LBackRFront(int delta) {
            MotorL.Accelerate(-delta);
            MotorR.Accelerate(delta);
        }
        public void Left(int delta, float stopTurningRatio) {
            int stopDelta = (int)(Math.Abs(delta) * stopTurningRatio);
            if(MotorL.deltaAbsSpeed(MotorR) + delta < maxSpeed) {
                switch(MotorL.direction) {
                    case Direction.Stop: {
                        LBackRFront(stopDelta);
                        fromStop = true;
                    }
                    break;
                    case Direction.Forward: {
                        MotorL.Accelerate(-Math.Abs(delta));
                    }
                    break;
                    case Direction.Backward: {
                        if(fromStop.Equals(true)) {
                            LBackRFront(stopDelta);
                        } else MotorL.Accelerate(Math.Abs(delta));
                    }
                    break;
                }
            }
        } // END public void Left
        public void Right(int delta, float stopTurningRatio) {
            int stopDelta = -(int)(Math.Abs(delta) * stopTurningRatio);
            if(MotorR.deltaAbsSpeed(MotorL) + delta < maxSpeed) {
                switch(MotorR.direction) {
                    case Direction.Stop: {
                        LBackRFront(stopDelta);
                        fromStop = true;
                    }
                    break;
                    case Direction.Forward: {
                        MotorR.Accelerate(-Math.Abs(delta));
                    }
                    break;
                    case Direction.Backward: {
                        if(fromStop.Equals(true)) {
                            LBackRFront(stopDelta);
                        } else MotorR.Accelerate(Math.Abs(delta));
                    }
                    break;
                }
            }

        } // END public void Right
        public void MoveFromCursor(Point cursorStart, Point cursorPoint) {
            Motor cpyL = new Motor(MotorL), cpyR = new Motor(MotorR);
            int dX = cursorPoint.X - cursorStart.X;
            int dY = cursorPoint.Y - cursorStart.Y;
            Point deltaCursor = MovePoint.PointMinusDeadBox(new Point(dX, -dY), new Point(deadBoxCursor, deadBoxCursor));
            deltaCursor = new Point((int)(deltaCursor.X * mouseRatio), (int)(deltaCursor.Y * mouseRatio));

            Console.WriteLine(deltaCursor);

            cpyL.speedDirection = deltaCursor.Y;
            cpyR.speedDirection = deltaCursor.Y;

                cpyL.Accelerate(MovePoint.onlyMinus(deltaCursor.X));
                //cpyR.speedDirection -= MovePoint.onlyMinus(deltaCursor.X);

            //cpyL.speedDirection += MovePoint.onlyPlus(deltaCursor.X);
            cpyR.Accelerate(-MovePoint.onlyPlus(deltaCursor.X));


            if (cpyL.deltaSpeedDirection(cpyR) <= maxSpeed) {
                MotorL = new Motor(cpyL);
                MotorR = new Motor(cpyR);
            }
        } // END public void MoveFromCursor
        /*
         
            Konstruktory     
             
        */
        public TankMotors(int maxSpeed = 255) {
            MotorL = new Motor();
            MotorR = new Motor();
            this.maxSpeed = maxSpeed;
        }
        public TankMotors(Motor MotorL, Motor MotorR, int maxSpeed = 255) {
            this.MotorL = MotorL;
            this.MotorR = MotorR;
            this.maxSpeed = maxSpeed;
        }

    }
}
