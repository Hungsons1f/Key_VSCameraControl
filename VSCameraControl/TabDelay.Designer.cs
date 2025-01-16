namespace VSCameraControl
{
    partial class TabDelay
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay Time (ms)";
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(132, 59);
            this.tbDelay.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(88, 22);
            this.tbDelay.TabIndex = 1;
            this.tbDelay.TextChanged += new System.EventHandler(this.tbDelay_TextChanged);
            this.tbDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDelay_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(106, 31);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Delay 1";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(18, 104);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(98, 28);
            this.bStart.TabIndex = 11;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(254, 34);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(75, 75);
            this.btnLight.TabIndex = 12;
            this.btnLight.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(122, 104);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 28);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TabDelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 410);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabDelay";
            this.Text = "TabDelay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnReset;
    }
}