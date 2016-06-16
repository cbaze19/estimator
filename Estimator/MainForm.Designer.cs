using System;

namespace Estimator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mfWindowStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadEstimate = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveEstimate = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProjectDetails = new System.Windows.Forms.GroupBox();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.lJobType = new System.Windows.Forms.Label();
            this.tbScope = new System.Windows.Forms.TextBox();
            this.lScope = new System.Windows.Forms.Label();
            this.tbSpecial = new System.Windows.Forms.TextBox();
            this.lSpecial = new System.Windows.Forms.Label();
            this.tbDeck = new System.Windows.Forms.TextBox();
            this.lDeck = new System.Windows.Forms.Label();
            this.tbArchitect = new System.Windows.Forms.TextBox();
            this.lArchitect = new System.Windows.Forms.Label();
            this.tbContractor = new System.Windows.Forms.TextBox();
            this.lContractor = new System.Windows.Forms.Label();
            this.bidDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lBidDate = new System.Windows.Forms.Label();
            this.lProjectName = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.gbSquares = new System.Windows.Forms.GroupBox();
            this.tbSoffitPanelSquares = new System.Windows.Forms.NumericUpDown();
            this.tbWallPanelSquares = new System.Windows.Forms.NumericUpDown();
            this.tbStandingSeamSquares = new System.Windows.Forms.NumericUpDown();
            this.lSoffitPanelSquares = new System.Windows.Forms.Label();
            this.lWallPanelSquares = new System.Windows.Forms.Label();
            this.tbTotalSquares = new System.Windows.Forms.TextBox();
            this.lTotalSquares = new System.Windows.Forms.Label();
            this.lStandingSeam = new System.Windows.Forms.Label();
            this.gbEstimation = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lTotalBid = new System.Windows.Forms.Label();
            this.lMiscAddOn2 = new System.Windows.Forms.Label();
            this.lMiscAddOn1 = new System.Windows.Forms.Label();
            this.lOverhead = new System.Windows.Forms.Label();
            this.lSummarySubtotalBid = new System.Windows.Forms.Label();
            this.lSummaryPerSquare = new System.Windows.Forms.Label();
            this.lSummaryTotals = new System.Windows.Forms.Label();
            this.lOtherCosts = new System.Windows.Forms.Label();
            this.lMetalRoofLabor = new System.Windows.Forms.Label();
            this.lMetalRoofMaterial = new System.Windows.Forms.Label();
            this.gbOtherOverview = new System.Windows.Forms.GroupBox();
            this.lOtherTotalCost = new System.Windows.Forms.Label();
            this.gbLaborOverview = new System.Windows.Forms.GroupBox();
            this.lLaborCostPerSquare = new System.Windows.Forms.Label();
            this.lLaborTotalCost = new System.Windows.Forms.Label();
            this.lLaborBurden = new System.Windows.Forms.Label();
            this.lLaborSubtotal = new System.Windows.Forms.Label();
            this.gbMatOverview = new System.Windows.Forms.GroupBox();
            this.lMatCostPerSquare = new System.Windows.Forms.Label();
            this.lTotalMatCost = new System.Windows.Forms.Label();
            this.lMatTax = new System.Windows.Forms.Label();
            this.lWaste = new System.Windows.Forms.Label();
            this.lMatSubtotal = new System.Windows.Forms.Label();
            this.tabMats = new System.Windows.Forms.TabPage();
            this.tabTrim = new System.Windows.Forms.TabPage();
            this.lTotalFlatSheetsValue = new System.Windows.Forms.Label();
            this.lTotalFlatSheets = new System.Windows.Forms.Label();
            this.lTrimPrice = new System.Windows.Forms.Label();
            this.tabLabor = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.mColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColQNTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOverhead = new Estimator.PercentageTextBox();
            this.tbTotalBidPerSquare = new Estimator.CurrencyTextBox();
            this.tbTotalBid = new Estimator.CurrencyTextBox();
            this.tbMiscAddOn2 = new Estimator.CurrencyTextBox();
            this.tbMiscAddOn1 = new Estimator.CurrencyTextBox();
            this.tbSummarySubtotalBidPerSquare = new Estimator.CurrencyTextBox();
            this.tbSummarySubtotalBid = new Estimator.CurrencyTextBox();
            this.tbSummaryOtherPerSquare = new Estimator.CurrencyTextBox();
            this.tbSummaryLaborPerSquare = new Estimator.CurrencyTextBox();
            this.tbSummaryMatPerSquare = new Estimator.CurrencyTextBox();
            this.tbOtherCosts = new Estimator.CurrencyTextBox();
            this.tbMetalRoofLabor = new Estimator.CurrencyTextBox();
            this.tbMetalRoofMaterial = new Estimator.CurrencyTextBox();
            this.plOtherTotalCost = new Estimator.PriceLabel();
            this.plLaborCostPerSquare = new Estimator.PriceLabel();
            this.plLaborTotal = new Estimator.PriceLabel();
            this.plLaborSubtotal = new Estimator.PriceLabel();
            this.tbLaborBurden = new Estimator.PercentageTextBox();
            this.plMatCostPerSquare = new Estimator.PriceLabel();
            this.plMatTotalCost = new Estimator.PriceLabel();
            this.plMatSubtotal = new Estimator.PriceLabel();
            this.tbSalesTax = new Estimator.PercentageTextBox();
            this.tbWaste = new Estimator.PercentageTextBox();
            this.gridViewMats = new Estimator.MaterialGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTrimPrice = new Estimator.CurrencyTextBox();
            this.trimGridView = new Estimator.MaterialGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborGridView = new Estimator.MaterialGridView();
            this.lColLaborItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lColQNTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherGridView = new Estimator.MaterialGridView();
            this.oColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oColQNTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfWindowStrip.SuspendLayout();
            this.gbProjectDetails.SuspendLayout();
            this.gbSquares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoffitPanelSquares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWallPanelSquares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandingSeamSquares)).BeginInit();
            this.gbEstimation.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbOtherOverview.SuspendLayout();
            this.gbLaborOverview.SuspendLayout();
            this.gbMatOverview.SuspendLayout();
            this.tabMats.SuspendLayout();
            this.tabTrim.SuspendLayout();
            this.tabLabor.SuspendLayout();
            this.tabOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mfWindowStrip
            // 
            this.mfWindowStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.mfWindowStrip.Location = new System.Drawing.Point(0, 0);
            this.mfWindowStrip.Name = "mfWindowStrip";
            this.mfWindowStrip.Size = new System.Drawing.Size(727, 24);
            this.mfWindowStrip.TabIndex = 0;
            this.mfWindowStrip.Text = "Menu Strip";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoadEstimate,
            this.miSaveEstimate,
            this.miClose});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miLoadEstimate
            // 
            this.miLoadEstimate.Name = "miLoadEstimate";
            this.miLoadEstimate.Size = new System.Drawing.Size(148, 22);
            this.miLoadEstimate.Text = "Load Estimate";
            // 
            // miSaveEstimate
            // 
            this.miSaveEstimate.Name = "miSaveEstimate";
            this.miSaveEstimate.Size = new System.Drawing.Size(148, 22);
            this.miSaveEstimate.Text = "Save Estimate";
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(148, 22);
            this.miClose.Text = "Close";
            // 
            // gbProjectDetails
            // 
            this.gbProjectDetails.Controls.Add(this.cbJobType);
            this.gbProjectDetails.Controls.Add(this.lJobType);
            this.gbProjectDetails.Controls.Add(this.tbScope);
            this.gbProjectDetails.Controls.Add(this.lScope);
            this.gbProjectDetails.Controls.Add(this.tbSpecial);
            this.gbProjectDetails.Controls.Add(this.lSpecial);
            this.gbProjectDetails.Controls.Add(this.tbDeck);
            this.gbProjectDetails.Controls.Add(this.lDeck);
            this.gbProjectDetails.Controls.Add(this.tbArchitect);
            this.gbProjectDetails.Controls.Add(this.lArchitect);
            this.gbProjectDetails.Controls.Add(this.tbContractor);
            this.gbProjectDetails.Controls.Add(this.lContractor);
            this.gbProjectDetails.Controls.Add(this.bidDatePicker);
            this.gbProjectDetails.Controls.Add(this.lBidDate);
            this.gbProjectDetails.Controls.Add(this.lProjectName);
            this.gbProjectDetails.Controls.Add(this.tbProjectName);
            this.gbProjectDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProjectDetails.Location = new System.Drawing.Point(12, 33);
            this.gbProjectDetails.Name = "gbProjectDetails";
            this.gbProjectDetails.Size = new System.Drawing.Size(703, 207);
            this.gbProjectDetails.TabIndex = 1;
            this.gbProjectDetails.TabStop = false;
            this.gbProjectDetails.Text = "Project Details";
            // 
            // cbJobType
            // 
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Items.AddRange(new object[] {
            "Labor Only",
            "Material Only",
            "Labor and Material"});
            this.cbJobType.Location = new System.Drawing.Point(407, 25);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(121, 21);
            this.cbJobType.TabIndex = 16;
            // 
            // lJobType
            // 
            this.lJobType.AutoSize = true;
            this.lJobType.Location = new System.Drawing.Point(350, 29);
            this.lJobType.Name = "lJobType";
            this.lJobType.Size = new System.Drawing.Size(51, 13);
            this.lJobType.TabIndex = 15;
            this.lJobType.Text = "Job Type";
            // 
            // tbScope
            // 
            this.tbScope.AcceptsReturn = true;
            this.tbScope.Location = new System.Drawing.Point(353, 71);
            this.tbScope.Multiline = true;
            this.tbScope.Name = "tbScope";
            this.tbScope.Size = new System.Drawing.Size(339, 125);
            this.tbScope.TabIndex = 14;
            // 
            // lScope
            // 
            this.lScope.AutoSize = true;
            this.lScope.Location = new System.Drawing.Point(350, 55);
            this.lScope.Name = "lScope";
            this.lScope.Size = new System.Drawing.Size(38, 13);
            this.lScope.TabIndex = 13;
            this.lScope.Text = "Scope";
            // 
            // tbSpecial
            // 
            this.tbSpecial.Location = new System.Drawing.Point(75, 176);
            this.tbSpecial.Name = "tbSpecial";
            this.tbSpecial.Size = new System.Drawing.Size(259, 20);
            this.tbSpecial.TabIndex = 12;
            // 
            // lSpecial
            // 
            this.lSpecial.AutoSize = true;
            this.lSpecial.Location = new System.Drawing.Point(15, 179);
            this.lSpecial.Name = "lSpecial";
            this.lSpecial.Size = new System.Drawing.Size(42, 13);
            this.lSpecial.TabIndex = 11;
            this.lSpecial.Text = "Special";
            // 
            // tbDeck
            // 
            this.tbDeck.Location = new System.Drawing.Point(75, 145);
            this.tbDeck.Name = "tbDeck";
            this.tbDeck.Size = new System.Drawing.Size(259, 20);
            this.tbDeck.TabIndex = 10;
            // 
            // lDeck
            // 
            this.lDeck.AutoSize = true;
            this.lDeck.Location = new System.Drawing.Point(15, 151);
            this.lDeck.Name = "lDeck";
            this.lDeck.Size = new System.Drawing.Size(33, 13);
            this.lDeck.TabIndex = 9;
            this.lDeck.Text = "Deck";
            // 
            // tbArchitect
            // 
            this.tbArchitect.Location = new System.Drawing.Point(75, 115);
            this.tbArchitect.Name = "tbArchitect";
            this.tbArchitect.Size = new System.Drawing.Size(259, 20);
            this.tbArchitect.TabIndex = 8;
            // 
            // lArchitect
            // 
            this.lArchitect.AutoSize = true;
            this.lArchitect.Location = new System.Drawing.Point(15, 120);
            this.lArchitect.Name = "lArchitect";
            this.lArchitect.Size = new System.Drawing.Size(49, 13);
            this.lArchitect.TabIndex = 7;
            this.lArchitect.Text = "Architect";
            // 
            // tbContractor
            // 
            this.tbContractor.Location = new System.Drawing.Point(75, 85);
            this.tbContractor.Name = "tbContractor";
            this.tbContractor.Size = new System.Drawing.Size(259, 20);
            this.tbContractor.TabIndex = 6;
            // 
            // lContractor
            // 
            this.lContractor.AutoSize = true;
            this.lContractor.Location = new System.Drawing.Point(15, 90);
            this.lContractor.Name = "lContractor";
            this.lContractor.Size = new System.Drawing.Size(56, 13);
            this.lContractor.TabIndex = 5;
            this.lContractor.Text = "Contractor";
            // 
            // bidDatePicker
            // 
            this.bidDatePicker.Location = new System.Drawing.Point(75, 55);
            this.bidDatePicker.Name = "bidDatePicker";
            this.bidDatePicker.Size = new System.Drawing.Size(259, 20);
            this.bidDatePicker.TabIndex = 4;
            // 
            // lBidDate
            // 
            this.lBidDate.AutoSize = true;
            this.lBidDate.Location = new System.Drawing.Point(15, 61);
            this.lBidDate.Name = "lBidDate";
            this.lBidDate.Size = new System.Drawing.Size(48, 13);
            this.lBidDate.TabIndex = 3;
            this.lBidDate.Text = "Bid Date";
            // 
            // lProjectName
            // 
            this.lProjectName.AutoSize = true;
            this.lProjectName.Location = new System.Drawing.Point(15, 29);
            this.lProjectName.Name = "lProjectName";
            this.lProjectName.Size = new System.Drawing.Size(40, 13);
            this.lProjectName.TabIndex = 1;
            this.lProjectName.Text = "Project";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(75, 25);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(259, 20);
            this.tbProjectName.TabIndex = 0;
            // 
            // gbSquares
            // 
            this.gbSquares.BackColor = System.Drawing.Color.Transparent;
            this.gbSquares.Controls.Add(this.tbSoffitPanelSquares);
            this.gbSquares.Controls.Add(this.tbWallPanelSquares);
            this.gbSquares.Controls.Add(this.tbStandingSeamSquares);
            this.gbSquares.Controls.Add(this.lSoffitPanelSquares);
            this.gbSquares.Controls.Add(this.lWallPanelSquares);
            this.gbSquares.Controls.Add(this.tbTotalSquares);
            this.gbSquares.Controls.Add(this.lTotalSquares);
            this.gbSquares.Controls.Add(this.lStandingSeam);
            this.gbSquares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSquares.Location = new System.Drawing.Point(3, 3);
            this.gbSquares.Name = "gbSquares";
            this.gbSquares.Size = new System.Drawing.Size(675, 58);
            this.gbSquares.TabIndex = 2;
            this.gbSquares.TabStop = false;
            this.gbSquares.Text = "Squares";
            // 
            // tbSoffitPanelSquares
            // 
            this.tbSoffitPanelSquares.Location = new System.Drawing.Point(585, 23);
            this.tbSoffitPanelSquares.Name = "tbSoffitPanelSquares";
            this.tbSoffitPanelSquares.Size = new System.Drawing.Size(83, 20);
            this.tbSoffitPanelSquares.TabIndex = 26;
            // 
            // tbWallPanelSquares
            // 
            this.tbWallPanelSquares.Location = new System.Drawing.Point(420, 23);
            this.tbWallPanelSquares.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbWallPanelSquares.Name = "tbWallPanelSquares";
            this.tbWallPanelSquares.Size = new System.Drawing.Size(83, 20);
            this.tbWallPanelSquares.TabIndex = 25;
            // 
            // tbStandingSeamSquares
            // 
            this.tbStandingSeamSquares.Location = new System.Drawing.Point(256, 24);
            this.tbStandingSeamSquares.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbStandingSeamSquares.Name = "tbStandingSeamSquares";
            this.tbStandingSeamSquares.Size = new System.Drawing.Size(83, 20);
            this.tbStandingSeamSquares.TabIndex = 24;
            // 
            // lSoffitPanelSquares
            // 
            this.lSoffitPanelSquares.AutoSize = true;
            this.lSoffitPanelSquares.Location = new System.Drawing.Point(520, 27);
            this.lSoffitPanelSquares.Name = "lSoffitPanelSquares";
            this.lSoffitPanelSquares.Size = new System.Drawing.Size(66, 13);
            this.lSoffitPanelSquares.TabIndex = 23;
            this.lSoffitPanelSquares.Text = "Soffit Panels";
            // 
            // lWallPanelSquares
            // 
            this.lWallPanelSquares.AutoSize = true;
            this.lWallPanelSquares.Location = new System.Drawing.Point(358, 27);
            this.lWallPanelSquares.Name = "lWallPanelSquares";
            this.lWallPanelSquares.Size = new System.Drawing.Size(63, 13);
            this.lWallPanelSquares.TabIndex = 21;
            this.lWallPanelSquares.Text = "Wall Panels";
            // 
            // tbTotalSquares
            // 
            this.tbTotalSquares.Location = new System.Drawing.Point(85, 23);
            this.tbTotalSquares.Name = "tbTotalSquares";
            this.tbTotalSquares.ReadOnly = true;
            this.tbTotalSquares.Size = new System.Drawing.Size(75, 20);
            this.tbTotalSquares.TabIndex = 18;
            this.tbTotalSquares.Text = "0";
            // 
            // lTotalSquares
            // 
            this.lTotalSquares.AutoSize = true;
            this.lTotalSquares.Location = new System.Drawing.Point(10, 27);
            this.lTotalSquares.Name = "lTotalSquares";
            this.lTotalSquares.Size = new System.Drawing.Size(73, 13);
            this.lTotalSquares.TabIndex = 19;
            this.lTotalSquares.Text = "Total Squares";
            // 
            // lStandingSeam
            // 
            this.lStandingSeam.AutoSize = true;
            this.lStandingSeam.Location = new System.Drawing.Point(176, 27);
            this.lStandingSeam.Name = "lStandingSeam";
            this.lStandingSeam.Size = new System.Drawing.Size(79, 13);
            this.lStandingSeam.TabIndex = 17;
            this.lStandingSeam.Text = "Standing Seam";
            // 
            // gbEstimation
            // 
            this.gbEstimation.Controls.Add(this.tabControl);
            this.gbEstimation.Location = new System.Drawing.Point(13, 246);
            this.gbEstimation.Name = "gbEstimation";
            this.gbEstimation.Size = new System.Drawing.Size(702, 452);
            this.gbEstimation.TabIndex = 3;
            this.gbEstimation.TabStop = false;
            this.gbEstimation.Text = "Estimation";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOverview);
            this.tabControl.Controls.Add(this.tabMats);
            this.tabControl.Controls.Add(this.tabTrim);
            this.tabControl.Controls.Add(this.tabLabor);
            this.tabControl.Controls.Add(this.tabOther);
            this.tabControl.Location = new System.Drawing.Point(7, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(689, 426);
            this.tabControl.TabIndex = 1;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.gbSummary);
            this.tabOverview.Controls.Add(this.gbOtherOverview);
            this.tabOverview.Controls.Add(this.gbLaborOverview);
            this.tabOverview.Controls.Add(this.gbMatOverview);
            this.tabOverview.Controls.Add(this.gbSquares);
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(681, 400);
            this.tabOverview.TabIndex = 4;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.tbOverhead);
            this.gbSummary.Controls.Add(this.tbTotalBidPerSquare);
            this.gbSummary.Controls.Add(this.tbTotalBid);
            this.gbSummary.Controls.Add(this.lTotalBid);
            this.gbSummary.Controls.Add(this.tbMiscAddOn2);
            this.gbSummary.Controls.Add(this.lMiscAddOn2);
            this.gbSummary.Controls.Add(this.tbMiscAddOn1);
            this.gbSummary.Controls.Add(this.lMiscAddOn1);
            this.gbSummary.Controls.Add(this.lOverhead);
            this.gbSummary.Controls.Add(this.tbSummarySubtotalBidPerSquare);
            this.gbSummary.Controls.Add(this.tbSummarySubtotalBid);
            this.gbSummary.Controls.Add(this.lSummarySubtotalBid);
            this.gbSummary.Controls.Add(this.tbSummaryOtherPerSquare);
            this.gbSummary.Controls.Add(this.tbSummaryLaborPerSquare);
            this.gbSummary.Controls.Add(this.tbSummaryMatPerSquare);
            this.gbSummary.Controls.Add(this.lSummaryPerSquare);
            this.gbSummary.Controls.Add(this.lSummaryTotals);
            this.gbSummary.Controls.Add(this.tbOtherCosts);
            this.gbSummary.Controls.Add(this.lOtherCosts);
            this.gbSummary.Controls.Add(this.tbMetalRoofLabor);
            this.gbSummary.Controls.Add(this.lMetalRoofLabor);
            this.gbSummary.Controls.Add(this.tbMetalRoofMaterial);
            this.gbSummary.Controls.Add(this.lMetalRoofMaterial);
            this.gbSummary.Location = new System.Drawing.Point(349, 68);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(329, 329);
            this.gbSummary.TabIndex = 35;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // lTotalBid
            // 
            this.lTotalBid.AutoSize = true;
            this.lTotalBid.Location = new System.Drawing.Point(27, 277);
            this.lTotalBid.Name = "lTotalBid";
            this.lTotalBid.Size = new System.Drawing.Size(49, 13);
            this.lTotalBid.TabIndex = 45;
            this.lTotalBid.Text = "Total Bid";
            // 
            // lMiscAddOn2
            // 
            this.lMiscAddOn2.AutoSize = true;
            this.lMiscAddOn2.Location = new System.Drawing.Point(28, 234);
            this.lMiscAddOn2.Name = "lMiscAddOn2";
            this.lMiscAddOn2.Size = new System.Drawing.Size(68, 13);
            this.lMiscAddOn2.TabIndex = 43;
            this.lMiscAddOn2.Text = "Misc Add On";
            // 
            // lMiscAddOn1
            // 
            this.lMiscAddOn1.AutoSize = true;
            this.lMiscAddOn1.Location = new System.Drawing.Point(28, 208);
            this.lMiscAddOn1.Name = "lMiscAddOn1";
            this.lMiscAddOn1.Size = new System.Drawing.Size(68, 13);
            this.lMiscAddOn1.TabIndex = 41;
            this.lMiscAddOn1.Text = "Misc Add On";
            // 
            // lOverhead
            // 
            this.lOverhead.AutoSize = true;
            this.lOverhead.Location = new System.Drawing.Point(28, 179);
            this.lOverhead.Name = "lOverhead";
            this.lOverhead.Size = new System.Drawing.Size(54, 13);
            this.lOverhead.TabIndex = 39;
            this.lOverhead.Text = "Overhead";
            this.lOverhead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lSummarySubtotalBid
            // 
            this.lSummarySubtotalBid.AutoSize = true;
            this.lSummarySubtotalBid.Location = new System.Drawing.Point(27, 143);
            this.lSummarySubtotalBid.Name = "lSummarySubtotalBid";
            this.lSummarySubtotalBid.Size = new System.Drawing.Size(64, 13);
            this.lSummarySubtotalBid.TabIndex = 36;
            this.lSummarySubtotalBid.Text = "Subtotal Bid";
            // 
            // lSummaryPerSquare
            // 
            this.lSummaryPerSquare.AutoSize = true;
            this.lSummaryPerSquare.Location = new System.Drawing.Point(231, 22);
            this.lSummaryPerSquare.Name = "lSummaryPerSquare";
            this.lSummaryPerSquare.Size = new System.Drawing.Size(60, 13);
            this.lSummaryPerSquare.TabIndex = 31;
            this.lSummaryPerSquare.Text = "Per Square";
            // 
            // lSummaryTotals
            // 
            this.lSummaryTotals.AutoSize = true;
            this.lSummaryTotals.Location = new System.Drawing.Point(131, 22);
            this.lSummaryTotals.Name = "lSummaryTotals";
            this.lSummaryTotals.Size = new System.Drawing.Size(36, 13);
            this.lSummaryTotals.TabIndex = 30;
            this.lSummaryTotals.Text = "Totals";
            // 
            // lOtherCosts
            // 
            this.lOtherCosts.AutoSize = true;
            this.lOtherCosts.Location = new System.Drawing.Point(27, 102);
            this.lOtherCosts.Name = "lOtherCosts";
            this.lOtherCosts.Size = new System.Drawing.Size(62, 13);
            this.lOtherCosts.TabIndex = 29;
            this.lOtherCosts.Text = "Other Costs";
            // 
            // lMetalRoofLabor
            // 
            this.lMetalRoofLabor.AutoSize = true;
            this.lMetalRoofLabor.Location = new System.Drawing.Point(27, 74);
            this.lMetalRoofLabor.Name = "lMetalRoofLabor";
            this.lMetalRoofLabor.Size = new System.Drawing.Size(34, 13);
            this.lMetalRoofLabor.TabIndex = 27;
            this.lMetalRoofLabor.Text = "Labor";
            // 
            // lMetalRoofMaterial
            // 
            this.lMetalRoofMaterial.AutoSize = true;
            this.lMetalRoofMaterial.Location = new System.Drawing.Point(27, 45);
            this.lMetalRoofMaterial.Name = "lMetalRoofMaterial";
            this.lMetalRoofMaterial.Size = new System.Drawing.Size(44, 13);
            this.lMetalRoofMaterial.TabIndex = 25;
            this.lMetalRoofMaterial.Text = "Material";
            // 
            // gbOtherOverview
            // 
            this.gbOtherOverview.Controls.Add(this.plOtherTotalCost);
            this.gbOtherOverview.Controls.Add(this.lOtherTotalCost);
            this.gbOtherOverview.Location = new System.Drawing.Point(3, 341);
            this.gbOtherOverview.Name = "gbOtherOverview";
            this.gbOtherOverview.Size = new System.Drawing.Size(339, 56);
            this.gbOtherOverview.TabIndex = 34;
            this.gbOtherOverview.TabStop = false;
            this.gbOtherOverview.Text = "Other";
            // 
            // lOtherTotalCost
            // 
            this.lOtherTotalCost.AutoSize = true;
            this.lOtherTotalCost.Location = new System.Drawing.Point(97, 23);
            this.lOtherTotalCost.Name = "lOtherTotalCost";
            this.lOtherTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lOtherTotalCost.TabIndex = 33;
            this.lOtherTotalCost.Text = "Total Cost";
            // 
            // gbLaborOverview
            // 
            this.gbLaborOverview.Controls.Add(this.plLaborCostPerSquare);
            this.gbLaborOverview.Controls.Add(this.plLaborTotal);
            this.gbLaborOverview.Controls.Add(this.plLaborSubtotal);
            this.gbLaborOverview.Controls.Add(this.tbLaborBurden);
            this.gbLaborOverview.Controls.Add(this.lLaborCostPerSquare);
            this.gbLaborOverview.Controls.Add(this.lLaborTotalCost);
            this.gbLaborOverview.Controls.Add(this.lLaborBurden);
            this.gbLaborOverview.Controls.Add(this.lLaborSubtotal);
            this.gbLaborOverview.Location = new System.Drawing.Point(3, 204);
            this.gbLaborOverview.Name = "gbLaborOverview";
            this.gbLaborOverview.Size = new System.Drawing.Size(339, 131);
            this.gbLaborOverview.TabIndex = 33;
            this.gbLaborOverview.TabStop = false;
            this.gbLaborOverview.Text = "Labor";
            // 
            // lLaborCostPerSquare
            // 
            this.lLaborCostPerSquare.AutoSize = true;
            this.lLaborCostPerSquare.Location = new System.Drawing.Point(175, 79);
            this.lLaborCostPerSquare.Name = "lLaborCostPerSquare";
            this.lLaborCostPerSquare.Size = new System.Drawing.Size(49, 13);
            this.lLaborCostPerSquare.TabIndex = 31;
            this.lLaborCostPerSquare.Text = "Cost/Sq.";
            // 
            // lLaborTotalCost
            // 
            this.lLaborTotalCost.AutoSize = true;
            this.lLaborTotalCost.Location = new System.Drawing.Point(175, 42);
            this.lLaborTotalCost.Name = "lLaborTotalCost";
            this.lLaborTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lLaborTotalCost.TabIndex = 29;
            this.lLaborTotalCost.Text = "Total Cost";
            // 
            // lLaborBurden
            // 
            this.lLaborBurden.AutoSize = true;
            this.lLaborBurden.Location = new System.Drawing.Point(23, 78);
            this.lLaborBurden.Name = "lLaborBurden";
            this.lLaborBurden.Size = new System.Drawing.Size(41, 13);
            this.lLaborBurden.TabIndex = 25;
            this.lLaborBurden.Text = "Burden";
            this.lLaborBurden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLaborSubtotal
            // 
            this.lLaborSubtotal.AutoSize = true;
            this.lLaborSubtotal.Location = new System.Drawing.Point(23, 43);
            this.lLaborSubtotal.Name = "lLaborSubtotal";
            this.lLaborSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lLaborSubtotal.TabIndex = 0;
            this.lLaborSubtotal.Text = "Subtotal";
            // 
            // gbMatOverview
            // 
            this.gbMatOverview.Controls.Add(this.plMatCostPerSquare);
            this.gbMatOverview.Controls.Add(this.plMatTotalCost);
            this.gbMatOverview.Controls.Add(this.plMatSubtotal);
            this.gbMatOverview.Controls.Add(this.tbSalesTax);
            this.gbMatOverview.Controls.Add(this.tbWaste);
            this.gbMatOverview.Controls.Add(this.lMatCostPerSquare);
            this.gbMatOverview.Controls.Add(this.lTotalMatCost);
            this.gbMatOverview.Controls.Add(this.lMatTax);
            this.gbMatOverview.Controls.Add(this.lWaste);
            this.gbMatOverview.Controls.Add(this.lMatSubtotal);
            this.gbMatOverview.Location = new System.Drawing.Point(3, 67);
            this.gbMatOverview.Name = "gbMatOverview";
            this.gbMatOverview.Size = new System.Drawing.Size(339, 131);
            this.gbMatOverview.TabIndex = 3;
            this.gbMatOverview.TabStop = false;
            this.gbMatOverview.Text = "Materials";
            // 
            // lMatCostPerSquare
            // 
            this.lMatCostPerSquare.AutoSize = true;
            this.lMatCostPerSquare.Location = new System.Drawing.Point(178, 82);
            this.lMatCostPerSquare.Name = "lMatCostPerSquare";
            this.lMatCostPerSquare.Size = new System.Drawing.Size(49, 13);
            this.lMatCostPerSquare.TabIndex = 31;
            this.lMatCostPerSquare.Text = "Cost/Sq.";
            // 
            // lTotalMatCost
            // 
            this.lTotalMatCost.AutoSize = true;
            this.lTotalMatCost.Location = new System.Drawing.Point(178, 45);
            this.lTotalMatCost.Name = "lTotalMatCost";
            this.lTotalMatCost.Size = new System.Drawing.Size(55, 13);
            this.lTotalMatCost.TabIndex = 29;
            this.lTotalMatCost.Text = "Total Cost";
            // 
            // lMatTax
            // 
            this.lMatTax.AutoSize = true;
            this.lMatTax.Location = new System.Drawing.Point(10, 99);
            this.lMatTax.Name = "lMatTax";
            this.lMatTax.Size = new System.Drawing.Size(54, 13);
            this.lMatTax.TabIndex = 27;
            this.lMatTax.Text = "Sales Tax";
            this.lMatTax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lWaste
            // 
            this.lWaste.AutoSize = true;
            this.lWaste.Location = new System.Drawing.Point(11, 62);
            this.lWaste.Name = "lWaste";
            this.lWaste.Size = new System.Drawing.Size(38, 13);
            this.lWaste.TabIndex = 25;
            this.lWaste.Text = "Waste";
            // 
            // lMatSubtotal
            // 
            this.lMatSubtotal.AutoSize = true;
            this.lMatSubtotal.Location = new System.Drawing.Point(10, 27);
            this.lMatSubtotal.Name = "lMatSubtotal";
            this.lMatSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lMatSubtotal.TabIndex = 0;
            this.lMatSubtotal.Text = "Subtotal";
            // 
            // tabMats
            // 
            this.tabMats.Controls.Add(this.gridViewMats);
            this.tabMats.Location = new System.Drawing.Point(4, 22);
            this.tabMats.Name = "tabMats";
            this.tabMats.Padding = new System.Windows.Forms.Padding(3);
            this.tabMats.Size = new System.Drawing.Size(681, 400);
            this.tabMats.TabIndex = 0;
            this.tabMats.Text = "Materials";
            this.tabMats.UseVisualStyleBackColor = true;
            // 
            // tabTrim
            // 
            this.tabTrim.Controls.Add(this.lTotalFlatSheetsValue);
            this.tabTrim.Controls.Add(this.lTotalFlatSheets);
            this.tabTrim.Controls.Add(this.lTrimPrice);
            this.tabTrim.Controls.Add(this.tbTrimPrice);
            this.tabTrim.Controls.Add(this.trimGridView);
            this.tabTrim.Location = new System.Drawing.Point(4, 22);
            this.tabTrim.Name = "tabTrim";
            this.tabTrim.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrim.Size = new System.Drawing.Size(681, 400);
            this.tabTrim.TabIndex = 1;
            this.tabTrim.Text = "Trim";
            this.tabTrim.UseVisualStyleBackColor = true;
            // 
            // lTotalFlatSheetsValue
            // 
            this.lTotalFlatSheetsValue.AutoSize = true;
            this.lTotalFlatSheetsValue.Location = new System.Drawing.Point(311, 19);
            this.lTotalFlatSheetsValue.Name = "lTotalFlatSheetsValue";
            this.lTotalFlatSheetsValue.Size = new System.Drawing.Size(13, 13);
            this.lTotalFlatSheetsValue.TabIndex = 4;
            this.lTotalFlatSheetsValue.Text = "0";
            // 
            // lTotalFlatSheets
            // 
            this.lTotalFlatSheets.AutoSize = true;
            this.lTotalFlatSheets.Location = new System.Drawing.Point(218, 19);
            this.lTotalFlatSheets.Name = "lTotalFlatSheets";
            this.lTotalFlatSheets.Size = new System.Drawing.Size(90, 13);
            this.lTotalFlatSheets.TabIndex = 3;
            this.lTotalFlatSheets.Text = "Total Flat Sheets:";
            // 
            // lTrimPrice
            // 
            this.lTrimPrice.AutoSize = true;
            this.lTrimPrice.Location = new System.Drawing.Point(6, 19);
            this.lTrimPrice.Name = "lTrimPrice";
            this.lTrimPrice.Size = new System.Drawing.Size(54, 13);
            this.lTrimPrice.TabIndex = 1;
            this.lTrimPrice.Text = "Trim Price";
            // 
            // tabLabor
            // 
            this.tabLabor.Controls.Add(this.laborGridView);
            this.tabLabor.Location = new System.Drawing.Point(4, 22);
            this.tabLabor.Name = "tabLabor";
            this.tabLabor.Size = new System.Drawing.Size(681, 400);
            this.tabLabor.TabIndex = 2;
            this.tabLabor.Text = "Labor";
            this.tabLabor.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.otherGridView);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(681, 400);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // mColMaterial
            // 
            this.mColMaterial.Name = "mColMaterial";
            // 
            // mColDescription
            // 
            this.mColDescription.Name = "mColDescription";
            // 
            // mColQNTY
            // 
            this.mColQNTY.Name = "mColQNTY";
            // 
            // mColUnit
            // 
            this.mColUnit.Name = "mColUnit";
            // 
            // mColUnitPrice
            // 
            this.mColUnitPrice.Name = "mColUnitPrice";
            // 
            // mColTotal
            // 
            this.mColTotal.Name = "mColTotal";
            // 
            // tbOverhead
            // 
            this.tbOverhead.baseText = "0";
            this.tbOverhead.Location = new System.Drawing.Point(112, 176);
            this.tbOverhead.Name = "tbOverhead";
            this.tbOverhead.percentageValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbOverhead.resultText = "0.00 %";
            this.tbOverhead.Size = new System.Drawing.Size(79, 20);
            this.tbOverhead.TabIndex = 47;
            this.tbOverhead.Text = "0.00 %";
            // 
            // tbTotalBidPerSquare
            // 
            this.tbTotalBidPerSquare.baseText = "0";
            this.tbTotalBidPerSquare.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTotalBidPerSquare.Location = new System.Drawing.Point(220, 273);
            this.tbTotalBidPerSquare.Name = "tbTotalBidPerSquare";
            this.tbTotalBidPerSquare.resultText = "$0.00";
            this.tbTotalBidPerSquare.Size = new System.Drawing.Size(79, 20);
            this.tbTotalBidPerSquare.TabIndex = 46;
            this.tbTotalBidPerSquare.Text = "$0.00";
            // 
            // tbTotalBid
            // 
            this.tbTotalBid.baseText = "0";
            this.tbTotalBid.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTotalBid.Location = new System.Drawing.Point(112, 273);
            this.tbTotalBid.Name = "tbTotalBid";
            this.tbTotalBid.resultText = "$0.00";
            this.tbTotalBid.Size = new System.Drawing.Size(79, 20);
            this.tbTotalBid.TabIndex = 44;
            this.tbTotalBid.Text = "$0.00";
            // 
            // tbMiscAddOn2
            // 
            this.tbMiscAddOn2.baseText = "0";
            this.tbMiscAddOn2.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMiscAddOn2.Location = new System.Drawing.Point(112, 229);
            this.tbMiscAddOn2.Name = "tbMiscAddOn2";
            this.tbMiscAddOn2.resultText = "$0.00";
            this.tbMiscAddOn2.Size = new System.Drawing.Size(79, 20);
            this.tbMiscAddOn2.TabIndex = 42;
            this.tbMiscAddOn2.Text = "$0.00";
            // 
            // tbMiscAddOn1
            // 
            this.tbMiscAddOn1.baseText = "0";
            this.tbMiscAddOn1.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMiscAddOn1.Location = new System.Drawing.Point(112, 203);
            this.tbMiscAddOn1.Name = "tbMiscAddOn1";
            this.tbMiscAddOn1.resultText = "$0.00";
            this.tbMiscAddOn1.Size = new System.Drawing.Size(79, 20);
            this.tbMiscAddOn1.TabIndex = 40;
            this.tbMiscAddOn1.Text = "$0.00";
            // 
            // tbSummarySubtotalBidPerSquare
            // 
            this.tbSummarySubtotalBidPerSquare.baseText = "0";
            this.tbSummarySubtotalBidPerSquare.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSummarySubtotalBidPerSquare.Location = new System.Drawing.Point(220, 139);
            this.tbSummarySubtotalBidPerSquare.Name = "tbSummarySubtotalBidPerSquare";
            this.tbSummarySubtotalBidPerSquare.resultText = "$0.00";
            this.tbSummarySubtotalBidPerSquare.Size = new System.Drawing.Size(79, 20);
            this.tbSummarySubtotalBidPerSquare.TabIndex = 37;
            this.tbSummarySubtotalBidPerSquare.Text = "$0.00";
            // 
            // tbSummarySubtotalBid
            // 
            this.tbSummarySubtotalBid.baseText = "0";
            this.tbSummarySubtotalBid.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSummarySubtotalBid.Location = new System.Drawing.Point(112, 139);
            this.tbSummarySubtotalBid.Name = "tbSummarySubtotalBid";
            this.tbSummarySubtotalBid.resultText = "$0.00";
            this.tbSummarySubtotalBid.Size = new System.Drawing.Size(79, 20);
            this.tbSummarySubtotalBid.TabIndex = 35;
            this.tbSummarySubtotalBid.Text = "$0.00";
            // 
            // tbSummaryOtherPerSquare
            // 
            this.tbSummaryOtherPerSquare.baseText = "0";
            this.tbSummaryOtherPerSquare.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSummaryOtherPerSquare.Location = new System.Drawing.Point(220, 98);
            this.tbSummaryOtherPerSquare.Name = "tbSummaryOtherPerSquare";
            this.tbSummaryOtherPerSquare.resultText = "$0.00";
            this.tbSummaryOtherPerSquare.Size = new System.Drawing.Size(79, 20);
            this.tbSummaryOtherPerSquare.TabIndex = 34;
            this.tbSummaryOtherPerSquare.Text = "$0.00";
            // 
            // tbSummaryLaborPerSquare
            // 
            this.tbSummaryLaborPerSquare.baseText = "0";
            this.tbSummaryLaborPerSquare.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSummaryLaborPerSquare.Location = new System.Drawing.Point(220, 70);
            this.tbSummaryLaborPerSquare.Name = "tbSummaryLaborPerSquare";
            this.tbSummaryLaborPerSquare.resultText = "$0.00";
            this.tbSummaryLaborPerSquare.Size = new System.Drawing.Size(79, 20);
            this.tbSummaryLaborPerSquare.TabIndex = 33;
            this.tbSummaryLaborPerSquare.Text = "$0.00";
            // 
            // tbSummaryMatPerSquare
            // 
            this.tbSummaryMatPerSquare.baseText = "0";
            this.tbSummaryMatPerSquare.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSummaryMatPerSquare.Location = new System.Drawing.Point(220, 41);
            this.tbSummaryMatPerSquare.Name = "tbSummaryMatPerSquare";
            this.tbSummaryMatPerSquare.resultText = "$0.00";
            this.tbSummaryMatPerSquare.Size = new System.Drawing.Size(79, 20);
            this.tbSummaryMatPerSquare.TabIndex = 32;
            this.tbSummaryMatPerSquare.Text = "$0.00";
            // 
            // tbOtherCosts
            // 
            this.tbOtherCosts.baseText = "0";
            this.tbOtherCosts.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbOtherCosts.Location = new System.Drawing.Point(112, 98);
            this.tbOtherCosts.Name = "tbOtherCosts";
            this.tbOtherCosts.resultText = "$0.00";
            this.tbOtherCosts.Size = new System.Drawing.Size(79, 20);
            this.tbOtherCosts.TabIndex = 28;
            this.tbOtherCosts.Text = "$0.00";
            // 
            // tbMetalRoofLabor
            // 
            this.tbMetalRoofLabor.baseText = "0";
            this.tbMetalRoofLabor.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMetalRoofLabor.Location = new System.Drawing.Point(112, 70);
            this.tbMetalRoofLabor.Name = "tbMetalRoofLabor";
            this.tbMetalRoofLabor.resultText = "$0.00";
            this.tbMetalRoofLabor.Size = new System.Drawing.Size(79, 20);
            this.tbMetalRoofLabor.TabIndex = 26;
            this.tbMetalRoofLabor.Text = "$0.00";
            // 
            // tbMetalRoofMaterial
            // 
            this.tbMetalRoofMaterial.baseText = "0";
            this.tbMetalRoofMaterial.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMetalRoofMaterial.Location = new System.Drawing.Point(112, 41);
            this.tbMetalRoofMaterial.Name = "tbMetalRoofMaterial";
            this.tbMetalRoofMaterial.resultText = "$0.00";
            this.tbMetalRoofMaterial.Size = new System.Drawing.Size(79, 20);
            this.tbMetalRoofMaterial.TabIndex = 24;
            this.tbMetalRoofMaterial.Text = "$0.00";
            // 
            // plOtherTotalCost
            // 
            this.plOtherTotalCost.baseText = null;
            this.plOtherTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plOtherTotalCost.Location = new System.Drawing.Point(158, 19);
            this.plOtherTotalCost.Name = "plOtherTotalCost";
            this.plOtherTotalCost.resultText = null;
            this.plOtherTotalCost.Size = new System.Drawing.Size(75, 20);
            this.plOtherTotalCost.TabIndex = 42;
            this.plOtherTotalCost.Text = "$0.00";
            this.plOtherTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plOtherTotalCost.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // plLaborCostPerSquare
            // 
            this.plLaborCostPerSquare.baseText = null;
            this.plLaborCostPerSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plLaborCostPerSquare.Location = new System.Drawing.Point(233, 75);
            this.plLaborCostPerSquare.Name = "plLaborCostPerSquare";
            this.plLaborCostPerSquare.resultText = null;
            this.plLaborCostPerSquare.Size = new System.Drawing.Size(75, 20);
            this.plLaborCostPerSquare.TabIndex = 41;
            this.plLaborCostPerSquare.Text = "$0.00";
            this.plLaborCostPerSquare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plLaborCostPerSquare.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // plLaborTotal
            // 
            this.plLaborTotal.baseText = null;
            this.plLaborTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plLaborTotal.Location = new System.Drawing.Point(233, 39);
            this.plLaborTotal.Name = "plLaborTotal";
            this.plLaborTotal.resultText = null;
            this.plLaborTotal.Size = new System.Drawing.Size(75, 20);
            this.plLaborTotal.TabIndex = 40;
            this.plLaborTotal.Text = "$0.00";
            this.plLaborTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plLaborTotal.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // plLaborSubtotal
            // 
            this.plLaborSubtotal.baseText = null;
            this.plLaborSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plLaborSubtotal.Location = new System.Drawing.Point(78, 39);
            this.plLaborSubtotal.Name = "plLaborSubtotal";
            this.plLaborSubtotal.resultText = null;
            this.plLaborSubtotal.Size = new System.Drawing.Size(75, 20);
            this.plLaborSubtotal.TabIndex = 39;
            this.plLaborSubtotal.Text = "$0.00";
            this.plLaborSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plLaborSubtotal.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tbLaborBurden
            // 
            this.tbLaborBurden.baseText = "0";
            this.tbLaborBurden.Location = new System.Drawing.Point(78, 75);
            this.tbLaborBurden.Name = "tbLaborBurden";
            this.tbLaborBurden.percentageValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbLaborBurden.resultText = "0.00 %";
            this.tbLaborBurden.Size = new System.Drawing.Size(75, 20);
            this.tbLaborBurden.TabIndex = 35;
            this.tbLaborBurden.Text = "0.00 %";
            // 
            // plMatCostPerSquare
            // 
            this.plMatCostPerSquare.baseText = null;
            this.plMatCostPerSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMatCostPerSquare.Location = new System.Drawing.Point(233, 78);
            this.plMatCostPerSquare.Name = "plMatCostPerSquare";
            this.plMatCostPerSquare.resultText = null;
            this.plMatCostPerSquare.Size = new System.Drawing.Size(75, 20);
            this.plMatCostPerSquare.TabIndex = 38;
            this.plMatCostPerSquare.Text = "$0.00";
            this.plMatCostPerSquare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plMatCostPerSquare.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // plMatTotalCost
            // 
            this.plMatTotalCost.baseText = null;
            this.plMatTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMatTotalCost.Location = new System.Drawing.Point(233, 42);
            this.plMatTotalCost.Name = "plMatTotalCost";
            this.plMatTotalCost.resultText = null;
            this.plMatTotalCost.Size = new System.Drawing.Size(75, 20);
            this.plMatTotalCost.TabIndex = 37;
            this.plMatTotalCost.Text = "$0.00";
            this.plMatTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plMatTotalCost.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // plMatSubtotal
            // 
            this.plMatSubtotal.baseText = null;
            this.plMatSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMatSubtotal.Location = new System.Drawing.Point(68, 23);
            this.plMatSubtotal.Name = "plMatSubtotal";
            this.plMatSubtotal.resultText = null;
            this.plMatSubtotal.Size = new System.Drawing.Size(75, 20);
            this.plMatSubtotal.TabIndex = 36;
            this.plMatSubtotal.Text = "$0.00";
            this.plMatSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plMatSubtotal.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tbSalesTax
            // 
            this.tbSalesTax.baseText = "0";
            this.tbSalesTax.Location = new System.Drawing.Point(68, 95);
            this.tbSalesTax.Name = "tbSalesTax";
            this.tbSalesTax.percentageValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSalesTax.resultText = "0.00 %";
            this.tbSalesTax.Size = new System.Drawing.Size(75, 20);
            this.tbSalesTax.TabIndex = 35;
            this.tbSalesTax.Text = "0.00 %";
            // 
            // tbWaste
            // 
            this.tbWaste.baseText = "0";
            this.tbWaste.Location = new System.Drawing.Point(68, 59);
            this.tbWaste.Name = "tbWaste";
            this.tbWaste.percentageValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbWaste.resultText = "0.00 %";
            this.tbWaste.Size = new System.Drawing.Size(75, 20);
            this.tbWaste.TabIndex = 34;
            this.tbWaste.Text = "0.00 %";
            // 
            // gridViewMats
            // 
            this.gridViewMats.AllowUserToAddRows = false;
            this.gridViewMats.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.gridViewMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridViewMats.Location = new System.Drawing.Point(3, 3);
            this.gridViewMats.Name = "gridViewMats";
            this.gridViewMats.RowHeadersVisible = false;
            this.gridViewMats.Size = new System.Drawing.Size(675, 394);
            this.gridViewMats.soffitPanelSquares = 0;
            this.gridViewMats.standingSeamSquares = 0;
            this.gridViewMats.TabIndex = 0;
            this.gridViewMats.totalSquares = 0;
            this.gridViewMats.wallPanelSquares = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Material";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 6.857334F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 165;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 9.257402F;
            this.dataGridViewTextBoxColumn3.HeaderText = "QNTY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 55;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 2.857223F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 2.857223F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 2.857223F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tbTrimPrice
            // 
            this.tbTrimPrice.baseText = "0";
            this.tbTrimPrice.currencyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTrimPrice.Location = new System.Drawing.Point(63, 16);
            this.tbTrimPrice.Name = "tbTrimPrice";
            this.tbTrimPrice.resultText = "$0.00";
            this.tbTrimPrice.Size = new System.Drawing.Size(100, 20);
            this.tbTrimPrice.TabIndex = 2;
            this.tbTrimPrice.Text = "$0.00";
            // 
            // trimGridView
            // 
            this.trimGridView.AllowUserToAddRows = false;
            this.trimGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.trimGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.trimGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trimGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trimGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trimGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.trimGridView.Location = new System.Drawing.Point(3, 50);
            this.trimGridView.Name = "trimGridView";
            this.trimGridView.RowHeadersVisible = false;
            this.trimGridView.Size = new System.Drawing.Size(675, 347);
            this.trimGridView.soffitPanelSquares = 0;
            this.trimGridView.standingSeamSquares = 0;
            this.trimGridView.TabIndex = 0;
            this.trimGridView.totalSquares = 0;
            this.trimGridView.wallPanelSquares = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.FillWeight = 417.7215F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Material";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 165;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.FillWeight = 131.6456F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 165;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 12.65823F;
            this.dataGridViewTextBoxColumn9.HeaderText = "QNTY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 12.65823F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 12.65823F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 12.65823F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // laborGridView
            // 
            this.laborGridView.AllowUserToAddRows = false;
            this.laborGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.laborGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.laborGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laborGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.laborGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laborGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lColLaborItem,
            this.lColDescription,
            this.lColQNTY,
            this.lColUnit,
            this.lColUnitPrice,
            this.lColTotal});
            this.laborGridView.Location = new System.Drawing.Point(4, 4);
            this.laborGridView.Name = "laborGridView";
            this.laborGridView.RowHeadersVisible = false;
            this.laborGridView.Size = new System.Drawing.Size(674, 393);
            this.laborGridView.soffitPanelSquares = 0;
            this.laborGridView.standingSeamSquares = 0;
            this.laborGridView.TabIndex = 0;
            this.laborGridView.totalSquares = 0;
            this.laborGridView.wallPanelSquares = 0;
            // 
            // lColLaborItem
            // 
            this.lColLaborItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lColLaborItem.HeaderText = "Labor Item";
            this.lColLaborItem.Name = "lColLaborItem";
            this.lColLaborItem.Width = 145;
            // 
            // lColDescription
            // 
            this.lColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lColDescription.HeaderText = "Description";
            this.lColDescription.Name = "lColDescription";
            this.lColDescription.Width = 145;
            // 
            // lColQNTY
            // 
            this.lColQNTY.HeaderText = "QNTY";
            this.lColQNTY.Name = "lColQNTY";
            // 
            // lColUnit
            // 
            this.lColUnit.HeaderText = "Unit";
            this.lColUnit.Name = "lColUnit";
            // 
            // lColUnitPrice
            // 
            this.lColUnitPrice.HeaderText = "Unit Price";
            this.lColUnitPrice.Name = "lColUnitPrice";
            // 
            // lColTotal
            // 
            this.lColTotal.HeaderText = "Total";
            this.lColTotal.Name = "lColTotal";
            // 
            // otherGridView
            // 
            this.otherGridView.AllowUserToAddRows = false;
            this.otherGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.otherGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.otherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otherGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otherGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oColItem,
            this.oColDescription,
            this.oColQNTY,
            this.oColUnit,
            this.oColUnitPrice,
            this.oColTotal});
            this.otherGridView.Location = new System.Drawing.Point(4, 4);
            this.otherGridView.Name = "otherGridView";
            this.otherGridView.RowHeadersVisible = false;
            this.otherGridView.Size = new System.Drawing.Size(674, 393);
            this.otherGridView.soffitPanelSquares = 0;
            this.otherGridView.standingSeamSquares = 0;
            this.otherGridView.TabIndex = 0;
            this.otherGridView.totalSquares = 0;
            this.otherGridView.wallPanelSquares = 0;
            // 
            // oColItem
            // 
            this.oColItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oColItem.HeaderText = "Item";
            this.oColItem.Name = "oColItem";
            this.oColItem.Width = 145;
            // 
            // oColDescription
            // 
            this.oColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oColDescription.HeaderText = "Description";
            this.oColDescription.Name = "oColDescription";
            this.oColDescription.Width = 145;
            // 
            // oColQNTY
            // 
            this.oColQNTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oColQNTY.HeaderText = "QNTY";
            this.oColQNTY.Name = "oColQNTY";
            this.oColQNTY.Width = 55;
            // 
            // oColUnit
            // 
            this.oColUnit.HeaderText = "Unit";
            this.oColUnit.Name = "oColUnit";
            // 
            // oColUnitPrice
            // 
            this.oColUnitPrice.HeaderText = "Unit Price";
            this.oColUnitPrice.Name = "oColUnitPrice";
            // 
            // oColTotal
            // 
            this.oColTotal.HeaderText = "Total";
            this.oColTotal.Name = "oColTotal";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 710);
            this.Controls.Add(this.gbEstimation);
            this.Controls.Add(this.gbProjectDetails);
            this.Controls.Add(this.mfWindowStrip);
            this.MainMenuStrip = this.mfWindowStrip;
            this.Name = "MainForm";
            this.mfWindowStrip.ResumeLayout(false);
            this.mfWindowStrip.PerformLayout();
            this.gbProjectDetails.ResumeLayout(false);
            this.gbProjectDetails.PerformLayout();
            this.gbSquares.ResumeLayout(false);
            this.gbSquares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoffitPanelSquares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWallPanelSquares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandingSeamSquares)).EndInit();
            this.gbEstimation.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbOtherOverview.ResumeLayout(false);
            this.gbOtherOverview.PerformLayout();
            this.gbLaborOverview.ResumeLayout(false);
            this.gbLaborOverview.PerformLayout();
            this.gbMatOverview.ResumeLayout(false);
            this.gbMatOverview.PerformLayout();
            this.tabMats.ResumeLayout(false);
            this.tabTrim.ResumeLayout(false);
            this.tabTrim.PerformLayout();
            this.tabLabor.ResumeLayout(false);
            this.tabOther.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion

        private System.Windows.Forms.MenuStrip mfWindowStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miLoadEstimate;
        private System.Windows.Forms.ToolStripMenuItem miSaveEstimate;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.GroupBox gbProjectDetails;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label lProjectName;
        private System.Windows.Forms.Label lBidDate;
        private System.Windows.Forms.DateTimePicker bidDatePicker;
        private System.Windows.Forms.Label lContractor;
        private System.Windows.Forms.TextBox tbContractor;
        private System.Windows.Forms.Label lArchitect;
        private System.Windows.Forms.Label lDeck;
        private System.Windows.Forms.TextBox tbArchitect;
        private System.Windows.Forms.TextBox tbDeck;
        private System.Windows.Forms.TextBox tbSpecial;
        private System.Windows.Forms.Label lSpecial;
        private System.Windows.Forms.Label lScope;
        private System.Windows.Forms.TextBox tbScope;
        private System.Windows.Forms.Label lJobType;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.GroupBox gbSquares;
        private System.Windows.Forms.Label lStandingSeam;
        private System.Windows.Forms.Label lWallPanelSquares;
        private System.Windows.Forms.Label lTotalSquares;
        private System.Windows.Forms.Label lSoffitPanelSquares;
        private System.Windows.Forms.GroupBox gbEstimation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMats;
        private System.Windows.Forms.TabPage tabTrim;
        private System.Windows.Forms.TabPage tabLabor;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.GroupBox gbMatOverview;
        private System.Windows.Forms.Label lWaste;
        private System.Windows.Forms.Label lMatSubtotal;
        private System.Windows.Forms.Label lMatTax;
        private System.Windows.Forms.Label lMatCostPerSquare;
        private System.Windows.Forms.Label lTotalMatCost;
        private System.Windows.Forms.GroupBox gbLaborOverview;
        private System.Windows.Forms.Label lLaborCostPerSquare;
        private System.Windows.Forms.Label lLaborTotalCost;
        private System.Windows.Forms.Label lLaborBurden;
        private System.Windows.Forms.Label lLaborSubtotal;
        private System.Windows.Forms.GroupBox gbOtherOverview;
        private System.Windows.Forms.Label lOtherTotalCost;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lMetalRoofLabor;
        private System.Windows.Forms.Label lMetalRoofMaterial;
        private System.Windows.Forms.Label lSummaryPerSquare;
        private System.Windows.Forms.Label lSummaryTotals;
        private System.Windows.Forms.Label lOtherCosts;
        private System.Windows.Forms.Label lMiscAddOn2;
        private System.Windows.Forms.Label lMiscAddOn1;
        private System.Windows.Forms.Label lOverhead;
        private System.Windows.Forms.Label lSummarySubtotalBid;
        private System.Windows.Forms.Label lTotalBid;
        private CurrencyTextBox tbMetalRoofLabor;
        private CurrencyTextBox tbMetalRoofMaterial;
        private CurrencyTextBox tbSummaryOtherPerSquare;
        private CurrencyTextBox tbSummaryLaborPerSquare;
        private CurrencyTextBox tbSummaryMatPerSquare;
        private CurrencyTextBox tbOtherCosts;
        private CurrencyTextBox tbMiscAddOn2;
        private CurrencyTextBox tbMiscAddOn1;
        private CurrencyTextBox tbSummarySubtotalBidPerSquare;
        private CurrencyTextBox tbSummarySubtotalBid;
        private CurrencyTextBox tbTotalBidPerSquare;
        private CurrencyTextBox tbTotalBid;
        private PercentageTextBox tbOverhead;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColQNTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColTotal;
        private System.Windows.Forms.Label lTrimPrice;
        private System.Windows.Forms.Label lTotalFlatSheets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        public System.Windows.Forms.TextBox tbTotalSquares;
        public System.Windows.Forms.NumericUpDown tbStandingSeamSquares;
        public System.Windows.Forms.NumericUpDown tbWallPanelSquares;
        public System.Windows.Forms.NumericUpDown tbSoffitPanelSquares;
        public PercentageTextBox tbWaste;
        public PercentageTextBox tbSalesTax;
        public PriceLabel plMatSubtotal;
        public PriceLabel plMatTotalCost;
        public PriceLabel plMatCostPerSquare;
        public MaterialGridView gridViewMats;
        public MaterialGridView trimGridView;
        public CurrencyTextBox tbTrimPrice;
        public System.Windows.Forms.Label lTotalFlatSheetsValue;
        public MaterialGridView laborGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColLaborItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColQNTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn lColTotal;
        public PercentageTextBox tbLaborBurden;
        public PriceLabel plLaborSubtotal;
        public PriceLabel plLaborCostPerSquare;
        public PriceLabel plLaborTotal;
        public PriceLabel plOtherTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColQNTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn oColTotal;
        public MaterialGridView otherGridView;
    }
}

