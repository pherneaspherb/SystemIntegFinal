namespace SystemIntegFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
