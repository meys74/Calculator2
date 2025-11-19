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
        char islem;
        private void button10_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '*';

            textBoxCalc.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "1";

            say2 = Convert.ToInt32(textBoxCalc.Text);

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            say1 = say2;
            islem = '+';

            textBoxCalc.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case '+':
                    sonuc = say1 + say2;
                    textBoxCalc.Text = sonuc.ToString("F2");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '-':
                    sonuc = say1 - say2;
                    textBoxCalc.Text = sonuc.ToString("F2");

                    say2 = sonuc;
                    islem = '=';
                    break;
                case '*':
                    sonuc = say1 * say2;
                    textBoxCalc.Text = sonuc.ToString("F2");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '/':
                    if(say2 == 0) {
                        textBoxCalc.Text = "Tanimsiz";
                            break;
                    }
                    sonuc = say1 / say2;
                    textBoxCalc.Text = sonuc.ToString("F2");

                    say2 = sonuc;
                    islem = '=';
                    break;

                case '=':
                    textBoxCalc.Text = say2.ToString("F2");
                    break;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "2";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "3";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "4";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "5";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "6";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "7";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "8";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "9";

            say2 = Convert.ToInt32(textBoxCalc.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "0";

            say2 = Convert.ToInt32(textBoxCalc.Text);
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
    }
}
