namespace Calculator2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

        }
        double sonuc = 0;
        double say1 = 0;
        double say2 = 0;
        char islem = '=';
        private void button10_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '*';

            textBoxCalc.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "1";

            say2 = Convert.ToDouble(textBoxCalc.Text);

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '+';

            textBoxCalc.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            if (islem == '^')
            {
                sonuc = Math.Pow(say1, say2);

                say2 = sonuc;

                islem = us;
            }
            else if (islem == '√')
            {
                sonuc = Math.Sqrt(say1);

                say2 = sonuc;

                islem = us;
            }

            switch (islem)
            {
                case '+':
                    sonuc = say1 + say2;
                    textBoxCalc.Text = sonuc.ToString("0.#######");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '-':
                    sonuc = say1 - say2;
                    textBoxCalc.Text = sonuc.ToString("0.#######");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '*':
                    sonuc = say1 * say2;
                    textBoxCalc.Text = sonuc.ToString("0.#######");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '/':
                    if (say2 == 0)
                    {
                        MessageBox.Show("Tanimsiz");
                        textBoxCalc.Text = "";
                        sonuc = 0;
                        say1 = 0;
                        say2 = 0;
                        break;
                    }
                    sonuc = say1 / say2;
                    textBoxCalc.Text = sonuc.ToString("0.#######");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '√':
                    sonuc = say1 + say2;
                    textBoxCalc.Text = sonuc.ToString("0.#######");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '=':
                    textBoxCalc.Text = sonuc.ToString("0.#######");
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "2";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "3";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "4";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "5";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "6";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "7";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "8";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "9";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "0";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '-';

            textBoxCalc.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '/';

            textBoxCalc.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text = "";
            sonuc = 0;
            say1 = 0;
            say2 = 0;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text = "-";
        }

        char us;
        private void btnPower_Click(object sender, EventArgs e)
        {
            say1 = say2;
            us = islem;

            islem = '^';

            textBoxCalc.Text = "";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            say1 = say2;
            us = islem;

            islem = '√';

            textBoxCalc.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += ".";

            say2 = Convert.ToDouble(textBoxCalc.Text);
        }
    }
}
