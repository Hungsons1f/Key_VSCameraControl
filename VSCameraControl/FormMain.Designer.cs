namespace VSCameraControl
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.btnRemoveCam = new System.Windows.Forms.Button();
            this.ctCamBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.btnTriggerAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(5, 13);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(472, 461);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(464, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(11, 414);
            this.btnAddTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(118, 23);
            this.btnAddTab.TabIndex = 1;
            this.btnAddTab.Text = "Add Cam";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddCam_Click);
            // 
            // btnRemoveCam
            // 
            this.btnRemoveCam.Location = new System.Drawing.Point(11, 468);
            this.btnRemoveCam.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCam.Name = "btnRemoveCam";
            this.btnRemoveCam.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveCam.TabIndex = 1;
            this.btnRemoveCam.Text = "Remove";
            this.btnRemoveCam.UseVisualStyleBackColor = true;
            this.btnRemoveCam.Click += new System.EventHandler(this.btnRemoveCam_Click);
            // 
            // ctCamBtn
            // 
            this.ctCamBtn.AutoScroll = true;
            this.ctCamBtn.BackColor = System.Drawing.Color.White;
            this.ctCamBtn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ctCamBtn.Location = new System.Drawing.Point(5, 18);
            this.ctCamBtn.Name = "ctCamBtn";
            this.ctCamBtn.Size = new System.Drawing.Size(104, 375);
            this.ctCamBtn.TabIndex = 3;
            this.ctCamBtn.WrapContents = false;
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Location = new System.Drawing.Point(11, 441);
            this.btnAddDelay.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(118, 23);
            this.btnAddDelay.TabIndex = 1;
            this.btnAddDelay.Text = "Add Delay";
            this.btnAddDelay.UseVisualStyleBackColor = true;
            this.btnAddDelay.Click += new System.EventHandler(this.btnAddDelay_Click);
            // 
            // btnTriggerAll
            // 
            this.btnTriggerAll.Location = new System.Drawing.Point(628, 424);
            this.btnTriggerAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnTriggerAll.Name = "btnTriggerAll";
            this.btnTriggerAll.Size = new System.Drawing.Size(97, 67);
            this.btnTriggerAll.TabIndex = 1;
            this.btnTriggerAll.Text = "Trigger All";
            this.btnTriggerAll.UseVisualStyleBackColor = true;
            this.btnTriggerAll.Click += new System.EventHandler(this.btnTriggerAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctCamBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(118, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sequence";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(134, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 479);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(702, 396);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveCam);
            this.Controls.Add(this.btnAddDelay);
            this.Controls.Add(this.btnTriggerAll);
            this.Controls.Add(this.btnAddTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Camera Trigger App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.Button btnRemoveCam;
        private System.Windows.Forms.FlowLayoutPanel ctCamBtn;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.Button btnTriggerAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHelp;
    }
}