using System;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        public Grade(log_in login)
        {
            InitializeComponent();
            label5.Text = login.username;
            label4.Text = login.password;
            label21.Text = login.username + "'s Grade:";
        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox1.Clear();
                }

                else if (Convert.ToInt32(textBox1.Text) > 10)
                {
                    MessageBox.Show("Please enter a number at most 10!");
                    textBox1.Clear();
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox10.Clear();
                }

                else if (Convert.ToInt32(textBox10.Text) > 10)
                {
                    MessageBox.Show("Please enter a number at most 10!");
                    textBox10.Clear();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox4.Clear();
                }

                else if (Convert.ToInt32(textBox4.Text) > 10)
                {
                    MessageBox.Show("Please enter a number at most 10!");
                    textBox4.Clear();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox6.Clear();
                }

                else if (Convert.ToInt32(textBox6.Text) > 10)
                {
                    MessageBox.Show("Please enter a number at most 10!");
                    textBox6.Clear();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox8.Clear();
                }

                else if (Convert.ToInt32(textBox8.Text) > 10)
                {
                    MessageBox.Show("Please enter a number at most 10!");
                    textBox8.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox2.Clear();
                }

                else if (Convert.ToInt32(textBox2.Text) >= 60)
                {
                    MessageBox.Show("Please enter a number at most 59!");
                    textBox2.Clear();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox9.Clear();
                }

                else if (Convert.ToInt32(textBox9.Text) >= 60)
                {
                    MessageBox.Show("Please enter a number at most 59!");
                    textBox9.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox3.Clear();
                }

                else if (Convert.ToInt32(textBox3.Text) >= 60)
                {
                    MessageBox.Show("Please enter a number at most 59!");
                    textBox3.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox5.Clear();
                }

                else if (Convert.ToInt32(textBox5.Text) >= 60)
                {
                    MessageBox.Show("Please enter a number at most 59!");
                    textBox5.Clear();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only!");
                    textBox7.Clear();
                }

                else if (Convert.ToInt32(textBox7.Text) >= 60)
                {
                    MessageBox.Show("Please enter a number at most 59!");
                    textBox7.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours, minutes;

            try
            {
                hours = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox10.Text) +
                            Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox6.Text) +
                            Convert.ToDouble(textBox8.Text);

                minutes = Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox9.Text) +
                            Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text) +
                            Convert.ToDouble(textBox7.Text);

                double totalTime = hours + minutes / 60;

                if (totalTime >= 40)
                {
                    label22.Text = "A";
                }
                else if (totalTime >= 35 && totalTime < 40)
                {
                    label22.Text = "B";
                }
                else if (totalTime >= 30 && totalTime < 35)
                {
                    label22.Text = "C";
                }
                else
                {
                    label22.Text = "D";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill up all the fields!");
            }
        }

    }
}
