using TrigonometricFunctions.Classes;
using TrigonometricFunctions.Interface;

namespace TrigonometricFunctions
{
    public partial class MainForm : Form
    {
        private Dictionary<string, ITrigonometricFunction> functions;

        public MainForm()
        {
            InitializeComponent();
            
            comboBoxUnits.Items.AddRange(new string[] { "�������", "�������" });
            comboBoxUnits.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functions = new Dictionary<string, ITrigonometricFunction>
            {
                { "Sin", new SinFunction() },
                { "Cos", new CosFunction() },
                { "Tg", new TgFunction() },
                { "Ctg", new CtgFunction() }
            };
            comboBoxFunctions.DataSource = new List<string>(functions.Keys);
        }
        private void buttonPlot_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxStart.Text, out double start) ||
                !double.TryParse(textBoxEnd.Text, out double end) ||
                start >= end)
            {
                MessageBox.Show("������� ���������� ��������!");
                return;
            }

            bool inDegrees = comboBoxUnits.SelectedItem.ToString() == "�������";

            ITrigonometricFunction function = functions[comboBoxFunctions.SelectedItem.ToString()];

            var values = FunctionCalculator.CalculateValues(function, start, end, 1.0, inDegrees);

            GraphPlotter.PlotGraph(chartFunction, values, function.Name);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool inDegrees = comboBoxUnits.SelectedItem.ToString() == "�������";

                ITrigonometricFunction function = functions[comboBoxFunctions.SelectedItem.ToString()];
                var values = FunctionCalculator.CalculateValues(function, double.Parse(textBoxStart.Text), double.Parse(textBoxEnd.Text), 1.0, inDegrees);

                FileExporter.ExportToFile(values, saveFileDialog.FileName);
                MessageBox.Show("���� ������� ��������.");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string selectedFunction = comboBoxFunctions.SelectedItem.ToString();

            // ��������� ����� ������� � �������� ��������� �������
            HelpForm helpForm = new HelpForm(selectedFunction);
            helpForm.ShowDialog();
        }
    }
}
