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

namespace Ecocoon
{
    public partial class MenuForm : Form
    {
        public MenuForm(string email)
        {
            InitializeComponent();
            pnl_edycja_danych.Visible = true;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;

            string dane = email;
            account_Text(dane);
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
         
        }
        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btn_harmonogramy_Click(object sender, EventArgs e)
        {
            pnl_harmonogramy.Visible = true;
            pnl_segregowane.Visible = false;
            pnl_niesegregowane.Visible = false;
            pnl_edycja_danych.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_wydzialy_Click(object sender, EventArgs e)
        {
            pnl_wydzialy.Visible = true;
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_druki_pliki_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = true;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_edycja_danych_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = true;
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_new_acc_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = true;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = false;
        }

        private void Segregowane_Click(object sender, EventArgs e)
        {
            pnl_segregowane.Visible = true;
            pnl_niesegregowane.Visible = false;
        }

        private void Niesegregowane_Click(object sender, EventArgs e)
        {
            pnl_niesegregowane.Visible = true;
            pnl_segregowane.Visible = false;
        }

        private void administracja_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = true;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
        }

        private void smieciarze_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = true;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
        }

        private void kierowcy_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = true;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
        }

        private void pnl_kierowcy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            
            //string connectionString = @"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string connectionString = @"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True";
            
            string selectQuery = "SELECT Email FROM Users WHERE Email = @addEmail";

            if (txt_add_email.Text == "")
            {
                MessageBox.Show("Musisz wprowadzić email");
                return;
            }

            int role;
            switch (true)
            {
                case bool _ when checkbox_admin.Checked:
                    role = 1;
                    break;
                case bool _ when checkbox_user.Checked:
                    role = 2;
                    break;
                default:
                    MessageBox.Show("Musisz zaznaczyć rolę.");
                    return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@addEmail", txt_add_email.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Taki e-mail już jest wpisany w bazie");
                    }
                    else
                    {
                        string insertQuery = $"INSERT INTO Users (Email, Role) VALUES ('{txt_add_email.Text}', {role})";
                        try
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Użytkownik został dodany.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void checkbox_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_admin.Checked)
            {
                checkbox_user.Checked = false;
            }
        }

        private void checkbox_user_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_user.Checked)
            {
                checkbox_admin.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //button odbiór
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = true;
            pnl_segregacja.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) //button segregacja
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e) //button odznacz
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           if(pnl_powiadomienia.Visible)
            {
                pnl_powiadomienia.Visible= false;
            }
           else
           {
                pnl_powiadomienia.Visible = true;    
           }
        }

        private void btn_edit_wydzial_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = true;
            pnl_edit_harmonogram.Visible = false;
        }

        private void btn_edit_harmonogram_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = true;
        }

        private void btn_raport_odp_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = true;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = true;
            pnl_new_raport.Visible = false;
            pnl_show_raport.Visible = false;
            pnl_print_raport.Visible = false;
            pnl_account.Visible = false;
        }

        private void btn_new_raport_Click(object sender, EventArgs e)
        {
            pnl_new_raport.Visible = true;
            pnl_show_raport.Visible = false;
            pnl_print_raport.Visible = false;
        }

        private void btn_show_raport_Click(object sender, EventArgs e)
        {
            pnl_new_raport.Visible = false;
            pnl_show_raport.Visible = true;
            pnl_print_raport.Visible = false;
        }

        private void btn_print_raport_Click(object sender, EventArgs e)
        {
            pnl_new_raport.Visible = false;
            pnl_show_raport.Visible = false;
            pnl_print_raport.Visible = true;
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = true;

        }

        private void account_Text(string dane)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Name, Surname FROM Users WHERE Email = @email", connection);
                command.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);
                        string buttonText = firstName + " " + lastName;
                        btn_account.Text = buttonText;
                    }
                }

                //label imie
                SqlCommand command1 = new SqlCommand("SELECT Name FROM Users WHERE Email = @email", connection);
                command1.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Name = reader.GetString(0);
                        imie.Text = Name;
                    }
                }

                //label nazwisko
                SqlCommand command2 = new SqlCommand("SELECT Surname FROM Users WHERE Email = @email", connection);
                command2.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Surname = reader.GetString(0);
                        nazwisko.Text = Surname;
                    }
                }

                //label email
                SqlCommand command3 = new SqlCommand("SELECT Email FROM Users WHERE Email = @email", connection);
                command3.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Email = reader.GetString(0);
                        email.Text = Email;
                    }
                }


            }
        }
    }
}
