using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBFNetwork.Network
{
    class HiddenNeuron
    {
        public List<double> C { get; set; }
        public double[,] Q { get; set; }
        public double W { get; set; }
        private int N;

        public HiddenNeuron(int N, double[] centers)
        {
            this.N = N;

            Q = new double[N, N];

            for (var i = 0; i < N; i++)
            {
                Q[i, i] = 1;
            }

            C = centers.ToList();

            W = Tools.GetRandom();
        }

        internal List<double> GetRecalculatedC(double result, double coefficient, List<double> x)
        {
            var newC = new List<double>();

            for (var j = 0; j < C.Count; j++)
            {
                var center = -Math.Exp(-1.0 / 2.0 * Tools.u(x, C, Q, N));
                center *= W * result;

                var sum = 0D;
                for (var r = 0; r < x.Count; r++)
                {
                    sum += Q[j, r] * Tools.z(r, x, C, Q, N);
                }

                center *= sum;

                center *= coefficient;

                newC.Add(center);
            }

            return newC;
        }

        internal double GetRecalculatedW(double result, double coefficient, List<double> x)
        {
            var newW = result;

            newW *= Math.Exp(-1.0 / 2.0 * Tools.u(x, C, Q, N));

            newW *= coefficient;

            return newW;
        }

        internal double[,] GetRecalculatedQ(double result, double coefficient, List<double> x)
        {
            double[,] newQ = new double[N, N];

            for (var j = 0; j < N; j++)
            {
                for (var r = 0; r < N; r++)
                {
                    newQ[j, r] = -Math.Exp(-1.0 / 2.0 * Tools.u(x, C, Q, N)) * W * result * (x[j] - C[j]) * Tools.z(r, x, C, Q, N) * coefficient;
                }
            }

            return newQ;
        }
    }
}
