﻿namespace CurrencyExchangeGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.initPriceValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.muValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sigmaValue = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initPriceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.moneyLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sigmaValue);
            this.panel1.Controls.Add(this.muValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.initPriceValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 124);
            this.panel1.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(625, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(69, 20);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Count: 0";
            // 
            // sellButton
            // 
            this.sellButton.Enabled = false;
            this.sellButton.Location = new System.Drawing.Point(518, 12);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(101, 38);
            this.sellButton.TabIndex = 7;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Enabled = false;
            this.buyButton.Location = new System.Drawing.Point(411, 12);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(101, 38);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(625, 30);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(131, 20);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Money: 500,0000";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(229, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 38);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // initPriceValue
            // 
            this.initPriceValue.DecimalPlaces = 4;
            this.initPriceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.initPriceValue.Location = new System.Drawing.Point(103, 19);
            this.initPriceValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.initPriceValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.initPriceValue.Name = "initPriceValue";
            this.initPriceValue.Size = new System.Drawing.Size(120, 26);
            this.initPriceValue.TabIndex = 1;
            this.initPriceValue.Value = new decimal(new int[] {
            701234,
            0,
            0,
            262144});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Price";
            // 
            // chart1
            // 
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 124);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.SystemColors.ActiveCaption;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(869, 393);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "μ";
            // 
            // muValue
            // 
            this.muValue.DecimalPlaces = 4;
            this.muValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.muValue.Location = new System.Drawing.Point(36, 51);
            this.muValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.muValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.muValue.Name = "muValue";
            this.muValue.Size = new System.Drawing.Size(120, 26);
            this.muValue.TabIndex = 1;
            this.muValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "σ";
            // 
            // sigmaValue
            // 
            this.sigmaValue.DecimalPlaces = 4;
            this.sigmaValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.sigmaValue.Location = new System.Drawing.Point(36, 83);
            this.sigmaValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sigmaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sigmaValue.Name = "sigmaValue";
            this.sigmaValue.Size = new System.Drawing.Size(120, 26);
            this.sigmaValue.TabIndex = 1;
            this.sigmaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 517);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initPriceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaValue)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown initPriceValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button sellButton;
		private System.Windows.Forms.Button buyButton;
		private System.Windows.Forms.Label moneyLabel;
		private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sigmaValue;
        private System.Windows.Forms.NumericUpDown muValue;
        private System.Windows.Forms.Label label2;
    }
}

