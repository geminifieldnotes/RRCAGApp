using Garcia.Mariah.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace RRCAGMariahGarcia
{
    public partial class SalesQuoteForm : Form
    {
        public SalesQuoteForm()
        {
            InitializeComponent();

            txtVehiclesSalesPrice.TextChanged += new EventHandler(TxtVehiclesSalesPrice_TextChanged);
            txtTradeInValue.TextChanged += new EventHandler(TxtTradeInValue_TextChanged);

            btnCalculate.Click += new EventHandler(BtnCalculate_Click);

        }


        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            txtVehiclesSalesPrice.TextChanged += new EventHandler(TxtVehiclesSalesPrice_TextChanged);
            txtTradeInValue.TextChanged += new EventHandler(TxtTradeInValue_TextChanged);

            btnReset.Click += new EventHandler(BtnReset_Click);
            btnCalculate.Click += new EventHandler(BtnCalculate_Click);
            btnCalculate.Click += new EventHandler(VehicleSalesPriceInput_Validated);
            btnCalculate.Click += new EventHandler(TradeInInput_Validated);
            
            chkStereoSystem.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);
            chkLeatherInterior.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);
            chkComputerNavigation.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);

            radStandard.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);
            radPearlized.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);
            radCustomized.CheckedChanged += new EventHandler(AccessoriesAndExtriorFinish_Checked);
        }

        private void TxtVehiclesSalesPrice_TextChanged(object sender, EventArgs e)
        {
            // New input clears error 
            VehicleSalePriceError.Clear();
                
            // If vehicle sales price is modified, summary section outputs will be cleared.
            txtSummaryVehiclesSalePrice.Text = String.Empty;
            txtSummaryTradeIn.Text = String.Empty;
            txtSummaryTax.Text = String.Empty;
            txtSummarySubtotal.Text = String.Empty;
            txtSummaryOptions.Text = String.Empty;
            txtSummaryTotal.Text = String.Empty;
            txtSummaryAmountDue.Text = String.Empty;
            txtFinanceMonthlyPay.Text = String.Empty;
        }

        private void TxtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            // New input clears error
            TradeInValueError.Clear();

            // If trade in value is modified, summary section outputs will be cleared.
            txtSummaryVehiclesSalePrice.Text = String.Empty;
            txtSummaryTradeIn.Text = String.Empty;
            txtSummaryTax.Text = String.Empty;
            txtSummarySubtotal.Text = String.Empty;
            txtSummaryOptions.Text = String.Empty;
            txtSummaryTotal.Text = String.Empty;
            txtSummaryAmountDue.Text = String.Empty;
            txtFinanceMonthlyPay.Text = String.Empty;
        }

        private void TxtSummaryVehiclesSalePrice_Updated(object sender, EventArgs e)
        {
            txtSummaryVehiclesSalePrice.TextChanged += new EventHandler(VehicleSalesPriceInput_Validated);

            if (IsAllValid())
            {
                txtSummaryVehiclesSalePrice.Text = txtVehiclesSalesPrice.Text.ToString();

                // Formats to currency
                String.Format("{0:C}", txtSummaryVehiclesSalePrice.Text);
            }

        }

        private void TxtSummaryOptions_Updated(object sender, EventArgs e)
        {
            // Calculates sum 0f Accessories and Exterior Finish
            txtSummaryOptions.Text = txtSummaryOptions.Text.ToString();
        }

        private void TxtSummarySubtotal_Updated(object sender, EventArgs e)
        {
            decimal subtotal;

            if (IsAllValid())
            {
                subtotal = Decimal.Parse(txtSummaryVehiclesSalePrice.Text) + Decimal.Parse(txtSummaryOptions.Text);
                txtSummarySubtotal.Text = subtotal.ToString();
            }

            String.Format("{0:C}", txtSummarySubtotal.Text);
        }

        private void TxtSummaryTax_Updated(object sender, EventArgs e)
        {
            decimal taxes;

            if (IsAllValid())
            {
                taxes = Decimal.Parse(txtSummarySubtotal.Text) * 0.13M;
                txtSummaryTax.Text = taxes.ToString();
            }
        }

        private void TxtSummaryTotal_Updated(object sender, EventArgs e)
        {
            decimal total;

            if (IsAllValid())
            {
                total = Decimal.Parse(txtSummarySubtotal.Text) + Decimal.Parse(txtSummaryTax.Text);
                txtSummaryTotal.Text = total.ToString();
            }

            string.Format("{0:C}", txtSummaryTotal.Text);
        }

        private void TxtSummaryTradeIn_Updated(object sender, EventArgs e)
        {
            if (IsAllValid())
            {
                txtSummaryTradeIn.Text = txtTradeInValue.Text.ToString();
            }

            String.Format("{-0:C}", txtSummaryTradeIn.Text);
        }

        private void TxtSummaryAmountDue_Updated(object sender, EventArgs e)
        {
            decimal due;
            if (IsAllValid())
            {
                due = Decimal.Parse(txtSummaryTotal.Text) - Decimal.Parse(txtSummaryTradeIn.Text);
                txtSummaryAmountDue.Text = due.ToString();
            }

            String.Format("{0:C}", txtSummaryAmountDue.Text);
        }

        private void TxtFinanceMonthlyPay_TextChanged(object sender, EventArgs e)
        {
            decimal monthly;
            decimal interest;

            if (IsAllValid())
            {
                interest = (Decimal.Parse(txtSummaryAmountDue.Text) / nudFinanceYears.Value) * nudFinanceInterestRate.Value;
                monthly = (Decimal.Parse(txtSummaryAmountDue.Text) / nudFinanceYears.Value) + interest;
                txtFinanceMonthlyPay.Text = monthly.ToString();
            }

            string.Format("{0:C}", txtFinanceMonthlyPay.Text);
        }


        /// <summary>
        /// Validates vehicle sale price input and throws appropriate error.
        /// </summary>
        private void VehicleSalesPriceInput_Validated(object sender, EventArgs e)
        {
           
            if (txtVehiclesSalesPrice.Text == null || txtVehiclesSalesPrice.Text.Equals(String.Empty))
            {
                VehicleSalePriceError.SetError(txtVehiclesSalesPrice, "Vehicle price is a required field.");
            }
            else if (!Regex.IsMatch(txtVehiclesSalesPrice.Text, @"^\d+$"))
            {
                VehicleSalePriceError.SetError(txtVehiclesSalesPrice, "Vehicle price cannot contain letters or special characters.");
            } /*else if (decimal.Parse(txtVehiclesSalesPrice.Text) <= 0)
            {
                VehicleSalePriceError.SetError(txtVehiclesSalesPrice, "Vehicle price cannot be less than or equal to 0.");
            }*/ else if(!IsValidVehiclesSalePrice())
            {
                VehicleSalePriceError.Clear();
            }

        }

        /// <summary>
        /// Identifies validity of vehicle sale price.
        /// </summary>
        /// <returns>True if vehicle sale price is invalid</returns>
        private bool IsValidVehiclesSalePrice()
        {
            if (txtVehiclesSalesPrice.Text == null || txtVehiclesSalesPrice.Text.Equals(String.Empty))
            {
                return false;
            }else if (!Regex.IsMatch(txtVehiclesSalesPrice.Text, @"^\d+$"))
            {
                return false;
            }else if (!Regex.IsMatch(txtVehiclesSalesPrice.Text, @"^\d+$") && Decimal.Parse(txtVehiclesSalesPrice.Text) <= 0)
            {
                return false;
            }else
            {
                return true;
            }
        }

        /// <summary>
        /// Validates trade in value input and throws appropriate error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TradeInInput_Validated(object sender, EventArgs e)
        {
            if (txtTradeInValue.Text == null || txtTradeInValue.Text.Equals(String.Empty))
            {
                TradeInValueError.SetError(txtTradeInValue, "Trade-in value is a required field.");
            } else if (!Regex.IsMatch(txtTradeInValue.Text, @"^\d+$"))
            {
                TradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
            } else if ((!Regex.IsMatch(txtTradeInValue.Text, @"^\d+$") && Decimal.Parse(txtTradeInValue.Text) < 0))
            {
                TradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot be less than 0.");
            } else if ((!Regex.IsMatch(txtTradeInValue.Text, @"^\d+$") && Decimal.Parse(txtVehiclesSalesPrice.Text) < Decimal.Parse(txtTradeInValue.Text))) 
            { 
                TradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
            }else if(IsValidTradeInValue())
            {
                TradeInValueError.Clear();
            }
        }

        /// <summary>
        /// Identifies validity of trade in value.
        /// </summary>
        /// <returns>True if trade in value is valid</returns>
        private bool IsValidTradeInValue()
        {

            if (txtTradeInValue.Text == null || txtTradeInValue.Text.Equals(String.Empty))
            {
                return false;
            }
            else if (!Regex.IsMatch(txtTradeInValue.Text, @"^\d+$"))
            {
                return false;
            } else if (decimal.Parse(txtTradeInValue.Text) <= 0) 
            {
                return false;
            } else if (decimal.Parse(txtTradeInValue.Text) < 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        /// <summary>
        /// Identifies if there are no invalid inputs
        /// </summary>
        /// <returns>True if all inputs are valid</returns>
        private bool IsAllValid()
        {
            return (!IsValidVehiclesSalePrice() && !IsValidTradeInValue());
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            string messageConfirmation = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon boxIcon = MessageBoxIcon.Warning;
            DialogResult messageBox = MessageBox.Show(messageConfirmation, caption, button, boxIcon, MessageBoxDefaultButton.Button2);

            if (messageBox == DialogResult.Yes)
            {
                // Changes the form's initial state.
                txtVehiclesSalesPrice.Text = String.Empty;
                txtTradeInValue.Text = "0";
                VehicleSalePriceError.Clear();
                TradeInValueError.Clear();

                chkComputerNavigation.Checked = false;
                chkLeatherInterior.Checked = false;
                chkStereoSystem.Checked = false;

                radStandard.Checked = true;
                radPearlized.Checked = false;
                radCustomized.Checked = false;

                nudFinanceInterestRate.Value = 5;
                nudFinanceYears.Value = 1;

                txtSummaryVehiclesSalePrice.Text = String.Empty;
                txtSummaryTradeIn.Text = String.Empty;
                txtSummaryTax.Text = String.Empty;
                txtSummarySubtotal.Text = String.Empty;
                txtSummaryOptions.Text = String.Empty;
                txtSummaryTotal.Text = String.Empty;
                txtSummaryAmountDue.Text = String.Empty;
                txtFinanceMonthlyPay.Text = String.Empty;
            }
        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtSummaryVehiclesSalePrice.TextChanged += new EventHandler(TxtSummaryVehiclesSalePrice_Updated);
            txtSummaryTradeIn.TextChanged += new EventHandler(TxtSummaryTradeIn_Updated);
            txtSummaryTax.TextChanged += new EventHandler(TxtSummaryTax_Updated);
            txtSummaryOptions.TextChanged += new EventHandler(TxtSummaryOptions_Updated);
            txtSummarySubtotal.TextChanged += new EventHandler(TxtSummarySubtotal_Updated);
            txtSummaryTotal.TextChanged += new EventHandler(TxtSummaryTotal_Updated);
            txtSummaryAmountDue.TextChanged += new EventHandler(TxtSummaryAmountDue_Updated);
            txtFinanceMonthlyPay.TextChanged += new EventHandler(TxtFinanceMonthlyPay_TextChanged);

            if (!IsAllValid())
            {
                txtSummaryVehiclesSalePrice.Text = String.Empty;
                txtSummaryTradeIn.Text = String.Empty;
                txtSummaryTax.Text = String.Empty;
                txtSummarySubtotal.Text = String.Empty;
                txtSummaryOptions.Text = String.Empty;
                txtSummaryTotal.Text = String.Empty;
                txtSummaryAmountDue.Text = String.Empty;
                txtFinanceMonthlyPay.Text = String.Empty;
            }
            else
            {
                /*SalesQuote sales = new SalesQuote(decimal.Parse(txtVehiclesSalesPrice.Text), decimal.Parse(txtTradeInValue.Text),
                    decimal.Parse(txtSummaryTax.Text));

                txtSummaryVehiclesSalePrice.Text = sales.VehicleSalePrice.ToString();
                txtSummaryTradeIn.Text = sales.TradeInAmount.ToString();
                txtSummaryTax.Text = sales.SalesTax.ToString();*/
            }
        }

        private void AccessoriesAndExtriorFinish_Checked(object sender, EventArgs e)
        {
            decimal sum = 4242.42M;

            // Accessories options
            if (!IsCheckedStereo())
            {
                sum -= 505.05M;
            }

            if (!IsCheckedLeather())
            {
                sum -= 1010.10M;
            }

            if (!IsCheckedNavigation())
            {
                sum -= 1515.15M;
            }

            // Exterior finish options 
            if (!IsCheckedStandard())
            {
                sum -= 202.02M;
            }

            if (!IsCheckedPearlized())
            {
                sum -= 404.04M;
            }

            if (!IsCheckedCustomized())
            {
                sum -= 606.06M;
            }

            txtSummaryOptions.Text = sum.ToString();
        }


        public bool IsCheckedStereo()
        {
            return chkStereoSystem.Checked;
        }

        public bool IsCheckedNavigation()
        {
            return chkComputerNavigation.Checked;
        }

        public bool IsCheckedLeather()
        {
            return chkLeatherInterior.Checked;
        }


        public bool IsCheckedStandard()
        {
            return radStandard.Checked;
        }

        public bool IsCheckedPearlized()
        {
            return radPearlized.Checked;
        }

        public bool IsCheckedCustomized()
        {
            return radCustomized.Checked;
        }
    }
}
