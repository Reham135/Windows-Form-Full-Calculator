namespace Calculator
{
    public partial class Form1 : Form
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public char Operator { get; set; }
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var obj = sender as Button;
            textScreen.AppendText(obj.Text);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textScreen.Text);
            Operator = '+';
            textScreen.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textScreen.Text);
            Operator = '-';
            textScreen.Clear();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textScreen.Text);
            Operator = '*';
            textScreen.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textScreen.Text);
            Operator = '/';
            textScreen.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textScreen.Clear();

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(textScreen.Text);
            textScreen.Clear();
            switch (Operator)
            {
                case '+':
                    textScreen.Text = (Num1 + Num2).ToString();
                    break;
                case '-':
                    textScreen.Text = (Num1 - Num2).ToString();
                    break;
                case '*':
                    textScreen.Text = (Num1 * Num2).ToString();
                    break;
                case '/':
                    textScreen.Text = (Num1 / Num2).ToString();
                    break;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textScreen.Text += ".";
        }
    }
}