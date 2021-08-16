using System;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class log_in : Form
    {
        public string username, password;

        public log_in()
        {
            InitializeComponent();
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox2.Text;
            password = textBox1.Text;

            if(username == "Nawrin" && password == "180104045")
            {
                this.Hide();
                Grade grade = new Grade(this);
                grade.ShowDialog();
                this.Close();
            }
            else if(username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password!");
            }
            else
            {
                MessageBox.Show("Username and Password didn't match!");
            }
        }
    }
}
