namespace RRCAGMariahGarcia
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtVehiclesSalesPrice = new System.Windows.Forms.TextBox();
            this.lblVehiclesSalePrice = new System.Windows.Forms.Label();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomized = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtSummaryAmountDue = new System.Windows.Forms.TextBox();
            this.txtSummaryTradeIn = new System.Windows.Forms.TextBox();
            this.txtSummaryTotal = new System.Windows.Forms.TextBox();
            this.txtSummaryTax = new System.Windows.Forms.TextBox();
            this.txtSummarySubtotal = new System.Windows.Forms.TextBox();
            this.txtSummaryOptions = new System.Windows.Forms.TextBox();
            this.txtSummaryVehiclesSalePrice = new System.Windows.Forms.TextBox();
            this.lblSummaryAmountDue = new System.Windows.Forms.Label();
            this.lblSummaryTradeIn = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.lblSummaryOptions = new System.Windows.Forms.Label();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblFinanceMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFinanceAnnual = new System.Windows.Forms.Label();
            this.lblFinanceInterestRate = new System.Windows.Forms.Label();
            this.txtFinanceMonthlyPay = new System.Windows.Forms.TextBox();
            this.nudFinanceInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudFinanceYears = new System.Windows.Forms.NumericUpDown();
            this.lblFinanceYears = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.VehicleSalePriceError = new System.Windows.Forms.ErrorProvider(this.components);
            this.TradeInValueError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleSalePriceError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeInValueError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVehiclesSalesPrice
            // 
            this.txtVehiclesSalesPrice.BackColor = System.Drawing.SystemColors.Window;
            this.VehicleSalePriceError.SetIconPadding(this.txtVehiclesSalesPrice, 3);
            this.txtVehiclesSalesPrice.Location = new System.Drawing.Point(123, 18);
            this.txtVehiclesSalesPrice.Name = "txtVehiclesSalesPrice";
            this.txtVehiclesSalesPrice.Size = new System.Drawing.Size(118, 20);
            this.txtVehiclesSalesPrice.TabIndex = 0;
            // 
            // lblVehiclesSalePrice
            // 
            this.lblVehiclesSalePrice.AutoSize = true;
            this.lblVehiclesSalePrice.Location = new System.Drawing.Point(21, 21);
            this.lblVehiclesSalePrice.Name = "lblVehiclesSalePrice";
            this.lblVehiclesSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblVehiclesSalePrice.TabIndex = 1;
            this.lblVehiclesSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(38, 54);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(79, 13);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.TradeInValueError.SetIconPadding(this.txtTradeInValue, 3);
            this.txtTradeInValue.Location = new System.Drawing.Point(123, 51);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(118, 20);
            this.txtTradeInValue.TabIndex = 1;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStereoSystem.Location = new System.Drawing.Point(26, 30);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 2;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(24, 91);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(217, 142);
            this.grpAccessories.TabIndex = 5;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkComputerNavigation.Location = new System.Drawing.Point(26, 100);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNavigation.TabIndex = 4;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLeatherInterior.Location = new System.Drawing.Point(26, 63);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 3;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomized);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(24, 257);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(217, 141);
            this.grpExteriorFinish.TabIndex = 6;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomized
            // 
            this.radCustomized.AutoSize = true;
            this.radCustomized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCustomized.Location = new System.Drawing.Point(26, 100);
            this.radCustomized.Name = "radCustomized";
            this.radCustomized.Size = new System.Drawing.Size(123, 17);
            this.radCustomized.TabIndex = 2;
            this.radCustomized.TabStop = true;
            this.radCustomized.Text = "Customized Detailing";
            this.radCustomized.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPearlized.Location = new System.Drawing.Point(26, 62);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radStandard.Location = new System.Drawing.Point(26, 29);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 5;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 416);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 31);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtSummaryAmountDue);
            this.grpSummary.Controls.Add(this.txtSummaryTradeIn);
            this.grpSummary.Controls.Add(this.txtSummaryTotal);
            this.grpSummary.Controls.Add(this.txtSummaryTax);
            this.grpSummary.Controls.Add(this.txtSummarySubtotal);
            this.grpSummary.Controls.Add(this.txtSummaryOptions);
            this.grpSummary.Controls.Add(this.txtSummaryVehiclesSalePrice);
            this.grpSummary.Controls.Add(this.lblSummaryAmountDue);
            this.grpSummary.Controls.Add(this.lblSummaryTradeIn);
            this.grpSummary.Controls.Add(this.lblSummaryTotal);
            this.grpSummary.Controls.Add(this.lblSummarySalesTax);
            this.grpSummary.Controls.Add(this.lblSummarySubtotal);
            this.grpSummary.Controls.Add(this.lblSummaryOptions);
            this.grpSummary.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.grpSummary.Location = new System.Drawing.Point(280, 18);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(287, 277);
            this.grpSummary.TabIndex = 8;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtSummaryAmountDue
            // 
            this.txtSummaryAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSummaryAmountDue.Enabled = false;
            this.txtSummaryAmountDue.Location = new System.Drawing.Point(138, 232);
            this.txtSummaryAmountDue.Name = "txtSummaryAmountDue";
            this.txtSummaryAmountDue.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryAmountDue.TabIndex = 13;
            // 
            // txtSummaryTradeIn
            // 
            this.txtSummaryTradeIn.Enabled = false;
            this.txtSummaryTradeIn.Location = new System.Drawing.Point(138, 195);
            this.txtSummaryTradeIn.Name = "txtSummaryTradeIn";
            this.txtSummaryTradeIn.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryTradeIn.TabIndex = 12;
            // 
            // txtSummaryTotal
            // 
            this.txtSummaryTotal.Enabled = false;
            this.txtSummaryTotal.Location = new System.Drawing.Point(138, 160);
            this.txtSummaryTotal.Name = "txtSummaryTotal";
            this.txtSummaryTotal.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryTotal.TabIndex = 11;
            // 
            // txtSummaryTax
            // 
            this.txtSummaryTax.Enabled = false;
            this.txtSummaryTax.Location = new System.Drawing.Point(139, 128);
            this.txtSummaryTax.Name = "txtSummaryTax";
            this.txtSummaryTax.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryTax.TabIndex = 10;
            // 
            // txtSummarySubtotal
            // 
            this.txtSummarySubtotal.Enabled = false;
            this.txtSummarySubtotal.Location = new System.Drawing.Point(139, 98);
            this.txtSummarySubtotal.Name = "txtSummarySubtotal";
            this.txtSummarySubtotal.Size = new System.Drawing.Size(119, 20);
            this.txtSummarySubtotal.TabIndex = 9;
            // 
            // txtSummaryOptions
            // 
            this.txtSummaryOptions.Enabled = false;
            this.txtSummaryOptions.Location = new System.Drawing.Point(139, 67);
            this.txtSummaryOptions.Name = "txtSummaryOptions";
            this.txtSummaryOptions.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryOptions.TabIndex = 8;
            // 
            // txtSummaryVehiclesSalePrice
            // 
            this.txtSummaryVehiclesSalePrice.Enabled = false;
            this.txtSummaryVehiclesSalePrice.Location = new System.Drawing.Point(139, 36);
            this.txtSummaryVehiclesSalePrice.Name = "txtSummaryVehiclesSalePrice";
            this.txtSummaryVehiclesSalePrice.Size = new System.Drawing.Size(119, 20);
            this.txtSummaryVehiclesSalePrice.TabIndex = 7;
            this.txtSummaryVehiclesSalePrice.TextChanged += new System.EventHandler(TxtSummaryVehiclesSalePrice_Updated);
            // 
            // lblSummaryAmountDue
            // 
            this.lblSummaryAmountDue.AutoSize = true;
            this.lblSummaryAmountDue.Location = new System.Drawing.Point(63, 235);
            this.lblSummaryAmountDue.Name = "lblSummaryAmountDue";
            this.lblSummaryAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblSummaryAmountDue.TabIndex = 6;
            this.lblSummaryAmountDue.Text = "Amount Due:";
            this.lblSummaryAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTradeIn
            // 
            this.lblSummaryTradeIn.AutoSize = true;
            this.lblSummaryTradeIn.Location = new System.Drawing.Point(83, 198);
            this.lblSummaryTradeIn.Name = "lblSummaryTradeIn";
            this.lblSummaryTradeIn.Size = new System.Drawing.Size(49, 13);
            this.lblSummaryTradeIn.TabIndex = 5;
            this.lblSummaryTradeIn.Text = "Trade-in:";
            this.lblSummaryTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.AutoSize = true;
            this.lblSummaryTotal.Location = new System.Drawing.Point(98, 163);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(34, 13);
            this.lblSummaryTotal.TabIndex = 4;
            this.lblSummaryTotal.Text = "Total:";
            this.lblSummaryTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.AutoSize = true;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(46, 131);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSummarySalesTax.TabIndex = 3;
            this.lblSummarySalesTax.Text = "Sales Tax (13%):";
            this.lblSummarySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.AutoSize = true;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(83, 101);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSummarySubtotal.TabIndex = 2;
            this.lblSummarySubtotal.Text = "Subtotal:";
            this.lblSummarySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryOptions
            // 
            this.lblSummaryOptions.AutoSize = true;
            this.lblSummaryOptions.Location = new System.Drawing.Point(86, 70);
            this.lblSummaryOptions.Name = "lblSummaryOptions";
            this.lblSummaryOptions.Size = new System.Drawing.Size(46, 13);
            this.lblSummaryOptions.TabIndex = 1;
            this.lblSummaryOptions.Text = "Options:";
            this.lblSummaryOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.AutoSize = true;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(30, 39);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblSummaryVehicleSalePrice.TabIndex = 0;
            this.lblSummaryVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            this.lblSummaryVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblFinanceMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblFinanceAnnual);
            this.grpFinance.Controls.Add(this.lblFinanceInterestRate);
            this.grpFinance.Controls.Add(this.txtFinanceMonthlyPay);
            this.grpFinance.Controls.Add(this.nudFinanceInterestRate);
            this.grpFinance.Controls.Add(this.nudFinanceYears);
            this.grpFinance.Controls.Add(this.lblFinanceYears);
            this.grpFinance.Location = new System.Drawing.Point(280, 301);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(287, 97);
            this.grpFinance.TabIndex = 9;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblFinanceMonthlyPayment
            // 
            this.lblFinanceMonthlyPayment.AutoSize = true;
            this.lblFinanceMonthlyPayment.Location = new System.Drawing.Point(184, 31);
            this.lblFinanceMonthlyPayment.Name = "lblFinanceMonthlyPayment";
            this.lblFinanceMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblFinanceMonthlyPayment.TabIndex = 6;
            this.lblFinanceMonthlyPayment.Text = "Monthly Payment";
            this.lblFinanceMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinanceAnnual
            // 
            this.lblFinanceAnnual.AutoSize = true;
            this.lblFinanceAnnual.Location = new System.Drawing.Point(98, 16);
            this.lblFinanceAnnual.Name = "lblFinanceAnnual";
            this.lblFinanceAnnual.Size = new System.Drawing.Size(40, 13);
            this.lblFinanceAnnual.TabIndex = 5;
            this.lblFinanceAnnual.Text = "Annual";
            // 
            // lblFinanceInterestRate
            // 
            this.lblFinanceInterestRate.AutoSize = true;
            this.lblFinanceInterestRate.ImageKey = "(none)";
            this.lblFinanceInterestRate.Location = new System.Drawing.Point(98, 31);
            this.lblFinanceInterestRate.Name = "lblFinanceInterestRate";
            this.lblFinanceInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblFinanceInterestRate.TabIndex = 4;
            this.lblFinanceInterestRate.Text = "Interest Rate";
            this.lblFinanceInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFinanceMonthlyPay
            // 
            this.txtFinanceMonthlyPay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFinanceMonthlyPay.Enabled = false;
            this.txtFinanceMonthlyPay.Location = new System.Drawing.Point(187, 56);
            this.txtFinanceMonthlyPay.Name = "txtFinanceMonthlyPay";
            this.txtFinanceMonthlyPay.Size = new System.Drawing.Size(85, 20);
            this.txtFinanceMonthlyPay.TabIndex = 3;
            // 
            // nudFinanceInterestRate
            // 
            this.nudFinanceInterestRate.DecimalPlaces = 2;
            this.nudFinanceInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFinanceInterestRate.Location = new System.Drawing.Point(101, 56);
            this.nudFinanceInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFinanceInterestRate.Name = "nudFinanceInterestRate";
            this.nudFinanceInterestRate.Size = new System.Drawing.Size(69, 20);
            this.nudFinanceInterestRate.TabIndex = 7;
            this.nudFinanceInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudFinanceYears
            // 
            this.nudFinanceYears.Location = new System.Drawing.Point(20, 56);
            this.nudFinanceYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFinanceYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFinanceYears.Name = "nudFinanceYears";
            this.nudFinanceYears.Size = new System.Drawing.Size(63, 20);
            this.nudFinanceYears.TabIndex = 6;
            this.nudFinanceYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFinanceYears
            // 
            this.lblFinanceYears.AutoSize = true;
            this.lblFinanceYears.Location = new System.Drawing.Point(17, 31);
            this.lblFinanceYears.Name = "lblFinanceYears";
            this.lblFinanceYears.Size = new System.Drawing.Size(66, 13);
            this.lblFinanceYears.TabIndex = 0;
            this.lblFinanceYears.Text = "No. of Years";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(457, 414);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 31);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // VehicleSalePriceError
            // 
            this.VehicleSalePriceError.BlinkRate = 0;
            this.VehicleSalePriceError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.VehicleSalePriceError.ContainerControl = this;
            // 
            // TradeInValueError
            // 
            this.TradeInValueError.BlinkRate = 0;
            this.TradeInValueError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TradeInValueError.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 457);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.lblVehiclesSalePrice);
            this.Controls.Add(this.txtVehiclesSalesPrice);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote ";
            this.Load += new System.EventHandler(this.SalesQuoteForm_Load);
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleSalePriceError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeInValueError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehiclesSalesPrice;
        private System.Windows.Forms.Label lblVehiclesSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radCustomized;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblSummaryAmountDue;
        private System.Windows.Forms.Label lblSummaryTradeIn;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label lblSummaryOptions;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.TextBox txtSummaryAmountDue;
        private System.Windows.Forms.TextBox txtSummaryTradeIn;
        private System.Windows.Forms.TextBox txtSummaryTotal;
        private System.Windows.Forms.TextBox txtSummaryTax;
        private System.Windows.Forms.TextBox txtSummarySubtotal;
        private System.Windows.Forms.TextBox txtSummaryOptions;
        private System.Windows.Forms.TextBox txtSummaryVehiclesSalePrice;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblFinanceMonthlyPayment;
        private System.Windows.Forms.Label lblFinanceAnnual;
        private System.Windows.Forms.Label lblFinanceInterestRate;
        private System.Windows.Forms.TextBox txtFinanceMonthlyPay;
        private System.Windows.Forms.NumericUpDown nudFinanceInterestRate;
        private System.Windows.Forms.NumericUpDown nudFinanceYears;
        private System.Windows.Forms.Label lblFinanceYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ErrorProvider VehicleSalePriceError;
        private System.Windows.Forms.ErrorProvider TradeInValueError;
    }
}