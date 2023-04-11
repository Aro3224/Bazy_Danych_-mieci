namespace Ecocoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_user.Text == "elo" && txt_pswd.Text == "siema")
            {
                new MenuForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Adres Email lub has³o s¹ niepoprawne, spróbuj ponownie");
                txt_user.Clear();
                txt_pswd.Clear();
                txt_user.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pswd_TextChanged(object sender, EventArgs e)
        {
            if (ShowPswd.Checked)
            {
                txt_pswd.PasswordChar = '\0';
            }
            else
            {
                txt_pswd.PasswordChar = '•';
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}