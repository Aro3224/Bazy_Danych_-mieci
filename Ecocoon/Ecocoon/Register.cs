using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecocoon
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_name.Text == "" || txt_pswd.Text == "" || txt_surname.Text == "" || txt_pswd_again.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else if (txt_pswd.Text == txt_pswd_again.Text)
            {
                //dodanie do bazy
                MessageBox.Show("Rejestracja przebiegła pomyślnie");
                new MenuForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Podane hasła są różne, Proszę wprowadźić ponownie.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void txt_pswd_again_TextChanged(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
