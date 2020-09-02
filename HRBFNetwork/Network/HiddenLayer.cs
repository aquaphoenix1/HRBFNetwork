using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRBFNetwork.Network
{
    class HiddenLayer
    {
        private List<HiddenNeuron> hiddenNeurons;
        private ActivationNeuron activationNeuron;

        private int N;

        public HiddenLayer(int K, int N, List<double[]> centers)
        {
            this.N = N;

            hiddenNeurons = new List<HiddenNeuron>();

            for (var i = 0; i < K; i++)
            {
                hiddenNeurons.Add(new HiddenNeuron(N, centers[i]));
            }

            activationNeuron = new ActivationNeuron();
        }

        public List<double> Calculate(List<double> x)
        {
            var result = new List<double>
            {
                activationNeuron.Calculate()
            };

            for (var i = 0; i < hiddenNeurons.Count; i++)
            {
                result.Add(Phi(i, x) * hiddenNeurons[i].W);
            }

            return result;
        }

        private double Phi(int i, List<double> x)
        {
            List<double> xMinusC = new List<double>();
            for (var index = 0; index < x.Count; index++)
            {
                xMinusC.Add(x[index] - hiddenNeurons[i].C[index]);
            }

            var matrix = Matrix.Dot(hiddenNeurons[i].Q, Matrix.Transpose(xMinusC.ToArray()));

            var result = Math.Exp(-1.0 / 2.0 * Matrix.Dot(Matrix.Transpose(matrix), matrix)[0, 0]);

            return result;
        }

        internal List<List<double>> GetRecalculatedC(double result, double coefficient, List<double> x)
        {
            var newC = new List<List<double>>();

            for (var i = 0; i < hiddenNeurons.Count; i++)
            {
                newC.Add(hiddenNeurons[i].GetRecalculatedC(result, coefficient, x));
            }

            return newC;
        }

        internal void SetNewW(List<double> newW)
        {
            activationNeuron.W -= newW[0];

            for (var i = 0; i < newW.Count - 1; i++)
            {
                hiddenNeurons[i].W -= newW[i + 1];
            }
        }

        internal void SetNewQ(List<double[,]> newQ)
        {
            for (var i = 0; i < newQ.Count; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    for (var k = 0; k < N; k++)
                    {
                        hiddenNeurons[i].Q[j, k] -= newQ[i][j, k];
                    }
                }
            }
        }

        internal void SetNewCenters(List<List<double>> newCenters)
        {
            for (var i = 0; i < newCenters.Count; i++)
            {
                for (var j = 0; j < newCenters[i].Count; j++)
                {
                    hiddenNeurons[i].C[j] -= newCenters[i][j];
                }
            }
        }

        internal List<double[,]> GetRecalculatedQ(double result, double coefficient, List<double> x)
        {
            var newQ = new List<double[,]>();

            for (var i = 0; i < hiddenNeurons.Count; i++)
            {
                newQ.Add(hiddenNeurons[i].GetRecalculatedQ(result, coefficient, x));
            }

            return newQ;
        }

        internal List<double> GetRecalculatedW(double result, double coefficient, List<double> x)
        {
            var newW = new List<double>
            {
                result * coefficient
            };

            for (var i = 0; i < hiddenNeurons.Count; i++)
            {
                newW.Add(hiddenNeurons[i].GetRecalculatedW(result, coefficient, x));
            }

            return newW;
        }

        internal int GetNeuronsCount()
        {
            return hiddenNeurons.Count;
        }
    }
}
