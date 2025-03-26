namespace TrigonometricFunctions
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            comboBoxFunctions = new ComboBox();
            comboBoxUnits = new ComboBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonPlot = new Button();
            buttonSaveToFile = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFunctions
            // 
            comboBoxFunctions.FormattingEnabled = true;
            comboBoxFunctions.Location = new Point(32, 35);
            comboBoxFunctions.Name = "comboBoxFunctions";
            comboBoxFunctions.Size = new Size(151, 28);
            comboBoxFunctions.TabIndex = 0;
            // 
            // comboBoxUnits
            // 
            comboBoxUnits.FormattingEnabled = true;
            comboBoxUnits.Location = new Point(32, 81);
            comboBoxUnits.Name = "comboBoxUnits";
            comboBoxUnits.Size = new Size(151, 28);
            comboBoxUnits.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(32, 125);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(32, 176);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 3;
            // 
            // buttonPlot
            // 
            buttonPlot.Location = new Point(32, 300);
            buttonPlot.Name = "buttonPlot";
            buttonPlot.Size = new Size(129, 68);
            buttonPlot.TabIndex = 4;
            buttonPlot.Text = "Построение графика";
            buttonPlot.UseVisualStyleBackColor = true;
            buttonPlot.Click += buttonPlot_Click;
            // 
            // buttonSaveToFile
            // 
            buttonSaveToFile.Location = new Point(32, 226);
            buttonSaveToFile.Name = "buttonSaveToFile";
            buttonSaveToFile.Size = new Size(129, 68);
            buttonSaveToFile.TabIndex = 5;
            buttonSaveToFile.Text = "Сохранение в файл ";
            buttonSaveToFile.UseVisualStyleBackColor = true;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(369, 35);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(375, 375);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(32, 374);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(129, 68);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справочная информация";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(chartFunction);
            Controls.Add(buttonSaveToFile);
            Controls.Add(buttonPlot);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(comboBoxUnits);
            Controls.Add(comboBoxFunctions);
            Name = "Form1";
            Text = "Главная форма";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFunctions;
        private ComboBox comboBoxUnits;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Button buttonPlot;
        private Button buttonSaveToFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonHelp;
    }
}
