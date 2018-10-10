using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace imgProc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Tidak ada file yang disimpan");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Simpan File Citra";
                saveFile.Filter = "Image File (*.bmp,*.jpg,*.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == saveFile.ShowDialog())
                    this.pbOutput.Image.Save(saveFile.FileName);
            }
        }

        private static int truncate(int x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }

        

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";

            if (DialogResult.OK == openFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(openFile.FileName);
                toolStripStatusLabel1.Text = openFile.FileName + '|' + pbInput.Image.Width + "X" + pbInput.Image.Height;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");

            }else
            {
                BrightnessContrast bc = new BrightnessContrast();
                if (bc.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    int nilaiBrightness = Convert.ToInt16(bc.tbBrightness.Text);

                    int nilaiContrast = Convert.ToInt16(bc.tbContrast.Text);
                    double a = (259 * (nilaiContrast + 255)) / (255 * (259 - nilaiContrast));
                    progressBar1.Visible = true;
                    for(int i = 0; i < b.Width; i++)
                    {
                        for(int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            int r1 = truncate((c1.R + nilaiBrightness) + (Convert.ToInt16(a) * (c1.R - 128) + 128));
                            int g1 = truncate((c1.G + nilaiBrightness) + (Convert.ToInt16(a) * (c1.G - 128) + 128));
                            int b1 = truncate((c1.B + nilaiBrightness) + (Convert.ToInt16(a) * (c1.B - 128) + 128));
                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }

                    
                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keMerah(copy);
            this.pbOutput.Image = copy;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keKuning(copy);
            this.pbOutput.Image = copy;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keOrange(copy);
            this.pbOutput.Image = copy;
        }

        private void cyanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keCyan(copy);
            this.pbOutput.Image = copy;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.kePurple(copy);
            this.pbOutput.Image = copy;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keGrey(copy);
            this.pbOutput.Image = copy;
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keBrown(copy);
            this.pbOutput.Image = copy;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image==null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for(int i = 0; i < b.Width; i++)
                {
                    for(int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        
                        int r1 = 255 - c1.R;
                        int g1 = 255 - c1.G;
                        int b1 = 255 - c1.B;

                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void logBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada Citra yang Diolah");
            }
            else
            {
                LogBrightness frmLogBr = new LogBrightness();
                if (frmLogBr.ShowDialog() == DialogResult.Cancel)
                {
                    
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                    double nilaiBrighness = Convert.ToDouble(frmLogBr.tbLogBrightness.Text);
                    progressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            double r1 = nilaiBrighness * Math.Log10(c1.R + 1);
                            double g1 = nilaiBrighness * Math.Log10(c1.G + 1);
                            double b1 = nilaiBrighness * Math.Log10(c1.B + 1);

                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }

                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;


                }
            }
        }

        private void logContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada Citra yang Diolah");
            }
            else
            {
                LogContrast frmLogCo = new LogContrast();
                if (frmLogCo.ShowDialog() == DialogResult.Cancel)
                {

                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                    double nilaiContrast = Convert.ToDouble(frmLogCo.tbLogContrast.Text);
                    progressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            double r1 = nilaiContrast * Math.Log10(c1.R + 1);
                            double g1 = nilaiContrast * Math.Log10(c1.G + 1);
                            double b1 = nilaiContrast * Math.Log10(c1.B + 1);

                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }

                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;


                }
            }
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for(int i = 0; i < b.Width; i++)
                {
                    for(int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int grayAvg = (c1.R+c1.G+c1.B)/3;
                        b.SetPixel(i, j, Color.FromArgb(grayAvg, grayAvg, grayAvg));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void luminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int gLum = Convert.ToInt16(0.21 * c1.R + 0.72 * c1.G + 0.07 * c1.B);
                        b.SetPixel(i, j, Color.FromArgb(gLum, gLum, gLum));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int nilaiMax = Math.Max(c1.R, Math.Max(c1.G, c1.B));
                        int nilaiMin = Math.Min(c1.R, Math.Min(c1.G, c1.B));
                        int gLight = (nilaiMax + nilaiMin) / 2;
                        b.SetPixel(i, j, Color.FromArgb(gLight, gLight, gLight));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void BitDepth(int bit)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                double level = 255 - Math.Pow(2, bit) - 1;
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int R = Convert.ToInt16(Math.Round(c1.R / level) * level);
                        int G = Convert.ToInt16(Math.Round(c1.G / level) * level);
                        int B = Convert.ToInt16(Math.Round(c1.B / level)
                            * level);
                        b.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }

        private void bitToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BitDepth(1);
        }

        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitDepth(2);
        }

        private void bitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitDepth(3);
        }

        private void bitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BitDepth(4);
        }

        private void bitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BitDepth(5);
        }

        private void bitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BitDepth(6);
        }

        private void bitToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BitDepth(7);
        }

        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gammaCorrectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang diolah");
            }
            else
            {
                gammaCorrect gammaCor = new gammaCorrect();
                if (gammaCor.ShowDialog() == DialogResult.Cancel)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    double nilaiGamma = Convert.ToDouble(gammaCor.tbGamma.Text);
                    progressBar1.Visible = true;
                    double r1, g1, b1;

                    double merah, hijau, biru;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            merah = b.GetPixel(i, j).R;
                            hijau = b.GetPixel(i, j).G;
                            biru = b.GetPixel(i, j).B;

                            r1 = 255 * Math.Pow((merah / 255),  nilaiGamma);
                            g1 = 255 * Math.Pow((hijau / 255),  nilaiGamma);
                            b1 = 255 * Math.Pow((biru / 255),  nilaiGamma);
                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void inputToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                
                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if(sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }

                    histogramRGB.ShowDialog();
                }
                 
            }
        }

        

        private void outputToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbOutput.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }
                    
                    histogramRGB.ShowDialog();
                }

            }
        }

        private void inputOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }

                    histogramRGB.ShowDialog();
                }

            }

            if (pbOutput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pbOutput.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }

                    histogramRGB.ShowDialog();
                }   
            }
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void outputToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
