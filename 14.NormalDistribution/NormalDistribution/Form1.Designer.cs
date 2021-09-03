namespace NormalDistribution
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.numberValue = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.varianceValue = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.meanValue = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label7 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.average0 = new System.Windows.Forms.Label();
			this.variance0 = new System.Windows.Forms.Label();
			this.chiSquared0 = new System.Windows.Forms.Label();
			this.test0 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.average1 = new System.Windows.Forms.Label();
			this.variance1 = new System.Windows.Forms.Label();
			this.chiSquared1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.test1 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.average2 = new System.Windows.Forms.Label();
			this.variance2 = new System.Windows.Forms.Label();
			this.chiSquared2 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.test2 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label4 = new System.Windows.Forms.Label();
			this.time0 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.time1 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.time2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.varianceValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meanValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.startButton);
			this.panel1.Controls.Add(this.numberValue);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.varianceValue);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.meanValue);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(307, 824);
			this.panel1.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.Location = new System.Drawing.Point(191, 207);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(94, 30);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// numberValue
			// 
			this.numberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberValue.Location = new System.Drawing.Point(191, 175);
			this.numberValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numberValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberValue.Name = "numberValue";
			this.numberValue.Size = new System.Drawing.Size(94, 26);
			this.numberValue.TabIndex = 1;
			this.numberValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Number of experiments";
			// 
			// varianceValue
			// 
			this.varianceValue.DecimalPlaces = 3;
			this.varianceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.varianceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.varianceValue.Location = new System.Drawing.Point(86, 128);
			this.varianceValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.varianceValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.varianceValue.Name = "varianceValue";
			this.varianceValue.Size = new System.Drawing.Size(120, 26);
			this.varianceValue.TabIndex = 1;
			this.varianceValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Variance";
			// 
			// meanValue
			// 
			this.meanValue.DecimalPlaces = 3;
			this.meanValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.meanValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.meanValue.Location = new System.Drawing.Point(86, 96);
			this.meanValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.meanValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.meanValue.Name = "meanValue";
			this.meanValue.Size = new System.Drawing.Size(120, 26);
			this.meanValue.TabIndex = 1;
			this.meanValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mean";
			// 
			// chart1
			// 
			chartArea4.AxisY.Minimum = 0D;
			chartArea4.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea4);
			this.chart1.Location = new System.Drawing.Point(307, 31);
			this.chart1.Name = "chart1";
			series7.ChartArea = "ChartArea1";
			series7.Name = "Series1";
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series8.Name = "Series2";
			this.chart1.Series.Add(series7);
			this.chart1.Series.Add(series8);
			this.chart1.Size = new System.Drawing.Size(425, 330);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(313, 364);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Average:";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label.Location = new System.Drawing.Point(313, 384);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(76, 20);
			this.label.TabIndex = 2;
			this.label.Text = "Variance:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(313, 421);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Chi-squared:";
			// 
			// average0
			// 
			this.average0.AutoSize = true;
			this.average0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.average0.Location = new System.Drawing.Point(391, 364);
			this.average0.Name = "average0";
			this.average0.Size = new System.Drawing.Size(0, 20);
			this.average0.TabIndex = 2;
			// 
			// variance0
			// 
			this.variance0.AutoSize = true;
			this.variance0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variance0.Location = new System.Drawing.Point(395, 384);
			this.variance0.Name = "variance0";
			this.variance0.Size = new System.Drawing.Size(0, 20);
			this.variance0.TabIndex = 2;
			// 
			// chiSquared0
			// 
			this.chiSquared0.AutoSize = true;
			this.chiSquared0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chiSquared0.Location = new System.Drawing.Point(418, 421);
			this.chiSquared0.Name = "chiSquared0";
			this.chiSquared0.Size = new System.Drawing.Size(0, 20);
			this.chiSquared0.TabIndex = 2;
			// 
			// test0
			// 
			this.test0.AutoSize = true;
			this.test0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.test0.Location = new System.Drawing.Point(575, 421);
			this.test0.Name = "test0";
			this.test0.Size = new System.Drawing.Size(0, 20);
			this.test0.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(313, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(173, 20);
			this.label12.TabIndex = 4;
			this.label12.Text = "Метод суммирования";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(740, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(302, 20);
			this.label13.TabIndex = 4;
			this.label13.Text = "Более точная формула суммирования";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(752, 364);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Average:";
			// 
			// average1
			// 
			this.average1.AutoSize = true;
			this.average1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.average1.Location = new System.Drawing.Point(830, 364);
			this.average1.Name = "average1";
			this.average1.Size = new System.Drawing.Size(0, 20);
			this.average1.TabIndex = 2;
			// 
			// variance1
			// 
			this.variance1.AutoSize = true;
			this.variance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variance1.Location = new System.Drawing.Point(834, 384);
			this.variance1.Name = "variance1";
			this.variance1.Size = new System.Drawing.Size(0, 20);
			this.variance1.TabIndex = 2;
			// 
			// chiSquared1
			// 
			this.chiSquared1.AutoSize = true;
			this.chiSquared1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chiSquared1.Location = new System.Drawing.Point(857, 421);
			this.chiSquared1.Name = "chiSquared1";
			this.chiSquared1.Size = new System.Drawing.Size(0, 20);
			this.chiSquared1.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(752, 384);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 20);
			this.label10.TabIndex = 2;
			this.label10.Text = "Variance:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(752, 421);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(99, 20);
			this.label11.TabIndex = 2;
			this.label11.Text = "Chi-squared:";
			// 
			// test1
			// 
			this.test1.AutoSize = true;
			this.test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.test1.Location = new System.Drawing.Point(1014, 421);
			this.test1.Name = "test1";
			this.test1.Size = new System.Drawing.Size(0, 20);
			this.test1.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(740, 526);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 20);
			this.label15.TabIndex = 2;
			this.label15.Text = "Average:";
			// 
			// average2
			// 
			this.average2.AutoSize = true;
			this.average2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.average2.Location = new System.Drawing.Point(818, 526);
			this.average2.Name = "average2";
			this.average2.Size = new System.Drawing.Size(0, 20);
			this.average2.TabIndex = 2;
			// 
			// variance2
			// 
			this.variance2.AutoSize = true;
			this.variance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variance2.Location = new System.Drawing.Point(822, 546);
			this.variance2.Name = "variance2";
			this.variance2.Size = new System.Drawing.Size(0, 20);
			this.variance2.TabIndex = 2;
			// 
			// chiSquared2
			// 
			this.chiSquared2.AutoSize = true;
			this.chiSquared2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chiSquared2.Location = new System.Drawing.Point(845, 583);
			this.chiSquared2.Name = "chiSquared2";
			this.chiSquared2.Size = new System.Drawing.Size(0, 20);
			this.chiSquared2.TabIndex = 2;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(740, 546);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(76, 20);
			this.label19.TabIndex = 2;
			this.label19.Text = "Variance:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label20.Location = new System.Drawing.Point(740, 583);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(99, 20);
			this.label20.TabIndex = 2;
			this.label20.Text = "Chi-squared:";
			// 
			// test2
			// 
			this.test2.AutoSize = true;
			this.test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.test2.Location = new System.Drawing.Point(1002, 583);
			this.test2.Name = "test2";
			this.test2.Size = new System.Drawing.Size(0, 20);
			this.test2.TabIndex = 3;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label22.Location = new System.Drawing.Point(740, 493);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(187, 20);
			this.label22.TabIndex = 4;
			this.label22.Text = "Метод Бокса–Мюллера";
			// 
			// chart2
			// 
			chartArea5.AxisY.Minimum = 0D;
			chartArea5.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea5);
			this.chart2.Location = new System.Drawing.Point(744, 31);
			this.chart2.Name = "chart2";
			series9.ChartArea = "ChartArea1";
			series9.Name = "Series1";
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series10.Name = "Series2";
			this.chart2.Series.Add(series9);
			this.chart2.Series.Add(series10);
			this.chart2.Size = new System.Drawing.Size(425, 330);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart1";
			// 
			// chart3
			// 
			chartArea6.AxisY.Minimum = 0D;
			chartArea6.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea6);
			this.chart3.Location = new System.Drawing.Point(307, 482);
			this.chart3.Name = "chart3";
			series11.ChartArea = "ChartArea1";
			series11.Name = "Series1";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series12.Name = "Series2";
			this.chart3.Series.Add(series11);
			this.chart3.Series.Add(series12);
			this.chart3.Size = new System.Drawing.Size(425, 330);
			this.chart3.TabIndex = 1;
			this.chart3.Text = "chart1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(492, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Time: ";
			// 
			// time0
			// 
			this.time0.AutoSize = true;
			this.time0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.time0.Location = new System.Drawing.Point(549, 8);
			this.time0.Name = "time0";
			this.time0.Size = new System.Drawing.Size(0, 20);
			this.time0.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(1048, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Time: ";
			// 
			// time1
			// 
			this.time1.AutoSize = true;
			this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.time1.Location = new System.Drawing.Point(1105, 8);
			this.time1.Name = "time1";
			this.time1.Size = new System.Drawing.Size(0, 20);
			this.time1.TabIndex = 6;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(933, 493);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(51, 20);
			this.label16.TabIndex = 5;
			this.label16.Text = "Time: ";
			// 
			// time2
			// 
			this.time2.AutoSize = true;
			this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.time2.Location = new System.Drawing.Point(990, 493);
			this.time2.Name = "time2";
			this.time2.Size = new System.Drawing.Size(0, 20);
			this.time2.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1180, 824);
			this.Controls.Add(this.time2);
			this.Controls.Add(this.time1);
			this.Controls.Add(this.time0);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.test2);
			this.Controls.Add(this.test1);
			this.Controls.Add(this.test0);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label);
			this.Controls.Add(this.chiSquared2);
			this.Controls.Add(this.chiSquared1);
			this.Controls.Add(this.chiSquared0);
			this.Controls.Add(this.variance2);
			this.Controls.Add(this.variance1);
			this.Controls.Add(this.variance0);
			this.Controls.Add(this.average2);
			this.Controls.Add(this.average1);
			this.Controls.Add(this.average0);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chart3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Statistics Of Event Generating";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.varianceValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meanValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.NumericUpDown meanValue;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown numberValue;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label average0;
		private System.Windows.Forms.Label variance0;
		private System.Windows.Forms.Label chiSquared0;
		private System.Windows.Forms.Label test0;
		private System.Windows.Forms.NumericUpDown varianceValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label average1;
		private System.Windows.Forms.Label variance1;
		private System.Windows.Forms.Label chiSquared1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label test1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label average2;
		private System.Windows.Forms.Label variance2;
		private System.Windows.Forms.Label chiSquared2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label test2;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label time0;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label time1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label time2;
	}
}

