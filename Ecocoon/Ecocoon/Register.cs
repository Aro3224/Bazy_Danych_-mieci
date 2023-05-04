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
                string selectQuery = "SELECT Email FROM Administrators WHERE Email = @formEmail";
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
                                if (emailzbazy == txt_email.Text)
                                {
                                    if(txt_pswd.Text!=null)
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
            string UpdateQuery = "Update Administrators Set Password = @Psswd, Name = @Name, Surname = @Surname WHERE Email = @email";
    
            using (SqlConnection updateConnection = new SqlConnection(connectionString))
            {
                updateConnection.Open();
                SqlTransaction transaction = updateConnection.BeginTransaction();
                SqlCommand cmd = new SqlCommand(UpdateQuery, updateConnection, transaction);

                try
                {
                    cmd.Parameters.AddWithValue("@Psswd", txt_pswd.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Surname", txt_surname.Text);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Rejestracja przebiegła pomyślnie");
                    new MenuForm().Show();
                    this.Hide();
                }
                catch (SqlException sqlError)
                {
                    transaction.Rollback();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.Hide();
        }
    }
}
