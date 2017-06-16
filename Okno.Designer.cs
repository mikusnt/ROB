namespace Tesla_Soft {
    partial class Okno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.timerMotor = new System.Windows.Forms.Timer(this.components);
            this.labelMotorL = new System.Windows.Forms.Label();
            this.labelMotorR = new System.Windows.Forms.Label();
            this.pictureMouse = new System.Windows.Forms.PictureBox();
            this.groupControls = new System.Windows.Forms.GroupBox();
            this.labelBrake = new System.Windows.Forms.Label();
            this.buttonBrake = new System.Windows.Forms.Button();
            this.labelMotors = new System.Windows.Forms.Label();
            this.labelTurret = new System.Windows.Forms.Label();
            this.buttonMotors = new System.Windows.Forms.Button();
            this.buttonTurret = new System.Windows.Forms.Button();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.buttonLaser = new System.Windows.Forms.Button();
            this.labelCamera = new System.Windows.Forms.Label();
            this.buttonLights = new System.Windows.Forms.Button();
            this.labelLaser = new System.Windows.Forms.Label();
            this.labelLights = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelSterMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelConnectionMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelVoltage = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupMaxSpeed = new System.Windows.Forms.GroupBox();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.trackMaxSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.progressMotorLBack = new System.Windows.Forms.PictureBox();
            this.progressMotorRBack = new System.Windows.Forms.PictureBox();
            this.progressMotorLFront = new System.Windows.Forms.PictureBox();
            this.progressMotorRFront = new System.Windows.Forms.PictureBox();
            this.pictureTurret = new System.Windows.Forms.PictureBox();
            this.radioTurret = new System.Windows.Forms.RadioButton();
            this.groupTurret = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listIP = new System.Windows.Forms.ListBox();
            this.groupNetwork = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelNetEnd = new System.Windows.Forms.Label();
            this.labelNetStart = new System.Windows.Forms.Label();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.numericNetEnd = new System.Windows.Forms.NumericUpDown();
            this.numericNetStart = new System.Windows.Forms.NumericUpDown();
            this.textNetwork = new System.Windows.Forms.TextBox();
            this.groupEngines = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMouse)).BeginInit();
            this.groupControls.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupMaxSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorLBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorRBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorLFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorRFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurret)).BeginInit();
            this.groupTurret.SuspendLayout();
            this.groupNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetStart)).BeginInit();
            this.groupEngines.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMotor
            // 
            this.timerMotor.Enabled = true;
            this.timerMotor.Interval = 1;
            this.timerMotor.Tick += new System.EventHandler(this.timerMotor_Tick);
            // 
            // labelMotorL
            // 
            this.labelMotorL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMotorL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMotorL.Location = new System.Drawing.Point(8, 167);
            this.labelMotorL.Name = "labelMotorL";
            this.labelMotorL.Size = new System.Drawing.Size(45, 14);
            this.labelMotorL.TabIndex = 6;
            this.labelMotorL.Text = "0 -";
            this.labelMotorL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMotorR
            // 
            this.labelMotorR.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMotorR.Location = new System.Drawing.Point(358, 169);
            this.labelMotorR.Name = "labelMotorR";
            this.labelMotorR.Size = new System.Drawing.Size(45, 13);
            this.labelMotorR.TabIndex = 7;
            this.labelMotorR.Text = "- 0";
            this.labelMotorR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureMouse
            // 
            this.pictureMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureMouse.BackgroundImage")));
            this.pictureMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureMouse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureMouse.Location = new System.Drawing.Point(55, 24);
            this.pictureMouse.Name = "pictureMouse";
            this.pictureMouse.Size = new System.Drawing.Size(300, 300);
            this.pictureMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMouse.TabIndex = 10;
            this.pictureMouse.TabStop = false;
            this.pictureMouse.Click += new System.EventHandler(this.pictureMouse_Click);
            this.pictureMouse.MouseLeave += new System.EventHandler(this.pictureMouse_MouseLeave);
            this.pictureMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMouse_MouseMove);
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.labelBrake);
            this.groupControls.Controls.Add(this.buttonBrake);
            this.groupControls.Controls.Add(this.labelMotors);
            this.groupControls.Controls.Add(this.labelTurret);
            this.groupControls.Controls.Add(this.buttonMotors);
            this.groupControls.Controls.Add(this.buttonTurret);
            this.groupControls.Controls.Add(this.buttonCamera);
            this.groupControls.Controls.Add(this.buttonLaser);
            this.groupControls.Controls.Add(this.labelCamera);
            this.groupControls.Controls.Add(this.buttonLights);
            this.groupControls.Controls.Add(this.labelLaser);
            this.groupControls.Controls.Add(this.labelLights);
            this.groupControls.Location = new System.Drawing.Point(12, 355);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(155, 194);
            this.groupControls.TabIndex = 11;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Kontrolki";
            // 
            // labelBrake
            // 
            this.labelBrake.AutoSize = true;
            this.labelBrake.Location = new System.Drawing.Point(6, 166);
            this.labelBrake.Name = "labelBrake";
            this.labelBrake.Size = new System.Drawing.Size(71, 13);
            this.labelBrake.TabIndex = 19;
            this.labelBrake.Text = "Hamulec [B]: ";
            // 
            // buttonBrake
            // 
            this.buttonBrake.BackColor = System.Drawing.Color.Red;
            this.buttonBrake.Location = new System.Drawing.Point(90, 162);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(46, 23);
            this.buttonBrake.TabIndex = 18;
            this.buttonBrake.TabStop = false;
            this.buttonBrake.UseVisualStyleBackColor = false;
            this.buttonBrake.Click += new System.EventHandler(this.buttonBrake_Click);
            this.buttonBrake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonBrake.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // labelMotors
            // 
            this.labelMotors.AutoSize = true;
            this.labelMotors.Location = new System.Drawing.Point(6, 137);
            this.labelMotors.Name = "labelMotors";
            this.labelMotors.Size = new System.Drawing.Size(58, 13);
            this.labelMotors.TabIndex = 17;
            this.labelMotors.Text = "Silniki [M]: ";
            // 
            // labelTurret
            // 
            this.labelTurret.AutoSize = true;
            this.labelTurret.Location = new System.Drawing.Point(6, 108);
            this.labelTurret.Name = "labelTurret";
            this.labelTurret.Size = new System.Drawing.Size(78, 13);
            this.labelTurret.TabIndex = 16;
            this.labelTurret.Text = "Wieżyczka [T]:";
            // 
            // buttonMotors
            // 
            this.buttonMotors.BackColor = System.Drawing.Color.Red;
            this.buttonMotors.Location = new System.Drawing.Point(90, 133);
            this.buttonMotors.Name = "buttonMotors";
            this.buttonMotors.Size = new System.Drawing.Size(46, 23);
            this.buttonMotors.TabIndex = 15;
            this.buttonMotors.TabStop = false;
            this.buttonMotors.UseVisualStyleBackColor = false;
            this.buttonMotors.Click += new System.EventHandler(this.buttonMotors_Click);
            this.buttonMotors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonMotors.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // buttonTurret
            // 
            this.buttonTurret.BackColor = System.Drawing.Color.Red;
            this.buttonTurret.Location = new System.Drawing.Point(90, 103);
            this.buttonTurret.Name = "buttonTurret";
            this.buttonTurret.Size = new System.Drawing.Size(46, 23);
            this.buttonTurret.TabIndex = 14;
            this.buttonTurret.TabStop = false;
            this.buttonTurret.UseVisualStyleBackColor = false;
            this.buttonTurret.Click += new System.EventHandler(this.buttonServo_Click);
            this.buttonTurret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonTurret.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // buttonCamera
            // 
            this.buttonCamera.BackColor = System.Drawing.Color.Red;
            this.buttonCamera.Location = new System.Drawing.Point(90, 74);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(46, 23);
            this.buttonCamera.TabIndex = 13;
            this.buttonCamera.TabStop = false;
            this.buttonCamera.UseVisualStyleBackColor = false;
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            this.buttonCamera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonCamera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // buttonLaser
            // 
            this.buttonLaser.BackColor = System.Drawing.Color.Red;
            this.buttonLaser.Location = new System.Drawing.Point(90, 45);
            this.buttonLaser.Name = "buttonLaser";
            this.buttonLaser.Size = new System.Drawing.Size(46, 23);
            this.buttonLaser.TabIndex = 12;
            this.buttonLaser.TabStop = false;
            this.buttonLaser.UseVisualStyleBackColor = false;
            this.buttonLaser.Click += new System.EventHandler(this.buttonLaser_Click);
            this.buttonLaser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonLaser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.Location = new System.Drawing.Point(6, 79);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(62, 13);
            this.labelCamera.TabIndex = 2;
            this.labelCamera.Text = "Kamera [V]:";
            // 
            // buttonLights
            // 
            this.buttonLights.BackColor = System.Drawing.Color.Red;
            this.buttonLights.Location = new System.Drawing.Point(90, 16);
            this.buttonLights.Name = "buttonLights";
            this.buttonLights.Size = new System.Drawing.Size(46, 23);
            this.buttonLights.TabIndex = 3;
            this.buttonLights.TabStop = false;
            this.buttonLights.UseVisualStyleBackColor = false;
            this.buttonLights.Click += new System.EventHandler(this.buttonLights_Click);
            this.buttonLights.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonLights.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // labelLaser
            // 
            this.labelLaser.AutoSize = true;
            this.labelLaser.Location = new System.Drawing.Point(6, 50);
            this.labelLaser.Name = "labelLaser";
            this.labelLaser.Size = new System.Drawing.Size(55, 13);
            this.labelLaser.TabIndex = 1;
            this.labelLaser.Text = "Laser [E]: ";
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Location = new System.Drawing.Point(6, 21);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(61, 13);
            this.labelLights.TabIndex = 0;
            this.labelLights.Text = "Światła [L]:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelSterMode,
            this.labelConnectionMode,
            this.labelVoltage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // labelSterMode
            // 
            this.labelSterMode.AutoSize = false;
            this.labelSterMode.Name = "labelSterMode";
            this.labelSterMode.Size = new System.Drawing.Size(125, 17);
            this.labelSterMode.Text = "Tryb pracy:";
            this.labelSterMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConnectionMode
            // 
            this.labelConnectionMode.AutoSize = false;
            this.labelConnectionMode.Name = "labelConnectionMode";
            this.labelConnectionMode.Size = new System.Drawing.Size(100, 17);
            this.labelConnectionMode.Text = "Status:";
            this.labelConnectionMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = false;
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(130, 17);
            this.labelVoltage.Text = "Napięcie zasilania:";
            this.labelVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupMaxSpeed
            // 
            this.groupMaxSpeed.Controls.Add(this.labelMaxSpeed);
            this.groupMaxSpeed.Controls.Add(this.trackMaxSpeed);
            this.groupMaxSpeed.Location = new System.Drawing.Point(344, 355);
            this.groupMaxSpeed.Name = "groupMaxSpeed";
            this.groupMaxSpeed.Size = new System.Drawing.Size(77, 194);
            this.groupMaxSpeed.TabIndex = 14;
            this.groupMaxSpeed.TabStop = false;
            this.groupMaxSpeed.Text = "Prędkość";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxSpeed.Location = new System.Drawing.Point(11, 164);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(47, 20);
            this.labelMaxSpeed.TabIndex = 14;
            this.labelMaxSpeed.Text = "255";
            this.labelMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackMaxSpeed
            // 
            this.trackMaxSpeed.LargeChange = 1;
            this.trackMaxSpeed.Location = new System.Drawing.Point(14, 19);
            this.trackMaxSpeed.Maximum = 255;
            this.trackMaxSpeed.Minimum = 10;
            this.trackMaxSpeed.Name = "trackMaxSpeed";
            this.trackMaxSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackMaxSpeed.Size = new System.Drawing.Size(45, 148);
            this.trackMaxSpeed.TabIndex = 13;
            this.trackMaxSpeed.TabStop = false;
            this.trackMaxSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackMaxSpeed.Value = 255;
            this.trackMaxSpeed.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackMaxSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.trackMaxSpeed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReset.Location = new System.Drawing.Point(346, 567);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset [R]";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonReset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // progressMotorLBack
            // 
            this.progressMotorLBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressMotorLBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressMotorLBack.Location = new System.Drawing.Point(18, 183);
            this.progressMotorLBack.Name = "progressMotorLBack";
            this.progressMotorLBack.Size = new System.Drawing.Size(31, 140);
            this.progressMotorLBack.TabIndex = 20;
            this.progressMotorLBack.TabStop = false;
            // 
            // progressMotorRBack
            // 
            this.progressMotorRBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressMotorRBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressMotorRBack.Location = new System.Drawing.Point(361, 184);
            this.progressMotorRBack.Name = "progressMotorRBack";
            this.progressMotorRBack.Size = new System.Drawing.Size(31, 140);
            this.progressMotorRBack.TabIndex = 21;
            this.progressMotorRBack.TabStop = false;
            // 
            // progressMotorLFront
            // 
            this.progressMotorLFront.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressMotorLFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressMotorLFront.Location = new System.Drawing.Point(18, 24);
            this.progressMotorLFront.Name = "progressMotorLFront";
            this.progressMotorLFront.Size = new System.Drawing.Size(31, 140);
            this.progressMotorLFront.TabIndex = 22;
            this.progressMotorLFront.TabStop = false;
            // 
            // progressMotorRFront
            // 
            this.progressMotorRFront.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressMotorRFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressMotorRFront.Location = new System.Drawing.Point(361, 24);
            this.progressMotorRFront.Name = "progressMotorRFront";
            this.progressMotorRFront.Size = new System.Drawing.Size(31, 140);
            this.progressMotorRFront.TabIndex = 23;
            this.progressMotorRFront.TabStop = false;
            // 
            // pictureTurret
            // 
            this.pictureTurret.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTurret.BackgroundImage")));
            this.pictureTurret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTurret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTurret.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureTurret.Location = new System.Drawing.Point(18, 29);
            this.pictureTurret.Name = "pictureTurret";
            this.pictureTurret.Size = new System.Drawing.Size(128, 128);
            this.pictureTurret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTurret.TabIndex = 24;
            this.pictureTurret.TabStop = false;
            // 
            // radioTurret
            // 
            this.radioTurret.AutoSize = true;
            this.radioTurret.Checked = true;
            this.radioTurret.Location = new System.Drawing.Point(79, 84);
            this.radioTurret.Name = "radioTurret";
            this.radioTurret.Size = new System.Drawing.Size(14, 13);
            this.radioTurret.TabIndex = 25;
            this.radioTurret.TabStop = true;
            this.radioTurret.UseVisualStyleBackColor = true;
            // 
            // groupTurret
            // 
            this.groupTurret.Controls.Add(this.radioTurret);
            this.groupTurret.Controls.Add(this.pictureTurret);
            this.groupTurret.Location = new System.Drawing.Point(173, 355);
            this.groupTurret.Name = "groupTurret";
            this.groupTurret.Size = new System.Drawing.Size(165, 194);
            this.groupTurret.TabIndex = 27;
            this.groupTurret.TabStop = false;
            this.groupTurret.Text = "Kontrola wieżyczki [WSAD]";
            this.groupTurret.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(9, 97);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 30;
            this.buttonFind.TabStop = false;
            this.buttonFind.Text = "Skanuj";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click_1);
            this.buttonFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.buttonFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(90, 97);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 32;
            this.buttonStop.Text = "Zatrzymaj";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listIP
            // 
            this.listIP.FormattingEnabled = true;
            this.listIP.Location = new System.Drawing.Point(180, 19);
            this.listIP.Name = "listIP";
            this.listIP.Size = new System.Drawing.Size(120, 69);
            this.listIP.TabIndex = 33;
            // 
            // groupNetwork
            // 
            this.groupNetwork.Controls.Add(this.buttonConnect);
            this.groupNetwork.Controls.Add(this.labelNetEnd);
            this.groupNetwork.Controls.Add(this.buttonStop);
            this.groupNetwork.Controls.Add(this.labelNetStart);
            this.groupNetwork.Controls.Add(this.buttonFind);
            this.groupNetwork.Controls.Add(this.labelNetwork);
            this.groupNetwork.Controls.Add(this.numericNetEnd);
            this.groupNetwork.Controls.Add(this.numericNetStart);
            this.groupNetwork.Controls.Add(this.listIP);
            this.groupNetwork.Controls.Add(this.textNetwork);
            this.groupNetwork.Location = new System.Drawing.Point(12, 555);
            this.groupNetwork.Name = "groupNetwork";
            this.groupNetwork.Size = new System.Drawing.Size(326, 135);
            this.groupNetwork.TabIndex = 34;
            this.groupNetwork.TabStop = false;
            this.groupNetwork.Text = "Skaner połączeń [maska 24]";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(205, 97);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 40;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // labelNetEnd
            // 
            this.labelNetEnd.AutoSize = true;
            this.labelNetEnd.Location = new System.Drawing.Point(6, 73);
            this.labelNetEnd.Name = "labelNetEnd";
            this.labelNetEnd.Size = new System.Drawing.Size(43, 13);
            this.labelNetEnd.TabIndex = 39;
            this.labelNetEnd.Text = "Koniec:";
            // 
            // labelNetStart
            // 
            this.labelNetStart.AutoSize = true;
            this.labelNetStart.Location = new System.Drawing.Point(6, 47);
            this.labelNetStart.Name = "labelNetStart";
            this.labelNetStart.Size = new System.Drawing.Size(55, 13);
            this.labelNetStart.TabIndex = 38;
            this.labelNetStart.Text = "Początek:";
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Location = new System.Drawing.Point(6, 22);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(31, 13);
            this.labelNetwork.TabIndex = 37;
            this.labelNetwork.Text = "Sieć:";
            // 
            // numericNetEnd
            // 
            this.numericNetEnd.Location = new System.Drawing.Point(74, 71);
            this.numericNetEnd.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericNetEnd.Name = "numericNetEnd";
            this.numericNetEnd.Size = new System.Drawing.Size(100, 20);
            this.numericNetEnd.TabIndex = 36;
            this.numericNetEnd.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericNetStart
            // 
            this.numericNetStart.Location = new System.Drawing.Point(74, 45);
            this.numericNetStart.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericNetStart.Name = "numericNetStart";
            this.numericNetStart.Size = new System.Drawing.Size(100, 20);
            this.numericNetStart.TabIndex = 35;
            this.numericNetStart.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textNetwork
            // 
            this.textNetwork.Location = new System.Drawing.Point(74, 19);
            this.textNetwork.Name = "textNetwork";
            this.textNetwork.Size = new System.Drawing.Size(100, 20);
            this.textNetwork.TabIndex = 34;
            this.textNetwork.Text = "192.168.1";
            // 
            // groupEngines
            // 
            this.groupEngines.Controls.Add(this.progressMotorLFront);
            this.groupEngines.Controls.Add(this.pictureMouse);
            this.groupEngines.Controls.Add(this.labelMotorL);
            this.groupEngines.Controls.Add(this.progressMotorRFront);
            this.groupEngines.Controls.Add(this.progressMotorRBack);
            this.groupEngines.Controls.Add(this.progressMotorLBack);
            this.groupEngines.Controls.Add(this.labelMotorR);
            this.groupEngines.Location = new System.Drawing.Point(12, 12);
            this.groupEngines.Name = "groupEngines";
            this.groupEngines.Size = new System.Drawing.Size(409, 337);
            this.groupEngines.TabIndex = 35;
            this.groupEngines.TabStop = false;
            this.groupEngines.Text = "Kontrola silników [klawiatura, mysz]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 762);
            this.Controls.Add(this.groupEngines);
            this.Controls.Add(this.groupNetwork);
            this.Controls.Add(this.groupTurret);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupMaxSpeed);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupControls);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Tesla Soft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMouse)).EndInit();
            this.groupControls.ResumeLayout(false);
            this.groupControls.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupMaxSpeed.ResumeLayout(false);
            this.groupMaxSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorLBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorRBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorLFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressMotorRFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurret)).EndInit();
            this.groupTurret.ResumeLayout(false);
            this.groupTurret.PerformLayout();
            this.groupNetwork.ResumeLayout(false);
            this.groupNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetStart)).EndInit();
            this.groupEngines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerMotor;
        private System.Windows.Forms.Label labelMotorL;
        private System.Windows.Forms.Label labelMotorR;
        private System.Windows.Forms.PictureBox pictureMouse;
        private System.Windows.Forms.GroupBox groupControls;
        private System.Windows.Forms.Label labelMotors;
        private System.Windows.Forms.Label labelTurret;
        private System.Windows.Forms.Button buttonMotors;
        private System.Windows.Forms.Button buttonTurret;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.Button buttonLaser;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.Button buttonLights;
        private System.Windows.Forms.Label labelLaser;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelSterMode;
        private System.Windows.Forms.GroupBox groupMaxSpeed;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TrackBar trackMaxSpeed;
        private System.Windows.Forms.Label labelBrake;
        private System.Windows.Forms.Button buttonBrake;
        private System.Windows.Forms.PictureBox progressMotorLBack;
        private System.Windows.Forms.PictureBox progressMotorRBack;
        private System.Windows.Forms.PictureBox progressMotorLFront;
        private System.Windows.Forms.PictureBox progressMotorRFront;
        private System.Windows.Forms.PictureBox pictureTurret;
        private System.Windows.Forms.RadioButton radioTurret;
        private System.Windows.Forms.GroupBox groupTurret;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listIP;
        private System.Windows.Forms.GroupBox groupNetwork;
        private System.Windows.Forms.NumericUpDown numericNetEnd;
        private System.Windows.Forms.NumericUpDown numericNetStart;
        private System.Windows.Forms.TextBox textNetwork;
        private System.Windows.Forms.ToolStripStatusLabel labelConnectionMode;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelNetEnd;
        private System.Windows.Forms.Label labelNetStart;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.GroupBox groupEngines;
        private System.Windows.Forms.ToolStripStatusLabel labelVoltage;
    }
}

