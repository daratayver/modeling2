namespace PoissonStream
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lambda1Value = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberValue = new System.Windows.Forms.NumericUpDown();
            this.lambda2Value = new System.Windows.Forms.NumericUpDown();
            this.timeValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.chiSquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Value)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(454, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Empirical";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Theoretical";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(487, 448);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lambda1Value
            // 
            this.lambda1Value.DecimalPlaces = 4;
            this.lambda1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.lambda1Value.Location = new System.Drawing.Point(43, 14);
            this.lambda1Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lambda1Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lambda1Value.Name = "lambda1Value";
            this.lambda1Value.Size = new System.Drawing.Size(116, 26);
            this.lambda1Value.TabIndex = 1;
            this.lambda1Value.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chiSquareLabel);
            this.panel1.Controls.Add(this.varianceLabel);
            this.panel1.Controls.Add(this.averageLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberValue);
            this.panel1.Controls.Add(this.timeValue);
            this.panel1.Controls.Add(this.lambda2Value);
            this.panel1.Controls.Add(this.lambda1Value);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 446);
            this.panel1.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(123, 166);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 35);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "λ2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "λ1";
            // 
            // numberValue
            // 
            this.numberValue.Location = new System.Drawing.Point(81, 132);
            this.numberValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberValue.Name = "numberValue";
            this.numberValue.Size = new System.Drawing.Size(136, 26);
            this.numberValue.TabIndex = 1;
            this.numberValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lambda2Value
            // 
            this.lambda2Value.DecimalPlaces = 4;
            this.lambda2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.lambda2Value.Location = new System.Drawing.Point(43, 50);
            this.lambda2Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lambda2Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lambda2Value.Name = "lambda2Value";
            this.lambda2Value.Size = new System.Drawing.Size(116, 26);
            this.lambda2Value.TabIndex = 1;
            this.lambda2Value.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // timeValue
            // 
            this.timeValue.DecimalPlaces = 4;
            this.timeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.timeValue.Location = new System.Drawing.Point(43, 86);
            this.timeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeValue.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(116, 26);
            this.timeValue.TabIndex = 1;
            this.timeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "T";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(9, 376);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(68, 20);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.Text = "Average";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Location = new System.Drawing.Point(9, 396);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(72, 20);
            this.varianceLabel.TabIndex = 4;
            this.varianceLabel.Text = "Variance";
            // 
            // chiSquareLabel
            // 
            this.chiSquareLabel.AutoSize = true;
            this.chiSquareLabel.Location = new System.Drawing.Point(9, 416);
            this.chiSquareLabel.Name = "chiSquareLabel";
            this.chiSquareLabel.Size = new System.Drawing.Size(93, 20);
            this.chiSquareLabel.TabIndex = 4;
            this.chiSquareLabel.Text = "ChiSquared";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Poisson stream";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Value)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown lambda1Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberValue;
        private System.Windows.Forms.NumericUpDown lambda2Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timeValue;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label chiSquareLabel;
    }
}

