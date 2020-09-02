using Accord.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBFNetwork
{
    public static class Tools
    {
        private static Random random = new Random();

        public static List<List<double>> FindExtremum(this List<List<double>> list, int countExtremums, int countCenters)
        {
            var extremums = GetAllExtremums(list);
            List<List<double>> result = new List<List<double>>();

            var j = 0;
            for (int i = 0; i < countExtremums; i++)
            {
                List<double> l = new List<double>();
                for (var k = 0; k < countCenters; k++)
                {
                    if (j >= extremums.Count)
                    {
                        l.Add(GetRandom());
                    }
                    else
                    {
                        l.Add(extremums[j++]);
                    }
                }

                result.Add(l);
            }

            return result;
        }

        private static List<double> GetAllExtremums(List<List<double>> list)
        {
            List<double> result = new List<double>();

            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 1; j < list[i].Count - 1; j++)
                {
                    if ((list[i][j] > list[i][j - 1] && list[i][j] > list[i][j + 1]) ||
                        list[i][j] < list[i][j - 1] && list[i][j] < list[i][j + 1])
                    {
                        result.Add(list[i][j]);
                    }
                }
            }

            return result;
        }

        internal static List<List<double>> DownloadSet(string fileName)
        {
            var result = new List<List<double>>();
            string[] values = File.ReadAllLines(fileName);
            var countRows = values.Length;
            var count = values[0].Split(new char[] { ',' }).Length;

            var matrix = new double[values.Length, count];

            for (var i = 0; i < values.Length; i++)
            {
                var value = values[i].Split(new char[] { ',' });

                for (var j = 0; j < value.Length; j++)
                {
                    matrix[i, j] = double.Parse(value[j]);
                }
            }

            matrix = Matrix.Transpose(matrix);

            for (var i = 0; i < count; i++)
            {
                List<double> list = new List<double>();
                for (var j = 0; j < countRows; j++)
                {
                    list.Add(matrix[i, j]);
                }
                result.Add(list);
            }

            return result;
        }

        internal static double[] Normalize(ref List<List<double>> list)
        {
            var max = double.MinValue;
            var min = double.MaxValue;

            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Max() > max)
                {
                    max = list[i].Max();
                }

                if (list[i].Min() < min)
                {
                    min = list[i].Min();
                }
            }

            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list[i].Count; j++)
                {
                    list[i][j] = /*(list[i][j] - min) / (max - min);*/list[i][j] / max;
                }
            }

            return new double[] { min, max };
        }

        internal static double u(List<double> x, List<double> c, double[,] Q, int N)
        {
            var result = 0D;

            for (var j = 0; j < N; j++)
            {
                result += Math.Pow(z(j, x, c, Q, N), 2);
            }

            return result;
        }

        internal static double z(int r, List<double> x, List<double> c, double[,] Q, int N)
        {
            var result = 0D;

            for (var j = 0; j < N; j++)
            {
                result += Q[j, r] * (x[j] - c[j]);
            }

            return result;
        }

        internal static double GetRandom()
        {
            return random.NextDouble();
        }

        internal static double GetRandom(double minValue, double maxValue)
        {
            return GetRandom() * (maxValue - minValue) + minValue;
        }

        internal static List<Pair<double[], double>> ExtractCenters(List<double> data, int inputNeuronCount, int hiddenNeuronCount)
        {
            var result = new List<Pair<double[], double>>();

            var allCenters = GetCenters(data.ToArray(), inputNeuronCount);

            for (int i = 0; i < allCenters.Count; i++)
            {
                var dist = allCenters.Select(t1 => CalcDist(t1, allCenters[i])).Max();
                if (!Contains(result, allCenters[i]))
                {
                    if (result.Count < hiddenNeuronCount)
                    {
                        result.Add(new Pair<double[], double>(allCenters[i], dist));
                    }
                    else if (result.Count >= hiddenNeuronCount)
                    {
                        var min = result.Min(t1 => t1.Item2);
                        var minItem = result.Find(t1 => t1.Item2 == min);
                        result.Remove(minItem);
                        result.Add(new Pair<double[], double>(allCenters[i], dist));
                    }
                }
            }

            return result;
        }

        public static List<double[]> GetCenters(double[] sourceData, int cSize)
        {
            var centers = new List<double[]>();

            var halfCSize = cSize / 2;
            for (var i = halfCSize; i < sourceData.Length - halfCSize; i++)
            {
                if (i == halfCSize ||
                    i == sourceData.Length - halfCSize - 1 ||
                    sourceData[i] > sourceData[i + 1] && sourceData[i] > sourceData[i - 1] ||
                    sourceData[i] < sourceData[i + 1] && sourceData[i] < sourceData[i - 1])
                {
                    centers.Add(GetCVector(sourceData, i, cSize));
                }
            }
            return centers;
        }

        private static double[] GetCVector(double[] sourceData, int cCenterIndex, int cSize)
        {
            var center = new double[cSize];
            var halfSize = cSize / 2;
            Array.Copy(sourceData, cCenterIndex - halfSize, center, 0, cSize);
            return center;
        }

        private static double CalcDist(double[] v1, double[] v2)
        {
            var result = 0D;
            for (int i = 0; i < v1.Length; i++)
            {
                result += Math.Pow(v1[i] - v2[i], 2);
            }
            return Math.Sqrt(result);
        }

        private static bool Contains(List<Pair<double[], double>> result, double[] v)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (Equal1(result[i].Item1, v)) return true;
            }
            return false;
        }

        private static bool Equal1(double[] item1, double[] v)
        {
            for (int i = 0; i < item1.Length; i++)
            {
                if (item1[i] != v[i]) return false;
            }
            return true;
        }
    }
}