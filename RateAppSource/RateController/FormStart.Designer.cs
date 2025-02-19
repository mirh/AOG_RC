﻿
namespace RateController
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lbArduinoConnected = new System.Windows.Forms.Label();
            this.lbAogConnected = new System.Windows.Forms.Label();
            this.panProducts = new System.Windows.Forms.Panel();
            this.lbTarget = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.SetRate = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.TankRemain = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.AreaDone = new System.Windows.Forms.Label();
            this.lbRateAmount = new System.Windows.Forms.Label();
            this.lbCoverage = new System.Windows.Forms.Label();
            this.lbRemaining = new System.Windows.Forms.Label();
            this.panSummary = new System.Windows.Forms.Panel();
            this.idc5 = new System.Windows.Forms.Label();
            this.rt5 = new System.Windows.Forms.Label();
            this.prd5 = new System.Windows.Forms.Label();
            this.idc0 = new System.Windows.Forms.Label();
            this.prd4 = new System.Windows.Forms.Label();
            this.rt4 = new System.Windows.Forms.Label();
            this.idc4 = new System.Windows.Forms.Label();
            this.prd3 = new System.Windows.Forms.Label();
            this.rt3 = new System.Windows.Forms.Label();
            this.idc3 = new System.Windows.Forms.Label();
            this.prd2 = new System.Windows.Forms.Label();
            this.rt2 = new System.Windows.Forms.Label();
            this.idc2 = new System.Windows.Forms.Label();
            this.prd1 = new System.Windows.Forms.Label();
            this.rt1 = new System.Windows.Forms.Label();
            this.idc1 = new System.Windows.Forms.Label();
            this.prd0 = new System.Windows.Forms.Label();
            this.rt0 = new System.Windows.Forms.Label();
            this.timerNano = new System.Windows.Forms.Timer(this.components);
            this.mnuSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSections = new System.Windows.Forms.ToolStripMenuItem();
            this.switchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuComm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRelays = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPressures = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.largeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMetric = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeustch = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNederlands = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbPressureValue = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.panFan = new System.Windows.Forms.Panel();
            this.btnFan = new System.Windows.Forms.Button();
            this.lbOn = new System.Windows.Forms.Label();
            this.lbOff = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTargetRPM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFanRate = new System.Windows.Forms.Label();
            this.lbCurrentRPM = new System.Windows.Forms.Label();
            this.lbFan = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btAlarm = new System.Windows.Forms.Button();
            this.timerPIDs = new System.Windows.Forms.Timer(this.components);
            this.panProducts.SuspendLayout();
            this.panSummary.SuspendLayout();
            this.mnuSettings.SuspendLayout();
            this.panFan.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lbArduinoConnected
            // 
            this.lbArduinoConnected.BackColor = System.Drawing.Color.Red;
            this.lbArduinoConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbArduinoConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArduinoConnected.Location = new System.Drawing.Point(416, 294);
            this.lbArduinoConnected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbArduinoConnected.Name = "lbArduinoConnected";
            this.lbArduinoConnected.Size = new System.Drawing.Size(124, 50);
            this.lbArduinoConnected.TabIndex = 144;
            this.lbArduinoConnected.Text = "Mod";
            this.lbArduinoConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbArduinoConnected.Click += new System.EventHandler(this.lbArduinoConnected_Click);
            this.lbArduinoConnected.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbArduinoConnected_HelpRequested);
            // 
            // lbAogConnected
            // 
            this.lbAogConnected.BackColor = System.Drawing.Color.Red;
            this.lbAogConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAogConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAogConnected.Location = new System.Drawing.Point(416, 362);
            this.lbAogConnected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAogConnected.Name = "lbAogConnected";
            this.lbAogConnected.Size = new System.Drawing.Size(124, 50);
            this.lbAogConnected.TabIndex = 145;
            this.lbAogConnected.Text = "AOG";
            this.lbAogConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAogConnected.Click += new System.EventHandler(this.lbAogConnected_Click);
            this.lbAogConnected.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbAogConnected_HelpRequested);
            // 
            // panProducts
            // 
            this.panProducts.Controls.Add(this.lbTarget);
            this.panProducts.Controls.Add(this.groupBox3);
            this.panProducts.Controls.Add(this.lbProduct);
            this.panProducts.Controls.Add(this.SetRate);
            this.panProducts.Controls.Add(this.lbRate);
            this.panProducts.Controls.Add(this.TankRemain);
            this.panProducts.Controls.Add(this.lblUnits);
            this.panProducts.Controls.Add(this.AreaDone);
            this.panProducts.Controls.Add(this.lbRateAmount);
            this.panProducts.Controls.Add(this.lbCoverage);
            this.panProducts.Controls.Add(this.lbRemaining);
            this.panProducts.Location = new System.Drawing.Point(0, 0);
            this.panProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panProducts.Name = "panProducts";
            this.panProducts.Size = new System.Drawing.Size(542, 288);
            this.panProducts.TabIndex = 50;
            // 
            // lbTarget
            // 
            this.lbTarget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTarget.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarget.Location = new System.Drawing.Point(0, 115);
            this.lbTarget.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(402, 44);
            this.lbTarget.TabIndex = 159;
            this.lbTarget.Text = "Target Rate";
            this.lbTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTarget.Click += new System.EventHandler(this.lbTarget_Click);
            this.lbTarget.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbTarget_HelpRequested);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(18, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(504, 2);
            this.groupBox3.TabIndex = 158;
            this.groupBox3.TabStop = false;
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // lbProduct
            // 
            this.lbProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(6, 0);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(256, 44);
            this.lbProduct.TabIndex = 157;
            this.lbProduct.Text = "Herbicide";
            // 
            // SetRate
            // 
            this.SetRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetRate.Location = new System.Drawing.Point(376, 115);
            this.SetRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SetRate.Name = "SetRate";
            this.SetRate.Size = new System.Drawing.Size(178, 44);
            this.SetRate.TabIndex = 156;
            this.SetRate.Text = "1,800.50";
            this.SetRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRate
            // 
            this.lbRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.Location = new System.Drawing.Point(0, 58);
            this.lbRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(350, 44);
            this.lbRate.TabIndex = 155;
            this.lbRate.Text = "Current Rate";
            this.lbRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRate.Click += new System.EventHandler(this.lbRate_Click);
            this.lbRate.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbRate_HelpRequested);
            // 
            // TankRemain
            // 
            this.TankRemain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankRemain.Location = new System.Drawing.Point(376, 231);
            this.TankRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TankRemain.Name = "TankRemain";
            this.TankRemain.Size = new System.Drawing.Size(178, 44);
            this.TankRemain.TabIndex = 153;
            this.TankRemain.Text = "50000.1";
            this.TankRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TankRemain.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbRemaining_HelpRequested);
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(290, 0);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(264, 44);
            this.lblUnits.TabIndex = 152;
            this.lblUnits.Text = "Imp Gal/Min";
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AreaDone
            // 
            this.AreaDone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaDone.Location = new System.Drawing.Point(376, 173);
            this.AreaDone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AreaDone.Name = "AreaDone";
            this.AreaDone.Size = new System.Drawing.Size(178, 44);
            this.AreaDone.TabIndex = 147;
            this.AreaDone.Text = "0";
            this.AreaDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AreaDone.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbCoverage_HelpRequested);
            // 
            // lbRateAmount
            // 
            this.lbRateAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateAmount.Location = new System.Drawing.Point(376, 62);
            this.lbRateAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRateAmount.Name = "lbRateAmount";
            this.lbRateAmount.Size = new System.Drawing.Size(178, 44);
            this.lbRateAmount.TabIndex = 146;
            this.lbRateAmount.Text = "1,800.50";
            this.lbRateAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbRateAmount.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbRate_HelpRequested);
            // 
            // lbCoverage
            // 
            this.lbCoverage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoverage.Location = new System.Drawing.Point(0, 173);
            this.lbCoverage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCoverage.Name = "lbCoverage";
            this.lbCoverage.Size = new System.Drawing.Size(350, 44);
            this.lbCoverage.TabIndex = 150;
            this.lbCoverage.Text = "Coverage";
            this.lbCoverage.Click += new System.EventHandler(this.lbCoverage_Click);
            this.lbCoverage.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbCoverage_HelpRequested);
            // 
            // lbRemaining
            // 
            this.lbRemaining.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemaining.Location = new System.Drawing.Point(0, 231);
            this.lbRemaining.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRemaining.Name = "lbRemaining";
            this.lbRemaining.Size = new System.Drawing.Size(402, 44);
            this.lbRemaining.TabIndex = 149;
            this.lbRemaining.Text = "Quantity Applied ...";
            this.lbRemaining.Click += new System.EventHandler(this.label34_Click);
            this.lbRemaining.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lbRemaining_HelpRequested);
            // 
            // panSummary
            // 
            this.panSummary.Controls.Add(this.idc5);
            this.panSummary.Controls.Add(this.rt5);
            this.panSummary.Controls.Add(this.prd5);
            this.panSummary.Controls.Add(this.idc0);
            this.panSummary.Controls.Add(this.prd4);
            this.panSummary.Controls.Add(this.rt4);
            this.panSummary.Controls.Add(this.idc4);
            this.panSummary.Controls.Add(this.prd3);
            this.panSummary.Controls.Add(this.rt3);
            this.panSummary.Controls.Add(this.idc3);
            this.panSummary.Controls.Add(this.prd2);
            this.panSummary.Controls.Add(this.rt2);
            this.panSummary.Controls.Add(this.idc2);
            this.panSummary.Controls.Add(this.prd1);
            this.panSummary.Controls.Add(this.rt1);
            this.panSummary.Controls.Add(this.idc1);
            this.panSummary.Controls.Add(this.prd0);
            this.panSummary.Controls.Add(this.rt0);
            this.panSummary.Location = new System.Drawing.Point(1274, 50);
            this.panSummary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panSummary.Name = "panSummary";
            this.panSummary.Size = new System.Drawing.Size(540, 385);
            this.panSummary.TabIndex = 100;
            // 
            // idc5
            // 
            this.idc5.BackColor = System.Drawing.SystemColors.Control;
            this.idc5.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc5.Image = ((System.Drawing.Image)(resources.GetObject("idc5.Image")));
            this.idc5.Location = new System.Drawing.Point(480, 279);
            this.idc5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc5.Name = "idc5";
            this.idc5.Size = new System.Drawing.Size(60, 44);
            this.idc5.TabIndex = 125;
            this.idc5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rt5
            // 
            this.rt5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt5.Location = new System.Drawing.Point(296, 279);
            this.rt5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt5.Name = "rt5";
            this.rt5.Size = new System.Drawing.Size(180, 44);
            this.rt5.TabIndex = 124;
            this.rt5.Text = "0";
            this.rt5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prd5
            // 
            this.prd5.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd5.Location = new System.Drawing.Point(6, 279);
            this.prd5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd5.Name = "prd5";
            this.prd5.Size = new System.Drawing.Size(286, 44);
            this.prd5.TabIndex = 123;
            this.prd5.Text = "6";
            // 
            // idc0
            // 
            this.idc0.BackColor = System.Drawing.SystemColors.Control;
            this.idc0.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc0.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc0.Image = global::RateController.Properties.Resources.OffSmall;
            this.idc0.Location = new System.Drawing.Point(480, 0);
            this.idc0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc0.Name = "idc0";
            this.idc0.Size = new System.Drawing.Size(60, 44);
            this.idc0.TabIndex = 122;
            this.idc0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prd4
            // 
            this.prd4.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd4.Location = new System.Drawing.Point(6, 223);
            this.prd4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd4.Name = "prd4";
            this.prd4.Size = new System.Drawing.Size(286, 44);
            this.prd4.TabIndex = 121;
            this.prd4.Text = "5";
            // 
            // rt4
            // 
            this.rt4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt4.Location = new System.Drawing.Point(296, 223);
            this.rt4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt4.Name = "rt4";
            this.rt4.Size = new System.Drawing.Size(180, 44);
            this.rt4.TabIndex = 120;
            this.rt4.Text = "0";
            this.rt4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idc4
            // 
            this.idc4.BackColor = System.Drawing.SystemColors.Control;
            this.idc4.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc4.Image = ((System.Drawing.Image)(resources.GetObject("idc4.Image")));
            this.idc4.Location = new System.Drawing.Point(480, 223);
            this.idc4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc4.Name = "idc4";
            this.idc4.Size = new System.Drawing.Size(60, 44);
            this.idc4.TabIndex = 119;
            this.idc4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prd3
            // 
            this.prd3.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd3.Location = new System.Drawing.Point(6, 167);
            this.prd3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd3.Name = "prd3";
            this.prd3.Size = new System.Drawing.Size(286, 44);
            this.prd3.TabIndex = 118;
            this.prd3.Text = "4";
            // 
            // rt3
            // 
            this.rt3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt3.Location = new System.Drawing.Point(296, 167);
            this.rt3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt3.Name = "rt3";
            this.rt3.Size = new System.Drawing.Size(180, 44);
            this.rt3.TabIndex = 117;
            this.rt3.Text = "0";
            this.rt3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idc3
            // 
            this.idc3.BackColor = System.Drawing.SystemColors.Control;
            this.idc3.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc3.Image = ((System.Drawing.Image)(resources.GetObject("idc3.Image")));
            this.idc3.Location = new System.Drawing.Point(480, 167);
            this.idc3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc3.Name = "idc3";
            this.idc3.Size = new System.Drawing.Size(60, 44);
            this.idc3.TabIndex = 116;
            this.idc3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prd2
            // 
            this.prd2.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd2.Location = new System.Drawing.Point(6, 112);
            this.prd2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd2.Name = "prd2";
            this.prd2.Size = new System.Drawing.Size(286, 44);
            this.prd2.TabIndex = 115;
            this.prd2.Text = "3";
            // 
            // rt2
            // 
            this.rt2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt2.Location = new System.Drawing.Point(296, 112);
            this.rt2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt2.Name = "rt2";
            this.rt2.Size = new System.Drawing.Size(180, 44);
            this.rt2.TabIndex = 114;
            this.rt2.Text = "0";
            this.rt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idc2
            // 
            this.idc2.BackColor = System.Drawing.SystemColors.Control;
            this.idc2.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc2.Image = ((System.Drawing.Image)(resources.GetObject("idc2.Image")));
            this.idc2.Location = new System.Drawing.Point(480, 112);
            this.idc2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc2.Name = "idc2";
            this.idc2.Size = new System.Drawing.Size(60, 44);
            this.idc2.TabIndex = 113;
            this.idc2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prd1
            // 
            this.prd1.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd1.Location = new System.Drawing.Point(6, 56);
            this.prd1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd1.Name = "prd1";
            this.prd1.Size = new System.Drawing.Size(286, 44);
            this.prd1.TabIndex = 112;
            this.prd1.Text = "2";
            // 
            // rt1
            // 
            this.rt1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt1.Location = new System.Drawing.Point(296, 56);
            this.rt1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(180, 44);
            this.rt1.TabIndex = 111;
            this.rt1.Text = "0";
            this.rt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idc1
            // 
            this.idc1.BackColor = System.Drawing.SystemColors.Control;
            this.idc1.Cursor = System.Windows.Forms.Cursors.Default;
            this.idc1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc1.Image = ((System.Drawing.Image)(resources.GetObject("idc1.Image")));
            this.idc1.Location = new System.Drawing.Point(480, 56);
            this.idc1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idc1.Name = "idc1";
            this.idc1.Size = new System.Drawing.Size(60, 44);
            this.idc1.TabIndex = 110;
            this.idc1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prd0
            // 
            this.prd0.Cursor = System.Windows.Forms.Cursors.Default;
            this.prd0.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd0.Location = new System.Drawing.Point(6, 0);
            this.prd0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prd0.Name = "prd0";
            this.prd0.Size = new System.Drawing.Size(286, 44);
            this.prd0.TabIndex = 109;
            this.prd0.Text = "1";
            // 
            // rt0
            // 
            this.rt0.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt0.Location = new System.Drawing.Point(296, 0);
            this.rt0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rt0.Name = "rt0";
            this.rt0.Size = new System.Drawing.Size(180, 44);
            this.rt0.TabIndex = 108;
            this.rt0.Text = "0";
            this.rt0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerNano
            // 
            this.timerNano.Enabled = true;
            this.timerNano.Interval = 50;
            this.timerNano.Tick += new System.EventHandler(this.timerNano_Tick);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSettings.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.mnuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuProducts,
            this.MnuSections,
            this.switchesToolStripMenuItem,
            this.MnuComm,
            this.MnuRelays,
            this.MnuPressures,
            this.MnuOptions});
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(282, 368);
            // 
            // MnuProducts
            // 
            this.MnuProducts.Image = global::RateController.Properties.Resources.spray2;
            this.MnuProducts.Name = "MnuProducts";
            this.MnuProducts.Size = new System.Drawing.Size(320, 52);
            this.MnuProducts.Text = "Products";
            this.MnuProducts.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // MnuSections
            // 
            this.MnuSections.Image = global::RateController.Properties.Resources.Sec1;
            this.MnuSections.Name = "MnuSections";
            this.MnuSections.Size = new System.Drawing.Size(320, 52);
            this.MnuSections.Text = "Sections";
            this.MnuSections.Click += new System.EventHandler(this.sectionsToolStripMenuItem_Click);
            // 
            // switchesToolStripMenuItem
            // 
            this.switchesToolStripMenuItem.Image = global::RateController.Properties.Resources._switch;
            this.switchesToolStripMenuItem.Name = "switchesToolStripMenuItem";
            this.switchesToolStripMenuItem.Size = new System.Drawing.Size(320, 52);
            this.switchesToolStripMenuItem.Text = "Switches";
            this.switchesToolStripMenuItem.Click += new System.EventHandler(this.switchesToolStripMenuItem_Click);
            // 
            // MnuComm
            // 
            this.MnuComm.Image = global::RateController.Properties.Resources.cableusb_119960;
            this.MnuComm.Name = "MnuComm";
            this.MnuComm.Size = new System.Drawing.Size(320, 52);
            this.MnuComm.Text = "Comm";
            this.MnuComm.Click += new System.EventHandler(this.MnuComm_Click);
            // 
            // MnuRelays
            // 
            this.MnuRelays.Image = global::RateController.Properties.Resources.Industry_Circuit_icon;
            this.MnuRelays.Name = "MnuRelays";
            this.MnuRelays.Size = new System.Drawing.Size(320, 52);
            this.MnuRelays.Text = "Relays";
            this.MnuRelays.Click += new System.EventHandler(this.MnuRelays_Click_1);
            // 
            // MnuPressures
            // 
            this.MnuPressures.Image = global::RateController.Properties.Resources.pressure;
            this.MnuPressures.Name = "MnuPressures";
            this.MnuPressures.Size = new System.Drawing.Size(320, 52);
            this.MnuPressures.Text = "Pressures";
            this.MnuPressures.Click += new System.EventHandler(this.pressuresToolStripMenuItem_Click);
            // 
            // MnuOptions
            // 
            this.MnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNetwork,
            this.largeScreenToolStripMenuItem,
            this.toolStripSeparator3,
            this.MnuNew,
            this.MnuOpen,
            this.MnuSaveAs,
            this.toolStripSeparator2,
            this.mnuMetric,
            this.MnuLanguage,
            this.serialMonitorToolStripMenuItem,
            this.MnuAbout});
            this.MnuOptions.Image = global::RateController.Properties.Resources.Menu;
            this.MnuOptions.Name = "MnuOptions";
            this.MnuOptions.Size = new System.Drawing.Size(281, 52);
            this.MnuOptions.Text = "Options";
            // 
            // mnuNetwork
            // 
            this.mnuNetwork.Image = global::RateController.Properties.Resources.wifi;
            this.mnuNetwork.Name = "mnuNetwork";
            this.mnuNetwork.Size = new System.Drawing.Size(396, 54);
            this.mnuNetwork.Text = "Network";
            this.mnuNetwork.Click += new System.EventHandler(this.wifiToolStripMenuItem_Click);
            // 
            // largeScreenToolStripMenuItem
            // 
            this.largeScreenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("largeScreenToolStripMenuItem.Image")));
            this.largeScreenToolStripMenuItem.Name = "largeScreenToolStripMenuItem";
            this.largeScreenToolStripMenuItem.Size = new System.Drawing.Size(396, 54);
            this.largeScreenToolStripMenuItem.Text = "Large Screen";
            this.largeScreenToolStripMenuItem.Click += new System.EventHandler(this.largeScreenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(393, 6);
            // 
            // MnuNew
            // 
            this.MnuNew.Image = global::RateController.Properties.Resources.FileNew1;
            this.MnuNew.Name = "MnuNew";
            this.MnuNew.Size = new System.Drawing.Size(396, 54);
            this.MnuNew.Text = "New file";
            this.MnuNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // MnuOpen
            // 
            this.MnuOpen.Image = global::RateController.Properties.Resources.OpenFile1;
            this.MnuOpen.Name = "MnuOpen";
            this.MnuOpen.Size = new System.Drawing.Size(396, 54);
            this.MnuOpen.Text = "Open";
            this.MnuOpen.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MnuSaveAs
            // 
            this.MnuSaveAs.Image = global::RateController.Properties.Resources.close2;
            this.MnuSaveAs.Name = "MnuSaveAs";
            this.MnuSaveAs.Size = new System.Drawing.Size(396, 54);
            this.MnuSaveAs.Text = "Save As";
            this.MnuSaveAs.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(393, 6);
            // 
            // mnuMetric
            // 
            this.mnuMetric.Image = global::RateController.Properties.Resources.Check;
            this.mnuMetric.Name = "mnuMetric";
            this.mnuMetric.Size = new System.Drawing.Size(396, 54);
            this.mnuMetric.Text = "Metric Units";
            this.mnuMetric.Click += new System.EventHandler(this.metricToolStripMenuItem_Click);
            // 
            // MnuLanguage
            // 
            this.MnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDeustch,
            this.MnuEnglish,
            this.MnuNederlands,
            this.russianToolStripMenuItem});
            this.MnuLanguage.Image = ((System.Drawing.Image)(resources.GetObject("MnuLanguage.Image")));
            this.MnuLanguage.Name = "MnuLanguage";
            this.MnuLanguage.Size = new System.Drawing.Size(396, 54);
            this.MnuLanguage.Text = "Language";
            // 
            // MnuDeustch
            // 
            this.MnuDeustch.Name = "MnuDeustch";
            this.MnuDeustch.Size = new System.Drawing.Size(347, 54);
            this.MnuDeustch.Text = "Deustch";
            this.MnuDeustch.Click += new System.EventHandler(this.MnuDeustch_Click);
            // 
            // MnuEnglish
            // 
            this.MnuEnglish.Name = "MnuEnglish";
            this.MnuEnglish.Size = new System.Drawing.Size(347, 54);
            this.MnuEnglish.Text = "English";
            this.MnuEnglish.Click += new System.EventHandler(this.MnuEnglish_Click);
            // 
            // MnuNederlands
            // 
            this.MnuNederlands.Name = "MnuNederlands";
            this.MnuNederlands.Size = new System.Drawing.Size(347, 54);
            this.MnuNederlands.Text = "Nederlands";
            this.MnuNederlands.Click += new System.EventHandler(this.MnuNederlands_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(347, 54);
            this.russianToolStripMenuItem.Text = "Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // serialMonitorToolStripMenuItem
            // 
            this.serialMonitorToolStripMenuItem.Image = global::RateController.Properties.Resources.monitor;
            this.serialMonitorToolStripMenuItem.Name = "serialMonitorToolStripMenuItem";
            this.serialMonitorToolStripMenuItem.Size = new System.Drawing.Size(396, 54);
            this.serialMonitorToolStripMenuItem.Text = "Serial Monitor";
            this.serialMonitorToolStripMenuItem.Click += new System.EventHandler(this.serialMonitorToolStripMenuItem_Click);
            // 
            // MnuAbout
            // 
            this.MnuAbout.Image = global::RateController.Properties.Resources.About;
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(396, 54);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "rcs";
            this.openFileDialog1.Filter = "RC Settings|*.rcs";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rcs";
            this.saveFileDialog1.Filter = "RC Settings|*.rcs";
            // 
            // lbPressureValue
            // 
            this.lbPressureValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPressureValue.Location = new System.Drawing.Point(376, 294);
            this.lbPressureValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPressureValue.Name = "lbPressureValue";
            this.lbPressureValue.Size = new System.Drawing.Size(178, 44);
            this.lbPressureValue.TabIndex = 147;
            this.lbPressureValue.Text = "45.2";
            this.lbPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPressureValue.Visible = false;
            // 
            // lbPressure
            // 
            this.lbPressure.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPressure.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPressure.Location = new System.Drawing.Point(4, 294);
            this.lbPressure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(350, 44);
            this.lbPressure.TabIndex = 156;
            this.lbPressure.Text = "Pressure 1";
            this.lbPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPressure.Visible = false;
            // 
            // panFan
            // 
            this.panFan.Controls.Add(this.btnFan);
            this.panFan.Controls.Add(this.lbOn);
            this.panFan.Controls.Add(this.lbOff);
            this.panFan.Controls.Add(this.groupBox1);
            this.panFan.Controls.Add(this.lbTargetRPM);
            this.panFan.Controls.Add(this.label4);
            this.panFan.Controls.Add(this.lbFanRate);
            this.panFan.Controls.Add(this.lbCurrentRPM);
            this.panFan.Controls.Add(this.lbFan);
            this.panFan.Location = new System.Drawing.Point(1232, 715);
            this.panFan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panFan.Name = "panFan";
            this.panFan.Size = new System.Drawing.Size(540, 310);
            this.panFan.TabIndex = 157;
            // 
            // btnFan
            // 
            this.btnFan.BackColor = System.Drawing.Color.Transparent;
            this.btnFan.FlatAppearance.BorderSize = 0;
            this.btnFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFan.Image = global::RateController.Properties.Resources.FanOff;
            this.btnFan.Location = new System.Drawing.Point(234, 188);
            this.btnFan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(100, 96);
            this.btnFan.TabIndex = 203;
            this.btnFan.UseVisualStyleBackColor = false;
            this.btnFan.Click += new System.EventHandler(this.btnFan_Click);
            // 
            // lbOn
            // 
            this.lbOn.BackColor = System.Drawing.SystemColors.Control;
            this.lbOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOn.Image = global::RateController.Properties.Resources.OnSmall;
            this.lbOn.Location = new System.Drawing.Point(470, 6);
            this.lbOn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOn.Name = "lbOn";
            this.lbOn.Size = new System.Drawing.Size(60, 44);
            this.lbOn.TabIndex = 169;
            this.lbOn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbOff
            // 
            this.lbOff.BackColor = System.Drawing.SystemColors.Control;
            this.lbOff.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOff.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOff.Image = global::RateController.Properties.Resources.OffSmall;
            this.lbOff.Location = new System.Drawing.Point(470, 6);
            this.lbOff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOff.Name = "lbOff";
            this.lbOff.Size = new System.Drawing.Size(60, 44);
            this.lbOff.TabIndex = 168;
            this.lbOff.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(504, 2);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            // 
            // lbTargetRPM
            // 
            this.lbTargetRPM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTargetRPM.Location = new System.Drawing.Point(376, 115);
            this.lbTargetRPM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTargetRPM.Name = "lbTargetRPM";
            this.lbTargetRPM.Size = new System.Drawing.Size(178, 44);
            this.lbTargetRPM.TabIndex = 162;
            this.lbTargetRPM.Text = "1,800.50";
            this.lbTargetRPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 44);
            this.label4.TabIndex = 161;
            this.label4.Text = "Target RPM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFanRate
            // 
            this.lbFanRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFanRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFanRate.Location = new System.Drawing.Point(0, 58);
            this.lbFanRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFanRate.Name = "lbFanRate";
            this.lbFanRate.Size = new System.Drawing.Size(350, 44);
            this.lbFanRate.TabIndex = 160;
            this.lbFanRate.Text = "Current RPM";
            this.lbFanRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentRPM
            // 
            this.lbCurrentRPM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentRPM.Location = new System.Drawing.Point(376, 58);
            this.lbCurrentRPM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCurrentRPM.Name = "lbCurrentRPM";
            this.lbCurrentRPM.Size = new System.Drawing.Size(178, 44);
            this.lbCurrentRPM.TabIndex = 159;
            this.lbCurrentRPM.Text = "1,800.50";
            this.lbCurrentRPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFan
            // 
            this.lbFan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFan.Location = new System.Drawing.Point(6, 0);
            this.lbFan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFan.Name = "lbFan";
            this.lbFan.Size = new System.Drawing.Size(396, 44);
            this.lbFan.TabIndex = 158;
            this.lbFan.Text = "Herbicide";
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::RateController.Properties.Resources.ArrowRight1;
            this.btnRight.Location = new System.Drawing.Point(276, 294);
            this.btnRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(126, 119);
            this.btnRight.TabIndex = 143;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = global::RateController.Properties.Resources.ArrowLeft1;
            this.btnLeft.Location = new System.Drawing.Point(142, 294);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(120, 119);
            this.btnLeft.TabIndex = 142;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::RateController.Properties.Resources.SettingsGear64;
            this.btnSettings.Location = new System.Drawing.Point(8, 294);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 119);
            this.btnSettings.TabIndex = 73;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAlarm
            // 
            this.btAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlarm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarm.Image = global::RateController.Properties.Resources.Alarm1;
            this.btAlarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlarm.Location = new System.Drawing.Point(384, 635);
            this.btAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(336, 231);
            this.btAlarm.TabIndex = 146;
            this.btAlarm.Text = "Rate  Alarm  Pressure Alarm";
            this.btAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // timerPIDs
            // 
            this.timerPIDs.Enabled = true;
            this.timerPIDs.Interval = 5000;
            this.timerPIDs.Tick += new System.EventHandler(this.timerPIDs_Tick);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1269);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbPressureValue);
            this.Controls.Add(this.lbAogConnected);
            this.Controls.Add(this.lbArduinoConnected);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.panProducts);
            this.Controls.Add(this.panSummary);
            this.Controls.Add(this.panFan);
            this.Controls.Add(this.btAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.Text = "Rate Controller";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Activated += new System.EventHandler(this.FormStart_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRateControl_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panProducts.ResumeLayout(false);
            this.panSummary.ResumeLayout(false);
            this.mnuSettings.ResumeLayout(false);
            this.panFan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lbArduinoConnected;
        private System.Windows.Forms.Label lbAogConnected;
        private System.Windows.Forms.Panel panProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label SetRate;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label TankRemain;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label AreaDone;
        private System.Windows.Forms.Label lbRateAmount;
        private System.Windows.Forms.Label lbCoverage;
        private System.Windows.Forms.Label lbRemaining;
        private System.Windows.Forms.Panel panSummary;
        private System.Windows.Forms.Label idc0;
        private System.Windows.Forms.Label prd4;
        private System.Windows.Forms.Label rt4;
        private System.Windows.Forms.Label idc4;
        private System.Windows.Forms.Label prd3;
        private System.Windows.Forms.Label rt3;
        private System.Windows.Forms.Label idc3;
        private System.Windows.Forms.Label prd2;
        private System.Windows.Forms.Label rt2;
        private System.Windows.Forms.Label idc2;
        private System.Windows.Forms.Label prd1;
        private System.Windows.Forms.Label rt1;
        private System.Windows.Forms.Label idc1;
        private System.Windows.Forms.Label prd0;
        private System.Windows.Forms.Label rt0;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Timer timerNano;
        private System.Windows.Forms.ContextMenuStrip mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem MnuProducts;
        private System.Windows.Forms.ToolStripMenuItem MnuSections;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btAlarm;
        private System.Windows.Forms.ToolStripMenuItem MnuOptions;
        private System.Windows.Forms.ToolStripMenuItem MnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem MnuDeustch;
        private System.Windows.Forms.ToolStripMenuItem MnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem MnuNederlands;
        private System.Windows.Forms.ToolStripMenuItem MnuNew;
        private System.Windows.Forms.ToolStripMenuItem MnuOpen;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuComm;
        private System.Windows.Forms.ToolStripMenuItem MnuRelays;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMetric;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.ToolStripMenuItem serialMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNetwork;
        private System.Windows.Forms.ToolStripMenuItem MnuPressures;
        private System.Windows.Forms.Label lbPressureValue;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.Panel panFan;
        private System.Windows.Forms.Label lbTargetRPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFanRate;
        private System.Windows.Forms.Label lbCurrentRPM;
        private System.Windows.Forms.Label lbFan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbOn;
        private System.Windows.Forms.Label lbOff;
        private System.Windows.Forms.ToolStripMenuItem largeScreenToolStripMenuItem;
        private System.Windows.Forms.Label idc5;
        private System.Windows.Forms.Label rt5;
        private System.Windows.Forms.Label prd5;
        private System.Windows.Forms.Timer timerPIDs;
        private System.Windows.Forms.ToolStripMenuItem switchesToolStripMenuItem;
        private System.Windows.Forms.Button btnFan;
    }
}