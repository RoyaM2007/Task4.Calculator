namespace Task4.Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(richTextBox1.Text);
            double result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("0-a bölmək olmaz!");
                    return;
                }

                result = firstNumber / secondNumber;
            }
            listBox1.Items.Add(firstNumber + " " + operation + " " + secondNumber + " = " + result);
            richTextBox1.Text = result.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(richTextBox1.Text);
            operation = "+";
            richTextBox1.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(richTextBox1.Text);
            operation = "-";
            richTextBox1.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(richTextBox1.Text);
            operation = "*";
            richTextBox1.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(richTextBox1.Text);
            operation = "/";
            richTextBox1.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            firstNumber = 0;
            operation = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0,
                    richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
            {
                richTextBox1.Text += ",";
            }

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(richTextBox1.Text);

            if (number < 0)
            {
                MessageBox.Show("Mənfi ədədin kvadrat kökü yoxdur!");
                return;
            }

            double result = Math.Sqrt(number);

            richTextBox1.Text = result.ToString();
            listBox1.Items.Add("√" + number + " = " + result);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(richTextBox1.Text);

            double result = number * number;

            richTextBox1.Text = result.ToString();
            listBox1.Items.Add(number + "² = " + result);
        }
    }
}
