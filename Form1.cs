namespace CSharp_Perps_Calculator
{
    public partial class Form1 : Form
    {
        public bool isLongPosition = true; // 默认做多状态
        public int value = 1; // 杠杆数值
        public Form1()
        {
            InitializeComponent();
        }
        private void longbutton_CheckedChanged(object sender, EventArgs e)
        {
            isLongPosition = true;
        }
        private void shortbutton_CheckedChanged(object sender, EventArgs e)
        {
            isLongPosition = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (value > 1 && value <= 100)
            {
                value--;
                textBox1.Text = value.ToString() + "x";
                trackBar1.Value = value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (value >= 1 && value < 100)
            {
                value++;
                textBox1.Text = value.ToString() + "x";
                trackBar1.Value = value;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                trackBar1.Value = 1;
            }
            value = trackBar1.Value;
            textBox1.Text = value.ToString() + "x";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("输入不合法", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double openPrice, closePrice, quantity;
            double.TryParse(textBox2.Text, out openPrice);
            double.TryParse(textBox3.Text, out closePrice);
            double.TryParse(textBox4.Text, out quantity);
            double margin = openPrice * quantity / value;// 计算保证金
            double profitLoss;// 计算盈亏
            if (isLongPosition)
            {
                profitLoss = (closePrice - openPrice) * quantity;
            }
            else
            {
                profitLoss = (openPrice - closePrice) * quantity;
            }
            double returnRate = (margin != 0) ? (profitLoss / margin * 100) : 0; // 计算回报率
            label17.Text = margin.ToString("F2");
            label18.Text = profitLoss.ToString("F2");
            label19.Text = returnRate.ToString("F2");
            if (profitLoss > 0)
            {
                label18.ForeColor = Color.Green;
                label19.ForeColor = Color.Green;
            }
            else
            {
                label18.ForeColor = Color.Red;
                label19.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text.Replace("x", "").Trim();
            if (int.TryParse(input, out int newValue))
            {
                if (newValue >= trackBar1.Minimum && newValue <= trackBar1.Maximum)
                {
                    value = newValue;
                    trackBar1.Value = value;
                    string newText = value.ToString() + "x";
                    if (textBox1.Text != newText)
                    {
                        textBox1.Text = newText;
                        textBox1.SelectionStart = textBox1.Text.Length; // 光标移到末尾
                    }
                }
            }
        }
    }
}
