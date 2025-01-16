namespace VSCameraControl
{
    partial class TabCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProgramNumber = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tProgramNo = new System.Windows.Forms.Label();
            this.tLocation = new System.Windows.Forms.Label();
            this.tRunMode = new System.Windows.Forms.Label();
            this.tConnected = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.bChangeProgram = new System.Windows.Forms.Button();
            this.bClearError = new System.Windows.Forms.Button();
            this.bSetup = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.btnTrigger1 = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.btnConnectCam1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(9, 7);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(132, 31);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Camera 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbProgramNumber);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(14, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(202, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Internal Memory",
            "microSD card"});
            this.cbLocation.Location = new System.Drawing.Point(77, 79);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(118, 21);
            this.cbLocation.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Program No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP Address";
            // 
            // tbProgramNumber
            // 
            this.tbProgramNumber.Location = new System.Drawing.Point(77, 109);
            this.tbProgramNumber.Margin = new System.Windows.Forms.Padding(8, 2, 2, 8);
            this.tbProgramNumber.Name = "tbProgramNumber";
            this.tbProgramNumber.Size = new System.Drawing.Size(118, 20);
            this.tbProgramNumber.TabIndex = 8;
            this.tbProgramNumber.Text = "0";
            this.tbProgramNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProgramNumber_KeyPress);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(77, 51);
            this.tbPort.Margin = new System.Windows.Forms.Padding(8, 2, 2, 8);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(118, 20);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "8500";
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(77, 24);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(8, 2, 2, 8);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(118, 20);
            this.tbIPAddress.TabIndex = 10;
            this.tbIPAddress.Text = "192.168.0.10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tProgramNo);
            this.groupBox2.Controls.Add(this.tLocation);
            this.groupBox2.Controls.Add(this.tRunMode);
            this.groupBox2.Controls.Add(this.tConnected);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(229, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 138);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // tProgramNo
            // 
            this.tProgramNo.AutoSize = true;
            this.tProgramNo.Location = new System.Drawing.Point(117, 111);
            this.tProgramNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tProgramNo.Name = "tProgramNo";
            this.tProgramNo.Size = new System.Drawing.Size(13, 13);
            this.tProgramNo.TabIndex = 14;
            this.tProgramNo.Text = "--";
            this.tProgramNo.TextChanged += new System.EventHandler(this.tProgramNo_TextChanged);
            // 
            // tLocation
            // 
            this.tLocation.AutoSize = true;
            this.tLocation.Location = new System.Drawing.Point(117, 82);
            this.tLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tLocation.Name = "tLocation";
            this.tLocation.Size = new System.Drawing.Size(13, 13);
            this.tLocation.TabIndex = 15;
            this.tLocation.Text = "--";
            this.tLocation.TextChanged += new System.EventHandler(this.tLocation_TextChanged);
            // 
            // tRunMode
            // 
            this.tRunMode.AutoSize = true;
            this.tRunMode.Location = new System.Drawing.Point(117, 54);
            this.tRunMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tRunMode.Name = "tRunMode";
            this.tRunMode.Size = new System.Drawing.Size(13, 13);
            this.tRunMode.TabIndex = 16;
            this.tRunMode.Text = "--";
            this.tRunMode.TextChanged += new System.EventHandler(this.tRunMode_TextChanged);
            // 
            // tConnected
            // 
            this.tConnected.AutoSize = true;
            this.tConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tConnected.Location = new System.Drawing.Point(117, 25);
            this.tConnected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tConnected.Name = "tConnected";
            this.tConnected.Size = new System.Drawing.Size(91, 16);
            this.tConnected.TabIndex = 13;
            this.tConnected.Text = "Not Connect";
            this.tConnected.TextChanged += new System.EventHandler(this.tConnected_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Current Program No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Current Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Connection Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.bChangeProgram);
            this.groupBox3.Controls.Add(this.bClearError);
            this.groupBox3.Controls.Add(this.bSetup);
            this.groupBox3.Controls.Add(this.bRun);
            this.groupBox3.Controls.Add(this.btnTrigger1);
            this.groupBox3.Controls.Add(this.bDisconnect);
            this.groupBox3.Controls.Add(this.btnConnectCam1);
            this.groupBox3.Location = new System.Drawing.Point(14, 193);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(434, 128);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(160, 56);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 26);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // bChangeProgram
            // 
            this.bChangeProgram.Location = new System.Drawing.Point(281, 89);
            this.bChangeProgram.Margin = new System.Windows.Forms.Padding(2);
            this.bChangeProgram.Name = "bChangeProgram";
            this.bChangeProgram.Size = new System.Drawing.Size(117, 26);
            this.bChangeProgram.TabIndex = 10;
            this.bChangeProgram.Text = "Change Program";
            this.bChangeProgram.UseVisualStyleBackColor = true;
            this.bChangeProgram.Click += new System.EventHandler(this.bChangeProgram1_Click);
            // 
            // bClearError
            // 
            this.bClearError.Location = new System.Drawing.Point(160, 89);
            this.bClearError.Margin = new System.Windows.Forms.Padding(2);
            this.bClearError.Name = "bClearError";
            this.bClearError.Size = new System.Drawing.Size(117, 26);
            this.bClearError.TabIndex = 11;
            this.bClearError.Text = "Clear Error";
            this.bClearError.UseVisualStyleBackColor = true;
            this.bClearError.Click += new System.EventHandler(this.bClearError1_Click);
            // 
            // bSetup
            // 
            this.bSetup.Location = new System.Drawing.Point(281, 56);
            this.bSetup.Margin = new System.Windows.Forms.Padding(2);
            this.bSetup.Name = "bSetup";
            this.bSetup.Size = new System.Drawing.Size(117, 26);
            this.bSetup.TabIndex = 12;
            this.bSetup.Text = "Setup";
            this.bSetup.UseVisualStyleBackColor = true;
            this.bSetup.Click += new System.EventHandler(this.bSetup1_Click);
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(281, 23);
            this.bRun.Margin = new System.Windows.Forms.Padding(2);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(117, 26);
            this.bRun.TabIndex = 13;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun1_Click);
            // 
            // btnTrigger1
            // 
            this.btnTrigger1.Location = new System.Drawing.Point(160, 23);
            this.btnTrigger1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrigger1.Name = "btnTrigger1";
            this.btnTrigger1.Size = new System.Drawing.Size(117, 26);
            this.btnTrigger1.TabIndex = 14;
            this.btnTrigger1.Text = "Trigger";
            this.btnTrigger1.UseVisualStyleBackColor = true;
            this.btnTrigger1.Click += new System.EventHandler(this.btnTrigger1_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.AutoSize = true;
            this.bDisconnect.Location = new System.Drawing.Point(28, 73);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(8, 8, 2, 8);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(117, 42);
            this.bDisconnect.TabIndex = 7;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect1_Click);
            // 
            // btnConnectCam1
            // 
            this.btnConnectCam1.AutoSize = true;
            this.btnConnectCam1.Location = new System.Drawing.Point(28, 23);
            this.btnConnectCam1.Margin = new System.Windows.Forms.Padding(8, 8, 2, 8);
            this.btnConnectCam1.Name = "btnConnectCam1";
            this.btnConnectCam1.Size = new System.Drawing.Size(117, 42);
            this.btnConnectCam1.TabIndex = 8;
            this.btnConnectCam1.Text = "Connect";
            this.btnConnectCam1.UseVisualStyleBackColor = true;
            this.btnConnectCam1.TextChanged += new System.EventHandler(this.btnConnectCam1_TextChanged);
            this.btnConnectCam1.Click += new System.EventHandler(this.btnConnectCam1_Click);
            // 
            // TabCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabCamera";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProgramNumber;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tProgramNo;
        private System.Windows.Forms.Label tLocation;
        private System.Windows.Forms.Label tRunMode;
        private System.Windows.Forms.Label tConnected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button bChangeProgram;
        private System.Windows.Forms.Button bClearError;
        private System.Windows.Forms.Button bSetup;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Button btnTrigger1;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button btnConnectCam1;
    }
}

