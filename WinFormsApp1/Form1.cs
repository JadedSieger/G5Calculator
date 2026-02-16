namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operationPressed)
                txtDisplay.Clear();

            operationPressed = false;

            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstNumber = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            operationPressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "x":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }

            txtDisplay.Text = result.ToString();
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
                txtDisplay.Text = (double.Parse(txtDisplay.Text) * -1).ToString();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (value / 100).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}
