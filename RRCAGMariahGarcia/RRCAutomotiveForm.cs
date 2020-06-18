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
    public partial class RRCAutomotiveForm : Form
    {
        public RRCAutomotiveForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(RRCAutomotiveForm_Load);

        }

        /// <summary>
        /// Initializes an instance of the RRC Automotive Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RRCAutomotiveForm_Load(object sender, EventArgs e)
        {
            salesQuoteToolStripMenuItem.Click += new EventHandler(SalesQuoteToolStripMenuItem_Click);
            mnuFileExit.Click += new EventHandler(MnuFileExit_Click);
            mnuHelpAbout.Click += new EventHandler(MnuHelpAbout_Click);

        }

        /// <summary>
        /// Opens the sales quote form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form = new SalesQuoteForm();
            form.Show();
        }

        /// <summary>
        /// Will be used in a future assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarWashToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the launcher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Will be used for future assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the About form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }
    }
}
