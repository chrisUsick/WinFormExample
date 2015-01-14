using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace labChrisUsick
{
    /// <summary>
    /// The Main MDI form to contain  the application
    /// </summary>
    public partial class frmFrame : Form
    {
        public frmFrame()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// set the name of the MDI form on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFrame_Load(object sender, EventArgs e)
        {
            // set the display text of the form to use the app name from App.config
            this.Text = ConfigurationManager.AppSettings.Get("applicationName");
        }

        /// <summary>
        /// close the main form on exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            // close the main form, which closes the entire application
            this.Close();
        }

        /// <summary>
        /// show the commission form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpenCommissionCaculator_Click(object sender, EventArgs e)
        {
            // instanciate commission form
            frmCommission commission = new frmCommission();

            // set the parent to be frmFrame
            commission.MdiParent = this;

            // show the commission form
            commission.Show();
        }
    }
}
