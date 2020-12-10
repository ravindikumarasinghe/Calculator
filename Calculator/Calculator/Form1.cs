

namespace Calculator
{
    public partial class Form1 : Form 1515551
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtNum1.Text);
            int number2 = int.Parse(txtNum1.Text);
            int ans = number1 + number2;

            txtAns.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtNum1.Text);
            int number2 = int.Parse(txtNum1.Text);

            int ans = number1 - number2;

            txtAns.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtNum1.Text);
            int number2 = int.Parse(txtNum1.Text);

            int ans = number1 * number2;

            txtAns.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtNum1.Text);
            int number2 = int.Parse(txtNum1.Text);

            int ans = number1 / number2;

            txtAns.Text = ans.ToString();
            //output
        }
    }
}
