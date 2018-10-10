namespace imgProc1
{
    partial class BrightnessContrast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrightnessContrast));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.hscBrightness = new System.Windows.Forms.HScrollBar();
            this.hscContrast = new System.Windows.Forms.HScrollBar();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.tbContrast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrast";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(314, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // hscBrightness
            // 
            this.hscBrightness.Location = new System.Drawing.Point(159, 43);
            this.hscBrightness.Maximum = 127;
            this.hscBrightness.Minimum = -127;
            this.hscBrightness.Name = "hscBrightness";
            this.hscBrightness.Size = new System.Drawing.Size(429, 17);
            this.hscBrightness.TabIndex = 3;
            this.hscBrightness.ValueChanged += new System.EventHandler(this.hscBrightness_ValueChanged);
            // 
            // hscContrast
            // 
            this.hscContrast.Location = new System.Drawing.Point(159, 87);
            this.hscContrast.Maximum = 127;
            this.hscContrast.Minimum = -127;
            this.hscContrast.Name = "hscContrast";
            this.hscContrast.Size = new System.Drawing.Size(429, 17);
            this.hscContrast.TabIndex = 4;
            this.hscContrast.ValueChanged += new System.EventHandler(this.hscContrast_ValueChanged);
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(602, 40);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(53, 20);
            this.tbBrightness.TabIndex = 5;
            this.tbBrightness.Text = "0";
            this.tbBrightness.TextChanged += new System.EventHandler(this.tbBrightness_TextChanged);
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(602, 84);
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(53, 20);
            this.tbContrast.TabIndex = 6;
            this.tbContrast.Text = "0";
            // 
            // BrightnessContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 189);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.hscContrast);
            this.Controls.Add(this.hscBrightness);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrightnessContrast";
            this.Text = "Brightness dan Contrast";
            this.Load += new System.EventHandler(this.BrightnessContrast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.HScrollBar hscBrightness;
        private System.Windows.Forms.HScrollBar hscContrast;
        public System.Windows.Forms.TextBox tbBrightness;
        public System.Windows.Forms.TextBox tbContrast;
    }
}