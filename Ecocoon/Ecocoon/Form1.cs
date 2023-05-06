using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Ecocoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_user.Text == "admin")
            {
                if (txt_pswd.Text == "admin")
                {
                    new MenuForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Adres Email lub hasło są niepoprawne, spróbuj ponownie");
                    txt_user.Clear();
                    txt_pswd.Clear();
                    txt_user.Focus();
                }
            }

            //string connectionString = @"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string connectionString = @"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True"; 
            string selectQuery = "SELECT Password FROM Users WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Email", txt_user.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                string hashedpassword = HashPassword(txt_pswd.Text);
                                string haslo = reader.GetString(0);
                                if (haslo == hashedpassword)
                                {
                                    new MenuForm().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Adres Email lub hasło są niepoprawne, spróbuj ponownie");
                                    txt_user.Clear();
                                    txt_pswd.Clear();
                                    txt_user.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nie posiadasz konta, zarejestruj się");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adres Email lub hasło są niepoprawne, spróbuj ponownie");
                        txt_user.Clear();
                        txt_pswd.Clear();
                        txt_user.Focus();
                    }
                    
                    connection.Close();
                }
            }
        }

        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void ShowsPswd_CheckedChanged(object sender, EventArgs e)
        {
            txt_pswd_TextChanged_1(sender, e);
        }

        private void txt_pswd_TextChanged_1(object sender, EventArgs e)
        {
            if (ShowPswd.Checked)
            {
                txt_pswd.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pswd.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
