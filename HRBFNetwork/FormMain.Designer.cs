namespace HRBFNetwork
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInitialisation = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveNormal = new System.Windows.Forms.CheckBox();
            this.numericUpDownCountNeurons = new System.Windows.Forms.NumericUpDown();
            this.labelCountNeurons = new System.Windows.Forms.Label();
            this.buttonInitialisation = new System.Windows.Forms.Button();
            this.numericUpDownCountCenters = new System.Windows.Forms.NumericUpDown();
            this.labelCountCenters = new System.Windows.Forms.Label();
            this.labelCurrentLearningError = new System.Windows.Forms.Label();
            this.textBoxCurrentLearningError = new System.Windows.Forms.TextBox();
            this.groupBoxLearning = new System.Windows.Forms.GroupBox();
            this.numericUpDownCountEpoch = new System.Windows.Forms.NumericUpDown();
            this.labelCountEpoch = new System.Windows.Forms.Label();
            this.numericUpDownLearningError = new System.Windows.Forms.NumericUpDown();
            this.labelLearningError = new System.Windows.Forms.Label();
            this.numericUpDownLearningCoefficient = new System.Windows.Forms.NumericUpDown();
            this.labelLearningCoefficient = new System.Windows.Forms.Label();
            this.buttonStopLearning = new System.Windows.Forms.Button();
            this.buttonStartLearning = new System.Windows.Forms.Button();
            this.labelCurrentLearningEpoch = new System.Windows.Forms.Label();
            this.textBoxCurrentLearningEpoch = new System.Windows.Forms.TextBox();
            this.chartLearning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelGraphics = new System.Windows.Forms.TableLayoutPanel();
            this.labelTestError = new System.Windows.Forms.Label();
            this.textBoxTestError = new System.Windows.Forms.TextBox();
            this.groupBoxInitialisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCenters)).BeginInit();
            this.groupBoxLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLearning)).BeginInit();
            this.groupBoxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            this.tableLayoutPanelGraphics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInitialisation
            // 
            this.groupBoxInitialisation.Controls.Add(this.checkBoxSaveNormal);
            this.groupBoxInitialisation.Controls.Add(this.numericUpDownCountNeurons);
            this.groupBoxInitialisation.Controls.Add(this.labelCountNeurons);
            this.groupBoxInitialisation.Controls.Add(this.buttonInitialisation);
            this.groupBoxInitialisation.Controls.Add(this.numericUpDownCountCenters);
            this.groupBoxInitialisation.Controls.Add(this.labelCountCenters);
            this.groupBoxInitialisation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInitialisation.Name = "groupBoxInitialisation";
            this.groupBoxInitialisation.Size = new System.Drawing.Size(200, 132);
            this.groupBoxInitialisation.TabIndex = 0;
            this.groupBoxInitialisation.TabStop = false;
            this.groupBoxInitialisation.Text = "Инициализация сети";
            // 
            // checkBoxSaveNormal
            // 
            this.checkBoxSaveNormal.AutoSize = true;
            this.checkBoxSaveNormal.Location = new System.Drawing.Point(9, 79);
            this.checkBoxSaveNormal.Name = "checkBoxSaveNormal";
            this.checkBoxSaveNormal.Size = new System.Drawing.Size(152, 17);
            this.checkBoxSaveNormal.TabIndex = 8;
            this.checkBoxSaveNormal.Text = "Сохранить в новый файл";
            this.checkBoxSaveNormal.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCountNeurons
            // 
            this.numericUpDownCountNeurons.Location = new System.Drawing.Point(138, 49);
            this.numericUpDownCountNeurons.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownCountNeurons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountNeurons.Name = "numericUpDownCountNeurons";
            this.numericUpDownCountNeurons.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownCountNeurons.TabIndex = 4;
            this.numericUpDownCountNeurons.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelCountNeurons
            // 
            this.labelCountNeurons.AutoSize = true;
            this.labelCountNeurons.Location = new System.Drawing.Point(6, 51);
            this.labelCountNeurons.Name = "labelCountNeurons";
            this.labelCountNeurons.Size = new System.Drawing.Size(117, 13);
            this.labelCountNeurons.TabIndex = 3;
            this.labelCountNeurons.Text = "Количество нейронов";
            // 
            // buttonInitialisation
            // 
            this.buttonInitialisation.Location = new System.Drawing.Point(3, 102);
            this.buttonInitialisation.Name = "buttonInitialisation";
            this.buttonInitialisation.Size = new System.Drawing.Size(194, 23);
            this.buttonInitialisation.TabIndex = 1;
            this.buttonInitialisation.Text = "Инициализация";
            this.buttonInitialisation.UseVisualStyleBackColor = true;
            this.buttonInitialisation.Click += new System.EventHandler(this.buttonInitialisation_Click);
            // 
            // numericUpDownCountCenters
            // 
            this.numericUpDownCountCenters.Location = new System.Drawing.Point(138, 24);
            this.numericUpDownCountCenters.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCountCenters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountCenters.Name = "numericUpDownCountCenters";
            this.numericUpDownCountCenters.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownCountCenters.TabIndex = 2;
            this.numericUpDownCountCenters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelCountCenters
            // 
            this.labelCountCenters.AutoSize = true;
            this.labelCountCenters.Location = new System.Drawing.Point(6, 26);
            this.labelCountCenters.Name = "labelCountCenters";
            this.labelCountCenters.Size = new System.Drawing.Size(110, 13);
            this.labelCountCenters.TabIndex = 1;
            this.labelCountCenters.Text = "Количество центров";
            // 
            // labelCurrentLearningError
            // 
            this.labelCurrentLearningError.AutoSize = true;
            this.labelCurrentLearningError.Location = new System.Drawing.Point(6, 24);
            this.labelCurrentLearningError.Name = "labelCurrentLearningError";
            this.labelCurrentLearningError.Size = new System.Drawing.Size(93, 13);
            this.labelCurrentLearningError.TabIndex = 5;
            this.labelCurrentLearningError.Text = "Текущая ошибка";
            // 
            // textBoxCurrentLearningError
            // 
            this.textBoxCurrentLearningError.Location = new System.Drawing.Point(105, 21);
            this.textBoxCurrentLearningError.Name = "textBoxCurrentLearningError";
            this.textBoxCurrentLearningError.ReadOnly = true;
            this.textBoxCurrentLearningError.Size = new System.Drawing.Size(89, 20);
            this.textBoxCurrentLearningError.TabIndex = 6;
            // 
            // groupBoxLearning
            // 
            this.groupBoxLearning.Controls.Add(this.numericUpDownCountEpoch);
            this.groupBoxLearning.Controls.Add(this.labelCountEpoch);
            this.groupBoxLearning.Controls.Add(this.numericUpDownLearningError);
            this.groupBoxLearning.Controls.Add(this.labelLearningError);
            this.groupBoxLearning.Controls.Add(this.numericUpDownLearningCoefficient);
            this.groupBoxLearning.Controls.Add(this.labelLearningCoefficient);
            this.groupBoxLearning.Controls.Add(this.buttonStopLearning);
            this.groupBoxLearning.Controls.Add(this.buttonStartLearning);
            this.groupBoxLearning.Controls.Add(this.labelCurrentLearningEpoch);
            this.groupBoxLearning.Controls.Add(this.textBoxCurrentLearningEpoch);
            this.groupBoxLearning.Controls.Add(this.labelCurrentLearningError);
            this.groupBoxLearning.Controls.Add(this.textBoxCurrentLearningError);
            this.groupBoxLearning.Location = new System.Drawing.Point(218, 12);
            this.groupBoxLearning.Name = "groupBoxLearning";
            this.groupBoxLearning.Size = new System.Drawing.Size(200, 212);
            this.groupBoxLearning.TabIndex = 7;
            this.groupBoxLearning.TabStop = false;
            this.groupBoxLearning.Text = "Обучение";
            // 
            // numericUpDownCountEpoch
            // 
            this.numericUpDownCountEpoch.Location = new System.Drawing.Point(138, 129);
            this.numericUpDownCountEpoch.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCountEpoch.Name = "numericUpDownCountEpoch";
            this.numericUpDownCountEpoch.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownCountEpoch.TabIndex = 17;
            this.numericUpDownCountEpoch.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // labelCountEpoch
            // 
            this.labelCountEpoch.AutoSize = true;
            this.labelCountEpoch.Location = new System.Drawing.Point(6, 133);
            this.labelCountEpoch.Name = "labelCountEpoch";
            this.labelCountEpoch.Size = new System.Drawing.Size(92, 13);
            this.labelCountEpoch.TabIndex = 16;
            this.labelCountEpoch.Text = "Количество эпох";
            // 
            // numericUpDownLearningError
            // 
            this.numericUpDownLearningError.DecimalPlaces = 3;
            this.numericUpDownLearningError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownLearningError.Location = new System.Drawing.Point(138, 100);
            this.numericUpDownLearningError.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            this.numericUpDownLearningError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownLearningError.Name = "numericUpDownLearningError";
            this.numericUpDownLearningError.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownLearningError.TabIndex = 13;
            this.numericUpDownLearningError.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // labelLearningError
            // 
            this.labelLearningError.AutoSize = true;
            this.labelLearningError.Location = new System.Drawing.Point(6, 104);
            this.labelLearningError.Name = "labelLearningError";
            this.labelLearningError.Size = new System.Drawing.Size(96, 13);
            this.labelLearningError.TabIndex = 12;
            this.labelLearningError.Text = "Ошибка обучения";
            // 
            // numericUpDownLearningCoefficient
            // 
            this.numericUpDownLearningCoefficient.DecimalPlaces = 5;
            this.numericUpDownLearningCoefficient.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownLearningCoefficient.Location = new System.Drawing.Point(138, 71);
            this.numericUpDownLearningCoefficient.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            327680});
            this.numericUpDownLearningCoefficient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDownLearningCoefficient.Name = "numericUpDownLearningCoefficient";
            this.numericUpDownLearningCoefficient.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownLearningCoefficient.TabIndex = 11;
            this.numericUpDownLearningCoefficient.Value = new decimal(new int[] {
            2,
            0,
            0,
            262144});
            // 
            // labelLearningCoefficient
            // 
            this.labelLearningCoefficient.AutoSize = true;
            this.labelLearningCoefficient.Location = new System.Drawing.Point(6, 75);
            this.labelLearningCoefficient.Name = "labelLearningCoefficient";
            this.labelLearningCoefficient.Size = new System.Drawing.Size(126, 13);
            this.labelLearningCoefficient.TabIndex = 10;
            this.labelLearningCoefficient.Text = "Коэффициент обучения";
            // 
            // buttonStopLearning
            // 
            this.buttonStopLearning.Enabled = false;
            this.buttonStopLearning.Location = new System.Drawing.Point(2, 183);
            this.buttonStopLearning.Name = "buttonStopLearning";
            this.buttonStopLearning.Size = new System.Drawing.Size(194, 23);
            this.buttonStopLearning.TabIndex = 9;
            this.buttonStopLearning.Text = "Остановить обучение";
            this.buttonStopLearning.UseVisualStyleBackColor = true;
            this.buttonStopLearning.Click += new System.EventHandler(this.buttonStopLearning_Click);
            // 
            // buttonStartLearning
            // 
            this.buttonStartLearning.Enabled = false;
            this.buttonStartLearning.Location = new System.Drawing.Point(2, 155);
            this.buttonStartLearning.Name = "buttonStartLearning";
            this.buttonStartLearning.Size = new System.Drawing.Size(194, 23);
            this.buttonStartLearning.TabIndex = 5;
            this.buttonStartLearning.Text = "Начать обучение";
            this.buttonStartLearning.UseVisualStyleBackColor = true;
            this.buttonStartLearning.Click += new System.EventHandler(this.buttonStartLearning_Click);
            // 
            // labelCurrentLearningEpoch
            // 
            this.labelCurrentLearningEpoch.AutoSize = true;
            this.labelCurrentLearningEpoch.Location = new System.Drawing.Point(6, 53);
            this.labelCurrentLearningEpoch.Name = "labelCurrentLearningEpoch";
            this.labelCurrentLearningEpoch.Size = new System.Drawing.Size(84, 13);
            this.labelCurrentLearningEpoch.TabIndex = 7;
            this.labelCurrentLearningEpoch.Text = "Текущая эпоха";
            // 
            // textBoxCurrentLearningEpoch
            // 
            this.textBoxCurrentLearningEpoch.Location = new System.Drawing.Point(105, 50);
            this.textBoxCurrentLearningEpoch.Name = "textBoxCurrentLearningEpoch";
            this.textBoxCurrentLearningEpoch.ReadOnly = true;
            this.textBoxCurrentLearningEpoch.Size = new System.Drawing.Size(89, 20);
            this.textBoxCurrentLearningEpoch.TabIndex = 8;
            // 
            // chartLearning
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLearning.ChartAreas.Add(chartArea1);
            this.chartLearning.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartLearning.Legends.Add(legend1);
            this.chartLearning.Location = new System.Drawing.Point(3, 3);
            this.chartLearning.Name = "chartLearning";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ошибка обучения";
            this.chartLearning.Series.Add(series1);
            this.chartLearning.Size = new System.Drawing.Size(532, 402);
            this.chartLearning.TabIndex = 8;
            this.chartLearning.Text = "chart1";
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.textBoxOutput);
            this.groupBoxTest.Controls.Add(this.labelOutput);
            this.groupBoxTest.Controls.Add(this.textBoxInput);
            this.groupBoxTest.Controls.Add(this.buttonTest);
            this.groupBoxTest.Controls.Add(this.labelInput);
            this.groupBoxTest.Location = new System.Drawing.Point(424, 12);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(200, 104);
            this.groupBoxTest.TabIndex = 5;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Тестирование сети";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(43, 50);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(151, 20);
            this.textBoxOutput.TabIndex = 18;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(6, 54);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 17;
            this.labelOutput.Text = "Выход";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(43, 22);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(151, 20);
            this.textBoxInput.TabIndex = 16;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(2, 76);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(194, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(6, 26);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Вход";
            // 
            // chartTest
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 2D;
            chartArea2.Name = "ChartArea1";
            this.chartTest.ChartAreas.Add(chartArea2);
            this.chartTest.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTest.Legends.Add(legend2);
            this.chartTest.Location = new System.Drawing.Point(541, 3);
            this.chartTest.Name = "chartTest";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Реальные данные";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Выход сети";
            this.chartTest.Series.Add(series2);
            this.chartTest.Series.Add(series3);
            this.chartTest.Size = new System.Drawing.Size(532, 402);
            this.chartTest.TabIndex = 9;
            this.chartTest.Text = "chart1";
            // 
            // tableLayoutPanelGraphics
            // 
            this.tableLayoutPanelGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGraphics.ColumnCount = 2;
            this.tableLayoutPanelGraphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraphics.Controls.Add(this.chartLearning, 0, 0);
            this.tableLayoutPanelGraphics.Controls.Add(this.chartTest, 1, 0);
            this.tableLayoutPanelGraphics.Location = new System.Drawing.Point(12, 224);
            this.tableLayoutPanelGraphics.Name = "tableLayoutPanelGraphics";
            this.tableLayoutPanelGraphics.RowCount = 1;
            this.tableLayoutPanelGraphics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraphics.Size = new System.Drawing.Size(1076, 408);
            this.tableLayoutPanelGraphics.TabIndex = 10;
            // 
            // labelTestError
            // 
            this.labelTestError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTestError.AutoSize = true;
            this.labelTestError.Location = new System.Drawing.Point(870, 203);
            this.labelTestError.Name = "labelTestError";
            this.labelTestError.Size = new System.Drawing.Size(120, 13);
            this.labelTestError.TabIndex = 18;
            this.labelTestError.Text = "Ошибка тестирования";
            // 
            // textBoxTestError
            // 
            this.textBoxTestError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestError.Location = new System.Drawing.Point(996, 200);
            this.textBoxTestError.Name = "textBoxTestError";
            this.textBoxTestError.ReadOnly = true;
            this.textBoxTestError.Size = new System.Drawing.Size(89, 20);
            this.textBoxTestError.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 644);
            this.Controls.Add(this.labelTestError);
            this.Controls.Add(this.tableLayoutPanelGraphics);
            this.Controls.Add(this.textBoxTestError);
            this.Controls.Add(this.groupBoxTest);
            this.Controls.Add(this.groupBoxLearning);
            this.Controls.Add(this.groupBoxInitialisation);
            this.Name = "FormMain";
            this.Text = "HRBF";
            this.groupBoxInitialisation.ResumeLayout(false);
            this.groupBoxInitialisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCenters)).EndInit();
            this.groupBoxLearning.ResumeLayout(false);
            this.groupBoxLearning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLearning)).EndInit();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            this.tableLayoutPanelGraphics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInitialisation;
        private System.Windows.Forms.NumericUpDown numericUpDownCountCenters;
        private System.Windows.Forms.Label labelCountCenters;
        private System.Windows.Forms.NumericUpDown numericUpDownCountNeurons;
        private System.Windows.Forms.Label labelCountNeurons;
        private System.Windows.Forms.Button buttonInitialisation;
        private System.Windows.Forms.Label labelCurrentLearningError;
        private System.Windows.Forms.TextBox textBoxCurrentLearningError;
        private System.Windows.Forms.GroupBox groupBoxLearning;
        private System.Windows.Forms.Button buttonStopLearning;
        private System.Windows.Forms.Button buttonStartLearning;
        private System.Windows.Forms.Label labelCurrentLearningEpoch;
        private System.Windows.Forms.TextBox textBoxCurrentLearningEpoch;
        private System.Windows.Forms.NumericUpDown numericUpDownLearningError;
        private System.Windows.Forms.Label labelLearningError;
        private System.Windows.Forms.NumericUpDown numericUpDownLearningCoefficient;
        private System.Windows.Forms.Label labelLearningCoefficient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLearning;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.CheckBox checkBoxSaveNormal;
        private System.Windows.Forms.NumericUpDown numericUpDownCountEpoch;
        private System.Windows.Forms.Label labelCountEpoch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGraphics;
        private System.Windows.Forms.Label labelTestError;
        private System.Windows.Forms.TextBox textBoxTestError;
    }
}

