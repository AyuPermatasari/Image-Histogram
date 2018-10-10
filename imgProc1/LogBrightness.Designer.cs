namespace imgProc1
{
    partial class LogBrightness
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
            this.hscLog = new System.Windows.Forms.HScrollBar();
            this.tbLogBrightness = new System.Windows.Forms.TextBox();
            this.btnLogBrightness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hscLog
            // 
            this.hscLog.Location = new System.Drawing.Point(31, 35);
            this.hscLog.Maximum = 105;
            this.hscLog.Name = "hscLog";
            this.hscLog.Size = new System.Drawing.Size(390, 19);
            this.hscLog.TabIndex = 0;
            this.hscLog.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // tbLogBrightness
            // 
            this.tbLogBrightness.Location = new System.Drawing.Point(458, 35);
            this.tbLogBrightness.Name = "tbLogBrightness";
            this.tbLogBrightness.Size = new System.Drawing.Size(71, 20);
            this.tbLogBrightness.TabIndex = 1;
            this.tbLogBrightness.Text = "0";
            this.tbLogBrightness.TextChanged += new System.EventHandler(this.tbLogBrightness_TextChanged);
            // 
            // btnLogBrightness
            // 
            this.btnLogBrightness.Location = new System.Drawing.Point(203, 84);
            this.btnLogBrightness.Name = "btnLogBrightness";
            this.btnLogBrightness.Size = new System.Drawing.Size(75, 23);
            this.btnLogBrightness.TabIndex = 2;
            this.btnLogBrightness.Text = "OK";
            this.btnLogBrightness.UseVisualStyleBackColor = true;
            this.btnLogBrightness.Click += new System.EventHandler(this.btnLogBrightness_Click);
            // 
            // LogBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 140);
            this.Controls.Add(this.btnLogBrightness);
            this.Controls.Add(this.tbLogBrightness);
            this.Controls.Add(this.hscLog);
            this.Name = "LogBrightness";
            this.Text = "LogBrightness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscLog;
        public System.Windows.Forms.TextBox tbLogBrightness;
        public System.Windows.Forms.Button btnLogBrightness;
    }
}