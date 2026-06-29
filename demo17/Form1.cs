using System.Text.RegularExpressions;

namespace demo17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter Username");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Password");
                textBox2.Focus();
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long");
                textBox2.Focus();
                return;
            }

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{5,}$";

            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show(
                    "Password must contain:\n" +
                    "• Minimum 5 characters\n" +
                    "• 1 Uppercase letter\n" +
                    "• 1 Lowercase letter\n" +
                    "• 1 Number\n" +
                    "• 1 Special character");

                textBox2.Focus();
                return;
            }

            MessageBox.Show("Login Successful");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox2.PasswordChar = '*';  // Hide password
            }

        }
    }
}