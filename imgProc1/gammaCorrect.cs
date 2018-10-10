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
    public partial class gammaCorrect : Form
    {
        public gammaCorrect()
        {
            InitializeComponent();
        }

        private void hscGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Text = Convert.ToString(hscGamma.Value);
        }

        private void tbGamma_TextChanged(object sender, EventArgs e)
        {
            if ((tbGamma.Text == "") || (tbGamma.Text == "-"))
            {
                hscGamma.Value = 0;
                tbGamma.Text = "0";
            }
            else if ((Convert.ToInt16(tbGamma.Text) <= 20) && (Convert.ToInt16(tbGamma.Text) >= 0.04))
            {
                hscGamma.Value = Convert.ToInt16(tbGamma.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbGamma.Text = "0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gammaCorrect_Load(object sender, EventArgs e)
        {
            tbGamma.Text = hscGamma.Value.ToString();
        }
    }
}
