using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRBFNetwork
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInitialisation_Click(object sender, EventArgs e)
        {
            List<List<double>> dict = null;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "data files (*.data)|*.data|All files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dict = Tools.DownloadSet(fileDialog.FileName);

                    var minMax = Tools.Normalize(ref dict);

                    var countNeurons = (int)numericUpDownCountNeurons.Value;
                    var countCenters = (int)numericUpDownCountCenters.Value;

                    List<double> l = new List<double>();
                    for(var i = 0; i < dict.Count; i++)
                    {
                        l.AddRange(dict[i]);
                    }

                    var extremums = /*dict.FindExtremum(countNeurons, countCenters);*/Tools.ExtractCenters(l, countCenters, countNeurons);

                    var test = new List<List<double>>();

                    var testCount = 0;

                    for(var i = dict.Count - 1; i < dict.Count; i++)
                    {
                        var t = new List<double>();

                        var cnt = dict[i].Count - 12;

                        for(var j = cnt; j < dict[i].Count; j++)
                        {
                            t.Add(dict[i][j]);
                            testCount++;
                        }

                        testCount -= countCenters;

                        test.Add(t);

                        for (var j = cnt; j < dict[i].Count; j++)
                        {
                            dict[i].RemoveAt(j--);
                        }
                    }

                    chartTest.ChartAreas["ChartArea1"].AxisX.Maximum = testCount - 1;

                    Network.Network.InitNetwork(countNeurons, countCenters, extremums.Select(t => t.Item1).ToList(), this, dict, minMax[1], minMax[0], test);

                    buttonStartLearning.Enabled = true;
                    chartLearning.Series["Ошибка обучения"].Points.Clear();
                    Network.Network.Clear();
                }
            }
        }

        internal void PaintTest(List<double> real, List<double> netw, double error)
        {
            chartTest.Invoke((MethodInvoker)delegate
            {
                var x = new List<double>();
                for(var i = 0; i < real.Count; i++)
                {
                    x.Add(i);
                }

                real = real.Select(y => y * /*(Network.Network.Max - Network.Network.Min) + Network.Network.Min*/Network.Network.Max).ToList();
                netw = netw.Select(y => y * /*(Network.Network.Max - Network.Network.Min) + Network.Network.Min*/Network.Network.Max).ToList();

                chartTest.Series["Реальные данные"].Points.DataBindXY(x, real);
                chartTest.Series["Выход сети"].Points.DataBindXY(x, netw);
            });

            textBoxTestError.Invoke((MethodInvoker)delegate
            {
                textBoxTestError.Text = error.ToString();
            });
        }

        internal void PaintCurrentLearningError(int epoch, double currentError)
        {
            textBoxCurrentLearningError.Invoke((MethodInvoker)delegate
            {
                textBoxCurrentLearningError.Text = string.Format("{0:0.00000}", currentError);
            });

            chartLearning.Invoke((MethodInvoker)delegate
            {
                chartLearning.Series["Ошибка обучения"].Points.AddXY(epoch, currentError);
            });
        }

        private void buttonStartLearning_Click(object sender, EventArgs e)
        {
            buttonStartLearning.Enabled = false;
            buttonStopLearning.Enabled = true;
            buttonInitialisation.Enabled = false;

            numericUpDownCountEpoch.ReadOnly = true;
            numericUpDownLearningError.ReadOnly = true;

            Network.Network.Learning();
        }

        public double GetLearningCoefficient()
        {
            var value = 0.0;
            numericUpDownLearningCoefficient.Invoke((MethodInvoker)delegate
            {
                value = (double)numericUpDownLearningCoefficient.Value;
            });

            return value != 0.0 ? value : 0.001;
        }

        public double GetLearningError()
        {
            var value = (double)numericUpDownLearningError.Value;
            return value != 0 ? value : 0.001;
        }

        public int GetCountEpoch()
        {
            return (int)numericUpDownCountEpoch.Value;
        }

        public void SwitchStopLearning()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                buttonStartLearning.Enabled = true;
                buttonStopLearning.Enabled = false;
                buttonInitialisation.Enabled = true;

                numericUpDownCountEpoch.ReadOnly = false;
                numericUpDownLearningError.ReadOnly = false;
            });
        }

        private void buttonStopLearning_Click(object sender, EventArgs e)
        {
            Network.Network.StopLearning();

            SwitchStopLearning();
        }

        internal void PaintCurrentLearningEpoch(int epoch)
        {
            textBoxCurrentLearningEpoch.Invoke((MethodInvoker)delegate
            {
                textBoxCurrentLearningEpoch.Text = epoch.ToString();
            });
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                var input = new List<double>();

                input = textBoxInput.Text.Split(new char[] { ';' }).Select(x => double.Parse(x.Replace('.', ',')) / Network.Network.Max).ToList();

                textBoxOutput.Text = (Network.Network.Calculate(input) * (Network.Network.Max - Network.Network.Min) + Network.Network.Min).ToString();
            }
            catch { }
        }
    }
}
