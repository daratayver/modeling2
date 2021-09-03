using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions; 

namespace NormalDistribution
{
	class NormalDistribution
	{
		public abstract class Method
		{
			protected static readonly Random random = new Random();

			public Method(decimal mean, decimal variance, int N)
			{
				var start = DateTime.Now;
				Generate(mean, variance, N);
				var end = DateTime.Now;
				Time = end - start;

				CountProbs(mean, variance, N);
				CountParameters( mean, variance, N);
				TheoreticalProbs(mean, variance, N);
			}

			public TimeSpan Time { get; private set; }

			public decimal Average { get; private set; }
			public decimal AverageError { get; private set; }
			public decimal Variance { get; private set; }
			public decimal VarianceError { get; private set; }

			public decimal ChiSquare { get; private set; }
			public bool ChiSquareTest { get; private set; }
			public decimal CriticalValue { get; private set; }

			public Dictionary<decimal, decimal> Probabilities { get; private set; }
			public Dictionary<decimal, decimal> TProbabilities { get; private set; }
			public decimal[] Randvariables { get; protected set; }
			public Dictionary<decimal, int> Frequency { get; private set; }
			public decimal Interval { get; protected set; }
			public abstract void Generate(decimal mean, decimal variance, int N);

			protected void CountProbs(decimal mean, decimal variance, int N)
			{
				Array.Sort(Randvariables);

				Frequency = new Dictionary<decimal, int>();

				int m = (int)Math.Log(N) + 1;
				decimal min = Randvariables.First();
				decimal max = Randvariables.Last();
				Interval = (max - min) / m;
				int k = 0;
				for (decimal i = min; i <= max; i += Interval)
				{
					var x = i;
					Frequency[x] = 0;
					while (k < Randvariables.Length && Randvariables[k] <= i + Interval / 2)
					{
						Frequency[x] += 1;
						k++;
					}
				}

				Probabilities = new Dictionary<decimal, decimal>();
				for (decimal i = min; i <= max; i += Interval)
				{
					Probabilities[i] = (decimal)Frequency[i] / N;
				}
			}

			protected void CountParameters(decimal mean, decimal variance, int N)
			{
				Average = 0;
				foreach (var x in Randvariables)
				{
					Average += x;
				}
				Average /= N;
				if (mean > 0)
					AverageError = Math.Abs((Average - mean) / mean);

				Variance = 0;
				foreach (var x in Randvariables)
				{
					Variance += x * x;
				}
				Variance /= N;
				Variance -= Average * Average;
				VarianceError = Math.Abs((Variance - variance) / variance);

				ChiSquare = 0;

				foreach (var f in Frequency)
				{
					var p = Interval / (decimal)(Math.Sqrt((double)variance) * Math.Sqrt(2 * Math.PI))
						* (decimal)Math.Exp((double)(-(f.Key - mean) * (f.Key - mean) / (2 * variance)));
					ChiSquare += (f.Value - N * p) * (f.Value - N * p) / (N * p);
				}

				CriticalValue = (decimal)ChiSquared.InvCDF(Probabilities.Count - 1, 1 - 0.05);
				if (ChiSquare <= CriticalValue) ChiSquareTest = true;
				else ChiSquareTest = false;
			}

			public void TheoreticalProbs(decimal mean, decimal variance, int N)
			{
				var sigma = Math.Sqrt((double)variance);

				decimal min = Randvariables.First();
				decimal max = Randvariables.Last();
				TProbabilities = new Dictionary<decimal, decimal>();
				for (decimal i = min; i <= max; i += 0.1M)
				{
					var y = 1 / (decimal)(sigma * Math.Sqrt(2 * Math.PI)) * (decimal)Math.Exp((double)(-(i - mean) * (i - mean) / (2 * variance)));
					TProbabilities.Add(i, y);
				}
			}
		}

		public class SummationMethod : Method
		{
			public SummationMethod(decimal mean, decimal variance, int N) : base(mean, variance, N)
			{

			}
			public override void Generate(decimal mean, decimal variance, int N)
			{
				decimal sigma = (decimal)Math.Sqrt((double)variance);

				Randvariables = new decimal[N];

				var start = DateTime.Now;
				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < 12; j++)
					{
						Randvariables[i] += (decimal)random.NextDouble();
					}
					Randvariables[i] -= 6;

					Randvariables[i] = sigma * Randvariables[i] + mean;
				}
			}
		}

		public class MoreAccurateSummation : Method
		{
			public MoreAccurateSummation(decimal mean, decimal variance, int N) : base(mean, variance, N)
			{

			}
			public override void Generate(decimal mean, decimal variance, int N)
			{
				decimal sigma = (decimal)Math.Sqrt((double)variance);

				Randvariables = new decimal[N];
				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < 12; j++)
					{
						Randvariables[i] += (decimal)random.NextDouble();
					}
					Randvariables[i] -= 6;
					Randvariables[i] = Randvariables[i] + ((decimal)Math.Pow((double)Randvariables[i], 3) - 3 * Randvariables[i]) / 240;

					Randvariables[i] = sigma * Randvariables[i] + mean;
				}
			}
		}

		public class BoxMullerMethod : Method
		{
			public BoxMullerMethod(decimal mean, decimal variance, int N) : base(mean, variance, N)
			{

			}
			public override void Generate(decimal mean, decimal variance, int N)
			{
				decimal sigma = (decimal)Math.Sqrt((double)variance);

				Randvariables = new decimal[N];
				for (int i = 0; i < N; i++)
				{
					var a1 = random.NextDouble();
					var a2 = random.NextDouble();
					Randvariables[i] = (decimal)(Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2));
					var z1 = Math.Sqrt(-2 * Math.Log(a1)) * Math.Sin(2 * Math.PI * a2);

					Randvariables[i] = sigma * Randvariables[i] + mean;
				}
			}
		}
	}
}
