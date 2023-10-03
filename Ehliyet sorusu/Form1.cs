using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehliyet_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEhliyet_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(txtYas.Text);

            if (yas >= 18)
            {
                lblSonuc.Text = "Ehliyet almaya uygun mu: Uygun";
            }
            if (yas < 18)
            {
                lblSonuc.Text = "Ehliyet almaya uygun mu: Uygun değil";
            }
        }
    }
}
