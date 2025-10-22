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
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value = trackBar1.Value;
            textBox1.Text = value.ToString() + "x";
        }
    }
}
