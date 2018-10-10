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
    public partial class LogBrightness : Form
    {
        public LogBrightness()
        {
            InitializeComponent();
        }

        private void btnLogBrightness_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbLogBrightness.Text = hscLog.Value.ToString();
        }

        private void tbLogBrightness_TextChanged(object sender, EventArgs e)
        {
            if ((tbLogBrightness.Text == "") || (tbLogBrightness.Text == "-"))
            {
                hscLog.Value = 0;
                
            }
            else if ((Convert.ToInt16(tbLogBrightness.Text) <= 105) && (Convert.ToInt16(tbLogBrightness.Text) >= 0))
            {
                hscLog.Value = Convert.ToInt16(tbLogBrightness.Text);
            }
            else
            {
                MessageBox.Show("Input nilai error");
                tbLogBrightness.Text = "0";
            }
        }
    }
}
