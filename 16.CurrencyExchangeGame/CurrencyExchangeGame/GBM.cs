using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeGame
{
    class GBM
    {
        static readonly Random random = new Random();
        public GBM(double x0, double dt, double mu, double sigma)
        {
            Mu = mu;
            Sigma = sigma;
            dT = dt;

            X = new List<double> { x0 };
            W = new List<double> { 0 };
        }
        IList<double> X { get; set; }
        IList<double> W { get; set; }

        double Mu { get; set; }
        double Sigma { get; set; }
        double dT { get; set; }

        public double GetNextRV()
        {
            var wt = W.Last() + Math.Sqrt(dT) * NormalVR();
            var x = X.Last() * Math.Exp((Mu - Sigma * Sigma / 2) * dT + Sigma * wt);
            W.Add(wt);
            X.Add(x);
            return x;
        }

        double NormalVR()
        {
            double rv = 0;
            for (int j = 0; j < 12; j++)
            {
                rv += random.NextDouble();
            }
            rv -= 6;
            rv += (Math.Pow(rv, 3) - 3 * rv) / 240;

            return rv;
        }
    }
}
