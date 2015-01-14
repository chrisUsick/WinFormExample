using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace labChrisUsick
{
    public partial class frmCommission : Form
        
    {
        // commissions, values representing the upper ranges 
         
        private int[] commissionRanges = new int[] { 5000, 10000 };

        // parallel array to commissionRanges, with final value represent the final rate
        // Other values represent the rate of the corresponding range.
        private double[] commissionRates = new double[] { 0.1, 0.13, 0.2 };

        /// <summary>
        /// constructs a commission form
        /// </summary>
        public frmCommission()
        {
            InitializeComponent();
        }

        /// <summary>
        /// calculate the commission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // validate input
            try
            {
                // validated sales value
                double sales = validateSales(txtSales.Text);

                // commission variable
                double commission;

                //calculate commission
                commission = calculateCommission(sales);

                // display result
                lblCommissionOutput.Text = commission.ToString("C");
            }
            catch (System.ApplicationException ex)
            {
                // create modal form to display the error message.
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        /// <summary>
        /// calculate the commission given a sales value 
        /// </summary>
        /// <param name="sales">
        /// double value representing a sales amount
        /// </param>
        /// <returns></returns>
        private double calculateCommission(double sales)
        {
            // the commission to be returned
            double commission = 0;

            // iterate through the ranges
            for (int i = 0; i < commissionRanges.Length; i++)
            {
                // check if sales is <= the range
                if (sales <= commissionRanges[i])
                {
                    // set commission
                    commission = sales * commissionRates[i];
                    break;
                }
            }

            // test if the commission wasn't set
            if (commission == 0)
            {
                // use the final value in the commissionRates array
                commission = sales * commissionRates[commissionRates.Length - 1];
            }

            // return the calculated commission;
            return commission;
        }
        /// <summary>
        /// parse a string to a double if it meets the requirements of a 
        /// sales input. throws ApplicationExceptions if input isn't valid
        /// </summary>
        /// <param name="salesString">
        /// a raw string input
        /// </param>
        /// <exception cref="System.ApplicationException">Throws if input is invalid</exception>
        /// <returns>
        /// sales
        /// </returns>
        private double validateSales(string salesString) 
        {
            // no input was entered
            if (salesString.Equals("") || salesString == null)
            {
                throw new System.ApplicationException("Sales is a required field.");
            }
            // number is less than 0
            else if (Double.Parse(salesString) <= 0)
            {
                throw new System.ApplicationException("Sales must be greater than 0.");
            }
            // input is valid
            else
            {
                // return the parsed string
                return Double.Parse(salesString);
            }
        }
    }
}
