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
    public partial class LogContrast : Form
    {
        public LogContrast()
        {
            InitializeComponent();
        }

        private void tbLogContrast_TextChanged(object sender, EventArgs e)
        {
            if ((tbLogContrast.Text == "") || (tbLogContrast.Text == "-"))
            {
                hscLogContrast.Value = 0;

            }
            else if ((Convert.ToInt16(tbLogContrast.Text) <= 105) && (Convert.ToInt16(tbLogContrast.Text) >= 0))
            {
                hscLogContrast.Value = Convert.ToInt16(tbLogContrast.Text);
            }
            else
            {
                MessageBox.Show("Input nilai error");
                tbLogContrast.Text = "0";
            }
        }

        private void btnLogContrast_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hscLogContrast_Scroll(object sender, ScrollEventArgs e)
        {
            tbLogContrast.Text = hscLogContrast.Value.ToString();
        }
    }
}
