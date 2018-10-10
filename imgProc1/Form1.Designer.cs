namespace imgProc1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.brightnessToolStripMenuItem1,
            this.inverseToolStripMenuItem,
            this.logBrightnessToolStripMenuItem,
            this.logContrastToolStripMenuItem,
            this.bitDepthToolStripMenuItem,
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.cyanToolStripMenuItem1,
            this.purpleToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.gammaCorrectionToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem1
            // 
            this.brightnessToolStripMenuItem1.Name = "brightnessToolStripMenuItem1";
            this.brightnessToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem1.Text = "&Brightnes - Contrast";
            this.brightnessToolStripMenuItem1.Click += new System.EventHandler(this.brightnessToolStripMenuItem1_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // logBrightnessToolStripMenuItem
            // 
            this.logBrightnessToolStripMenuItem.Name = "logBrightnessToolStripMenuItem";
            this.logBrightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logBrightnessToolStripMenuItem.Text = "Log Brightness";
            this.logBrightnessToolStripMenuItem.Click += new System.EventHandler(this.logBrightnessToolStripMenuItem_Click);
            // 
            // logContrastToolStripMenuItem
            // 
            this.logContrastToolStripMenuItem.Name = "logContrastToolStripMenuItem";
            this.logContrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logContrastToolStripMenuItem.Text = "Log Contrast";
            this.logContrastToolStripMenuItem.Click += new System.EventHandler(this.logContrastToolStripMenuItem_Click);
            // 
            // bitDepthToolStripMenuItem
            // 
            this.bitDepthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem6,
            this.bitToolStripMenuItem,
            this.bitToolStripMenuItem1,
            this.bitToolStripMenuItem2,
            this.bitToolStripMenuItem3,
            this.bitToolStripMenuItem4,
            this.bitToolStripMenuItem5});
            this.bitDepthToolStripMenuItem.Name = "bitDepthToolStripMenuItem";
            this.bitDepthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitDepthToolStripMenuItem.Text = "Bit Depth";
            // 
            // bitToolStripMenuItem6
            // 
            this.bitToolStripMenuItem6.Name = "bitToolStripMenuItem6";
            this.bitToolStripMenuItem6.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem6.Text = "1 Bit";
            this.bitToolStripMenuItem6.Click += new System.EventHandler(this.bitToolStripMenuItem6_Click);
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem.Text = "2 Bit";
            this.bitToolStripMenuItem.Click += new System.EventHandler(this.bitToolStripMenuItem_Click);
            // 
            // bitToolStripMenuItem1
            // 
            this.bitToolStripMenuItem1.Name = "bitToolStripMenuItem1";
            this.bitToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem1.Text = "3 Bit";
            this.bitToolStripMenuItem1.Click += new System.EventHandler(this.bitToolStripMenuItem1_Click);
            // 
            // bitToolStripMenuItem2
            // 
            this.bitToolStripMenuItem2.Name = "bitToolStripMenuItem2";
            this.bitToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem2.Text = "4 Bit";
            this.bitToolStripMenuItem2.Click += new System.EventHandler(this.bitToolStripMenuItem2_Click);
            // 
            // bitToolStripMenuItem3
            // 
            this.bitToolStripMenuItem3.Name = "bitToolStripMenuItem3";
            this.bitToolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem3.Text = "5 Bit";
            this.bitToolStripMenuItem3.Click += new System.EventHandler(this.bitToolStripMenuItem3_Click);
            // 
            // bitToolStripMenuItem4
            // 
            this.bitToolStripMenuItem4.Name = "bitToolStripMenuItem4";
            this.bitToolStripMenuItem4.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem4.Text = "6 Bit";
            this.bitToolStripMenuItem4.Click += new System.EventHandler(this.bitToolStripMenuItem4_Click);
            // 
            // bitToolStripMenuItem5
            // 
            this.bitToolStripMenuItem5.Name = "bitToolStripMenuItem5";
            this.bitToolStripMenuItem5.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem5.Text = "7 Bit";
            this.bitToolStripMenuItem5.Click += new System.EventHandler(this.bitToolStripMenuItem5_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "&Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowToolStripMenuItem.Text = "&Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cyanToolStripMenuItem.Text = "&Orange";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem1
            // 
            this.cyanToolStripMenuItem1.Name = "cyanToolStripMenuItem1";
            this.cyanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cyanToolStripMenuItem1.Text = "&Cyan";
            this.cyanToolStripMenuItem1.Click += new System.EventHandler(this.cyanToolStripMenuItem1_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purpleToolStripMenuItem.Text = "&Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyToolStripMenuItem.Text = "&Grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brownToolStripMenuItem.Text = "&Brown";
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gammaCorrectionToolStripMenuItem.Text = "&Gamma Correction";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "File Path | Resolusi";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBHistogramToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(544, 46);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 3;
            this.pbOutput.TabStop = false;
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(12, 46);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 2;
            this.pbInput.TabStop = false;
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = global::imgProc1.Properties.Resources.open;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::imgProc1.Properties.Resources.save_icon_5;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "&Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::imgProc1.Properties.Resources.Oxygen480_actions_dialog_close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.greyScaleToolStripMenuItem.Image = global::imgProc1.Properties.Resources.brightness_png_image_90523;
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyScaleToolStripMenuItem.Text = "&GrayScale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.averageToolStripMenuItem.Text = "&Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lightnessToolStripMenuItem.Text = "&Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.luminanceToolStripMenuItem.Text = "&Luminosity";
            this.luminanceToolStripMenuItem.Click += new System.EventHandler(this.luminanceToolStripMenuItem_Click);
            // 
            // rGBHistogramToolStripMenuItem
            // 
            this.rGBHistogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.inputOutputToolStripMenuItem});
            this.rGBHistogramToolStripMenuItem.Name = "rGBHistogramToolStripMenuItem";
            this.rGBHistogramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBHistogramToolStripMenuItem.Text = "RGB Histogram";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputToolStripMenuItem.Text = "&Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click_1);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outputToolStripMenuItem.Text = "&Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click_1);
            // 
            // inputOutputToolStripMenuItem
            // 
            this.inputOutputToolStripMenuItem.Name = "inputOutputToolStripMenuItem";
            this.inputOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputOutputToolStripMenuItem.Text = "&InputOutput";
            this.inputOutputToolStripMenuItem.Click += new System.EventHandler(this.inputOutputToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitDepthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputOutputToolStripMenuItem;
    }
}

