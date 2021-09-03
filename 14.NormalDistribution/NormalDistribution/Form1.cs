using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NormalDistribution
{
	public partial class Form1 : Form
	{
		readonly NormalDistribution NB;
		readonly Chart[] charts;
		public Form1()
		{
			InitializeComponent();
			NB = new NormalDistribution();
			charts = new Chart[] { chart1, chart2, chart3 }; 
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			NormalDistribution.Method[] probsMethods =
			{
				new NormalDistribution.SummationMethod(meanValue.Value, varianceValue.Value, (int)numberValue.Value),
				new NormalDistribution.MoreAccurateSummation(meanValue.Value, varianceValue.Value, (int)numberValue.Value),
				new NormalDistribution.BoxMullerMethod(meanValue.Value, varianceValue.Value, (int)numberValue.Value)
			};

			for (int i = 0; i < 3; i++)
			{
				var method = probsMethods[i];
				charts[i].Series[0].Points.Clear();
				foreach (var p in method.Probabilities)
				{
					charts[i].Series[0].Points.AddXY(p.Key, p.Value);
				}

				charts[i].Series[1].Points.Clear();
				foreach (var p in method.TProbabilities)
				{
					charts[i].Series[1].Points.AddXY(p.Key, p.Value);
				}


				var average = Controls.Find("average" + i, true).FirstOrDefault() as Label;
				var variance = Controls.Find("variance" + i, true).FirstOrDefault() as Label;
				var chiSquared = Controls.Find("chiSquared" + i, true).FirstOrDefault() as Label;
				var test = Controls.Find("test" + i, true).FirstOrDefault() as Label;
				var time = Controls.Find("time" + i, true).FirstOrDefault() as Label;

				var aError = method.AverageError == 0 ? " (невозможно подсчитать)" : " (error = " + decimal.Round(method.AverageError * 100) + "%)";
				average.Text = method.Average.ToString("F3") + aError;
				variance.Text = method.Variance.ToString("F3") + " (error = " + decimal.Round(method.VarianceError * 100) + "%)";
				time.Text = method.Time.Ticks / (TimeSpan.TicksPerMillisecond / 1000) + "mcs";

				chiSquared.Text = method.ChiSquare.ToString("F3") + " <= " + method.CriticalValue.ToString("F3") + " is ";

				if (method.ChiSquareTest)
				{
					test.Text = "true";
					test.ForeColor = Color.Green;
				}
				else
				{
					test.Text = "false";
					test.ForeColor = Color.Red;
				}
			}
		}
	}
}
