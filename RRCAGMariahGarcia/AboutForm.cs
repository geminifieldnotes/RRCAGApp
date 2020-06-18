using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGMariahGarcia
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            txtDescription.TextChanged += new EventHandler(TxtDescription_TextChanged);
            btnAboutOk.Click += new EventHandler(BtnAboutOk_Click);

        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAboutOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
