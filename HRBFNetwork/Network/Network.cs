using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HRBFNetwork.Network
{
    static class Network
    {
        private static FormMain formMain;

        private static List<List<double>> learningSet;
        private static List<List<double>> testSet;

        private static HiddenLayer hiddenLayer;
        private static OutputLayer outputLayer;

        private static CancellationTokenSource learningTokenSource;
        private static CancellationToken cancellationLearningToken;

        private static int epoch;
        private static int window;

        public static double Max { get; set; }
        public static double Min { get; set; }

        public static void InitNetwork(int K, int N, List<double[]> centers, FormMain formMain, List<List<double>> learningSet, double maxValue, double minValue, List<List<double>> test)
        {
            Max = maxValue;
            Min = minValue;
            testSet = test;
            Network.formMain = formMain;
            window = centers[0].Length;

            hiddenLayer = new HiddenLayer(K, N, centers);
            outputLayer = new OutputLayer();

            Network.learningSet = learningSet;
        }

        public static double Calculate(List<double> x)
        {
            return outputLayer.Calcaulte(hiddenLayer.Calculate(x));
        }

        public static void StopLearning()
        {
            learningTokenSource.Cancel();
            learningTokenSource.Dispose();

            CheckNetwork();
        }

        private static void CheckNetwork()
        {
            var real = new List<double>();
            var netw = new List<double>();

            var error = 0D;

            for (var k = 0; k < testSet.Count; k++)
            {
                var values = new List<double>();
                for (var j = 0; j < window; j++)
                {
                    values.Add(learningSet[k][j]);
                }
                var i = window;
                for (; i < testSet[k].Count; i++)
                {
                    var output = testSet[k][i];
                    var result = Calculate(values);
                    values.RemoveAt(0);
                    values.Add(output);

                    real.Add(output);
                    netw.Add(result);

                    error += Math.Pow(result - output, 2);
                }
            }

            error = Math.Sqrt(error / (netw.Count - 1));

            formMain.PaintTest(real, netw, error);
        }

        public static void Learning()
        {
            learningTokenSource = new CancellationTokenSource();
            cancellationLearningToken = learningTokenSource.Token;

            double currentError = double.MaxValue;

            var maxEpoch = formMain.GetCountEpoch();

            Task.Run(() =>
            {
                while (currentError > formMain.GetLearningError() || maxEpoch == 0)
                {
                    currentError = Epoch();

                    formMain.PaintCurrentLearningError(epoch, currentError);
                    formMain.PaintCurrentLearningEpoch(epoch);

                    epoch++;

                    if(epoch >= maxEpoch && maxEpoch != 0)
                    {
                        StopLearning();
                        formMain.SwitchStopLearning();
                    }

                    if(epoch % 10 == 0)
                    {
                        CheckNetwork();
                    }

                    if (cancellationLearningToken.IsCancellationRequested)
                    {
                        try
                        {
                            cancellationLearningToken.ThrowIfCancellationRequested();
                        }
                        catch
                        {
                            return;
                        }
                        finally
                        {
                            learningTokenSource.Dispose();
                        }
                    }
                }

                StopLearning();
                formMain.SwitchStopLearning();
            }, learningTokenSource.Token);
        }

        private static double Epoch()
        {
            double learningCoefficient = formMain.GetLearningCoefficient();

            var error = 0D;

            for (var k = 0; k < learningSet.Count; k++)
            {
                for (var e = 0; e < 10; e++)
                {
                    var values = new List<double>();
                    for (var j = 0; j < window; j++)
                    {
                        values.Add(learningSet[k][j]);
                    }

                    for (var i = window; i < learningSet[k].Count; i++)
                    {
                        var output = learningSet[k][i];

                        var result = Calculate(values);

                        result -= output;

                        var newCenters = hiddenLayer.GetRecalculatedC(result, learningCoefficient, values);
                        var newW = hiddenLayer.GetRecalculatedW(result, learningCoefficient, values);
                        var newQ = hiddenLayer.GetRecalculatedQ(result, learningCoefficient, values);

                        result = Math.Pow(result, 2);
                        result /= 2.0;

                        error += result;

                        hiddenLayer.SetNewCenters(newCenters);
                        hiddenLayer.SetNewW(newW);
                        hiddenLayer.SetNewQ(newQ);

                        values.RemoveAt(0);
                        values.Add(output);
                    }
                }
            }

            error = Math.Sqrt(error / (hiddenLayer.GetNeuronsCount() - 1) / 70);

            return error;
        }

        internal static void Clear()
        {
            epoch = 0;
        }
    }
}
