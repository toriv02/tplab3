namespace lab2task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var measureItems = new string[]
            {
                "�C",
                "�F",
                "�R",
                "K",
            };
            firstTypeComboBox.DataSource = new List<string>(measureItems);
            secondTypeComboBox.DataSource = new List<string>(measureItems);
            anserTypeComboBox.DataSource = new List<string>(measureItems);
        }
        private void valueChanged(object sender, EventArgs e)//����� ����� ��� ��������� ��� ��������
        {
            Calculate();
        }
        private MeasureType GetMeasureType(ComboBox comboBox)//����������� ���� �����������
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "�C":
                    measureType = MeasureType.degC;
                    break;
                case "�F":
                    measureType = MeasureType.degF;
                    break;
                case "�R":
                    measureType = MeasureType.degR;
                    break;
                case "K":
                    measureType = MeasureType.K;
                    break;
                default:
                    measureType = MeasureType.degC;
                    break;
            }
            return measureType;
        }
        private void Calculate()//������ �����������
        {
            if (FirstinputTextBox.Text == "" && SecondinputTextBox.Text == "") return;
            if (FirstinputTextBox.Text == "" || SecondinputTextBox.Text == "") return;
            try
            {
                var firstValue = double.Parse(FirstinputTextBox.Text);
                var secondValue = double.Parse(SecondinputTextBox.Text);
                MeasureType firstType = GetMeasureType(firstTypeComboBox);
                MeasureType secondType = GetMeasureType(secondTypeComboBox);
                MeasureType anserType = GetMeasureType(anserTypeComboBox);
                var sumTemperature = new Temperature(0, MeasureType.degC);

                var firstTemperature = new Temperature(firstValue, firstType);
                var secondTemperature = new Temperature(secondValue, secondType);
                switch (operationComboBox.Text)
                {
                    case "+":
                        sumTemperature = firstTemperature + secondTemperature;
                        break;
                    case "-":
                        sumTemperature = firstTemperature - secondTemperature;
                        break;
                    case "*":
                        sumTemperature = firstTemperature * secondTemperature;
                        break;
                    case "/":
                        sumTemperature = firstTemperature / secondTemperature;
                        break;
                    case "��.":
                        if (firstTemperature > secondTemperature) { OutputTextBox.Text = "1-� ����� ������ 2-��"; }
                        else if (firstTemperature < secondTemperature) { OutputTextBox.Text = "2-� ����� ������ 1-��"; }
                        else { OutputTextBox.Text = "����� �����"; }
                        return;
                    default:
                        return;
                }

                OutputTextBox.Text = sumTemperature.To(anserType).Verbose();
            }
            catch (FormatException)
            {
                MessageBox.Show("������ �������� ������ ����������, ���������� ��� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}