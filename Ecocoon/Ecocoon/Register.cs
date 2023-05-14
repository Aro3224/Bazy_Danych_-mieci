using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                string connectionString = @"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True";
                //string connectionString = @"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True";
                string selectQuery = "SELECT Email, active FROM Users WHERE Email = @formEmail";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@formEmail", txt_email.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string emailzbazy = reader.GetString(0);
                                bool isActive = reader.GetBoolean(1);

                                if (emailzbazy == txt_email.Text)
                                {
                                    if (isActive)
                                    {
                                        MessageBox.Show("Konto już istnieje");
                                    }
                                    else
                                    {
                                        updateUser(connectionString);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nie można zweryfikować twojego e-maila, spróbuj ponownie lub skontaktuj się z administracją");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nie można zweryfikować twojego e-maila, spróbuj ponownie lub skontaktuj się z administracją");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Podane hasła są różne, Proszę wprowadźić ponownie.");
            }
        }

        private void updateUser(String connectionString)
        {
            string email = txt_email.Text;
            string hashedPassword = HashPassword(txt_pswd.Text);
            string UpdateQuery = "Update Users Set Password = @Psswd, Name = @Name, Surname = @Surname, Active = 1 WHERE Email = @email";
    
            using (SqlConnection updateConnection = new SqlConnection(connectionString))
            {
                updateConnection.Open();
                SqlTransaction transaction = updateConnection.BeginTransaction();
                SqlCommand cmd = new SqlCommand(UpdateQuery, updateConnection, transaction);

                try
                {
                    cmd.Parameters.AddWithValue("@Psswd", hashedPassword);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Surname", txt_surname.Text);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Rejestracja przebiegła pomyślnie");
                    //new MenuForm(email).Show();
                    //this.Hide();
                    get_department(email, connectionString);

                }
                catch (SqlException sqlError)
                {
                    transaction.Rollback();
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
            txt_pswd_TextChanged(sender, e);
            txt_pswd_again_TextChanged(sender, e);
        }

        private void txt_pswd_TextChanged(object sender, EventArgs e)
        {
            if(ShowPswd.Checked)
            {
                txt_pswd.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pswd.UseSystemPasswordChar = true;
            }
        }

        private void txt_pswd_again_TextChanged(object sender, EventArgs e)
        {
            if (ShowPswd.Checked)
            {
                txt_pswd_again.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pswd_again.UseSystemPasswordChar = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void get_department(string email, string connectionString)
        {
            string query = "SELECT Department FROM Users WHERE Email = @email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", txt_email.Text);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int department = Convert.ToInt32(reader["Department"]);
                            email = txt_email.Text;
                            MenuForm widok = new MenuForm(email, department);
                            new MenuForm(email, department).Show();
                            this.Hide();
                        }
                    }
                }
            }

        }
    }
}
