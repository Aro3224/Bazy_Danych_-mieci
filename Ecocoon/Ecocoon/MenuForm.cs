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
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Configuration;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel.Design;
using System.IO;

namespace Ecocoon
{
    public partial class MenuForm : Form
    {
        private string dane;
        private int department;
        public MenuForm(string email, int department)
        {
            InitializeComponent();
            pnl_edycja_danych.Visible = true;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_edit_segregacja.Visible = false;

            dane = email;
            this.department = department;
            account_Text(dane);

            if(department != 1)
            {
                btn_edycja_danych.Visible = false;
                btn_raport_odp.Visible = false;
                btn_raport_prac.Visible = false;
            }
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
            pnl_Blank.Visible = false;
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
            pnl_Blank.Visible = false;
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
            btn_anuluj.Visible = false;
            btn_dodaj.Visible = false;
            pnl_Blank.Visible = false;
            textBox_FilePath.Visible= false;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Department FROM Users WHERE Email = @Email;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query2 = "SELECT FileID,FileName,Extension FROM Files";
                SqlDataAdapter adp = new SqlDataAdapter(query2, connection);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dGVFilesList.DataSource = dt;
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Email", dane);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        int departmentID = reader.GetInt32(0);

                        switch (departmentID)
                        {
                            case 1:
                                btn_dodaj_plik.Visible = true;
                                break;
                            default:
                                btn_dodaj_plik.Visible = false;
                                break;
                        }
                    }
                }
                connection.Close();
            }
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
            pnl_Blank.Visible = false;
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
            pnl_Blank.Visible = false;

            pnl_edit_admin.Visible = false;
            pnl_edit_kierowcy.Visible = false;
            pnl_edit_smieciarze.Visible = false;
            pnl_edit_odbior.Visible = false;
            pnl_edit_segregacja.Visible = false;
            pnl_edit_truck.Visible = false;
            pnl_create_schedule.Visible = false;
            pnl_create_team.Visible = false;
            pnl_edit_team.Visible = false;
        }

        private void btn_new_acc_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = true;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = false;
            pnl_edit_truck.Visible = false;
            pnl_edit_truck.Visible = false;
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

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, Email FROM Users WHERE Department = 1 AND Active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    widok_administracja.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void smieciarze_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = true;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
            pnl_Blank.Visible = false;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, Email FROM Users WHERE Department = 2 AND Active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    widok_smieciarze.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void kierowcy_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = true;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = false;
            pnl_Blank.Visible = false;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, Email FROM Users WHERE Department = 3 AND Active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    widok_kierowcy.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void pnl_kierowcy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            SqlConnection con = new SqlConnection($"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True");        
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";

            string selectQuery = "SELECT Email FROM Users WHERE Email = @addEmail";

            if (txt_add_email.Text == "")
            {
                MessageBox.Show("Musisz wprowadzić email");
                return;
            }

            int department;
            switch (true)
            {
                case bool _ when checkbox_admin.Checked:
                    department = 1;
                    break;
                case bool _ when checkbox_smieciarz.Checked:
                    department = 2;
                    break;
                case bool _ when checkbox_kierowca.Checked:
                    department = 3;
                    break;
                case bool _ when checkbox_odbior.Checked:
                    department = 4;
                    break;
                case bool _ when checkbox_segregacja.Checked:
                    department = 5;
                    break;

                default:
                    MessageBox.Show("Musisz zaznaczyć wydział.");
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
                        string insertQuery = $"INSERT INTO Users (Email, Department) VALUES ('{txt_add_email.Text}', {department})";
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
                checkbox_smieciarz.Checked = false;
                checkbox_kierowca.Checked = false;
                checkbox_odbior.Checked = false;
                checkbox_segregacja.Checked = false;
            }
        }

        private void checkbox_user_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_smieciarz.Checked)
            {
                checkbox_admin.Checked = false;
                checkbox_kierowca.Checked = false;
                checkbox_odbior.Checked = false;
                checkbox_segregacja.Checked = false;
            }
        }

        private void checkbox_kierowca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_kierowca.Checked)
            {
                checkbox_admin.Checked = false;
                checkbox_smieciarz.Checked = false;
                checkbox_odbior.Checked = false;
                checkbox_segregacja.Checked = false;
            }
        }

        private void checkbox_odbior_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_odbior.Checked)
            {
                checkbox_admin.Checked = false;
                checkbox_smieciarz.Checked = false;
                checkbox_kierowca.Checked = false;
                checkbox_segregacja.Checked = false;
            }
        }

        private void checkbox_segregacja_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_segregacja.Checked)
            {
                checkbox_admin.Checked = false;
                checkbox_smieciarz.Checked = false;
                checkbox_kierowca.Checked = false;
                checkbox_odbior.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //button odbiór
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = true;
            pnl_segregacja.Visible = false;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, Email FROM Users WHERE Department = 4 AND Active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    widok_odbior.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //button segregacja
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_odbiór.Visible = false;
            pnl_segregacja.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, Email FROM Users WHERE Department = 5 AND Active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    widok_segregacja.DataSource = dataTable;

                    connection.Close();
                }
            }
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

        private void btn_edit_harmonogram_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = true;
            pnl_Blank.Visible = false;
            pnl_edit_truck.Visible = false;
        }

        private void btn_edit_truck_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = false;
            pnl_edit_harmonogram.Visible = false;
            pnl_edit_truck.Visible = false;
            pnl_edit_truck.Visible = true;
        }

        private void btn_raport_odp_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = true;
            pnl_new_raport.Visible = false;
            pnl_show_raport.Visible = false;
            pnl_print_raport.Visible = false;
            pnl_account.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_Blank.Visible = false;
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
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string selectQuery = "SELECT UserID, Completed FROM Users_add_info WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", labelUserID.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bool isCompleted = reader.GetBoolean(1);

                        if (isCompleted)
                        {
                            btn_edit.Visible = false;
                        }
                        else
                        {
                            btn_edit.Visible = true;
                        }
                    }
                }
            }
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
            pnl_account.Visible = true;
            pnl_druki_pliki.Visible = false;
            txt_data_uro.Visible = false;
            txt_nr_konta.Visible = false;
            txt_nr_tel.Visible = false;
            txt_adres.Visible = false;

            btn_save_changes.Visible = false;
            btn_decline_changes.Visible = false;
            pnl_Blank.Visible = false;
        }

        private void account_Text(string dane)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            SqlConnection connection = new SqlConnection($"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True");
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

                //userID
                SqlCommand commandID = new SqlCommand("SELECT UserID FROM Users WHERE Email = @email", connection);
                commandID.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = commandID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int liczba = reader.GetInt32(0);
                        string userID = liczba.ToString();
                        labelUserID.Text = userID;
                        labelUserID.Visible = false;
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

                //label wydzial
                SqlCommand command4 = new SqlCommand("SELECT d.Name FROM Users u INNER JOIN Departments d on u.Department = d.ID_Department where u.Email = @email", connection);
                command4.Parameters.AddWithValue("@email", dane);

                using (SqlDataReader reader = command4.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Wydzial = reader.GetString(0);
                        wydzial.Text = Wydzial;
                    }
                }

                //label data urodzenia
                string str = labelUserID.Text;
                int UserID = int.Parse(str);
                SqlCommand command5 = new SqlCommand("SELECT Birth_date FROM Users_add_info WHERE UserID = @userid", connection);
                command5.Parameters.AddWithValue("@userid", UserID);
                using (SqlDataReader reader = command5.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime dataurodzienia = reader.GetDateTime(0);
                        string Data = dataurodzienia.ToString();
                        Data = Data.Substring(0, 10);
                        data_uro.Text = Data;
                    }
                }

                //label numer konta
                SqlCommand command6 = new SqlCommand("SELECT Bank_tran_det FROM Users_add_info WHERE UserID = @userid", connection);
                command6.Parameters.AddWithValue("@userid", UserID);

                using (SqlDataReader reader = command6.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nrkonta = reader.GetString(0);
                        nr_konta.Text = nrkonta;
                    }
                }

                //label numer telefonu
                SqlCommand command7 = new SqlCommand("SELECT Phone_num FROM Users_add_info WHERE UserID = @userid", connection);
                command7.Parameters.AddWithValue("@userid", UserID);

                using (SqlDataReader reader = command7.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nrtelefonu = reader.GetString(0);
                        nr_tel.Text = nrtelefonu;
                    }
                }

                //label adres
                SqlCommand command8 = new SqlCommand("SELECT Domicile FROM Users_add_info WHERE UserID = @userid", connection);
                command8.Parameters.AddWithValue("@userid", UserID);

                using (SqlDataReader reader = command8.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string adreszam = reader.GetString(0);
                        adres.Text = adreszam;
                    }
                }

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            data_uro.Visible = false;
            nr_konta.Visible = false;
            nr_tel.Visible = false;
            adres.Visible = false;

            txt_data_uro.Text = data_uro.Text;
            txt_nr_konta.Text = nr_konta.Text;
            txt_nr_tel.Text = nr_tel.Text;
            txt_adres.Text = adres.Text;

            txt_data_uro.Visible = true;
            txt_nr_konta.Visible = true;
            txt_nr_tel.Visible = true;
            txt_adres.Visible = true;

            btn_edit.Visible = false;
            btn_save_changes.Visible = true;
            btn_decline_changes.Visible = true;
        }

        private void btn_decline_changes_Click(object sender, EventArgs e)
        {
            data_uro.Visible = true;
            nr_konta.Visible = true;
            nr_tel.Visible = true;
            adres.Visible = true;

            txt_data_uro.Visible = false;
            txt_nr_konta.Visible = false;
            txt_nr_tel.Visible = false;
            txt_adres.Visible = false;

            btn_edit.Visible = true;
            btn_save_changes.Visible = false;
            btn_decline_changes.Visible = false;
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            string str = labelUserID.Text;
            int liczba = int.Parse(str);
            string str_nr_konta = txt_nr_konta.Text;
            string str_nr_tel = txt_nr_tel.Text;
            int dlugsc_nr_konta = str_nr_konta.Length;
            int dlugsc_nr_tel = str_nr_tel.Length;
            if (txt_nr_konta.Text == "" || txt_nr_tel.Text == "" || txt_data_uro.Text == "" || txt_adres.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else if (dlugsc_nr_konta != 26 || dlugsc_nr_tel != 9)
            {
                MessageBox.Show("Numer konta lub numer telefonu jest zbyt krótki/długi");
            }
            else
            {
                string UpdateQuery = "INSERT INTO Users_add_info VALUES (@UserID, @Birth_date, @Bank_tran_det, @Phone_num, @Domicile, DEFAULT);";
                string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                SqlConnection connection = new SqlConnection($"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True");
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(UpdateQuery, connection, transaction);

                    try
                    {
                        DateTime birthDate;
                        if (DateTime.TryParseExact(txt_data_uro.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                        {
                            cmd.Parameters.AddWithValue("@UserID", liczba);
                            cmd.Parameters.AddWithValue("@Birth_date", birthDate);
                            cmd.Parameters.AddWithValue("@Bank_tran_det", txt_nr_konta.Text);
                            cmd.Parameters.AddWithValue("@Phone_num", txt_nr_tel.Text);
                            cmd.Parameters.AddWithValue("@Domicile", txt_adres.Text);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show("Dane zostały zaaktualizowane, zaloguj się ponownie");
                            new Form1().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nieprawidłowy format daty. Wprowadź datę w formacie: DD.MM.YYYY.");
                        }
                    }
                    catch (SqlException sqlError)
                    {
                        transaction.Rollback();
                    }
                }
            } 
        }

        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = false;
            pnl_edit_wydzial.Visible = true;
            pnl_edit_harmonogram.Visible = false;
            pnl_edit_truck.Visible = false;
            pnl_edit_truck.Visible = false;
        }

        //edycja smieciarze
        private void btn_edit_smieciarze_Click(object sender, EventArgs e)
        {
            pnl_edit_smieciarze.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT u.UserID, u.Name, u.Surname, u.Email, a.Birth_date, a.Bank_tran_det, a.Phone_num, a.Domicile, a.Completed FROM Users u INNER JOIN Users_add_info a ON u.UserID = a.UserID WHERE u.Department = 2;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_edit_smieciarze.DataSource = dataTable;

                    view_edit_smieciarze.CellValueChanged += new DataGridViewCellEventHandler(view_edit_smieciarze_Update);

                    connection.Close();
                }
            }
            btn_delete_smieciarze.Click += new EventHandler((s, ev) =>
            {
                view_edit_smieciarze.CellValueChanged -= new DataGridViewCellEventHandler(view_edit_smieciarze_Update);
                view_edit_smieciarze.CellClick += new DataGridViewCellEventHandler(view_edit_smieciarze_Delete);
                Tryb_smieciarze.Text = "Usuń";
            });

            btn_smieciarze_edit.Click += new EventHandler((s, ev) =>
            {
                view_edit_smieciarze.CellValueChanged += new DataGridViewCellEventHandler(view_edit_smieciarze_Update);
                view_edit_smieciarze.CellClick -= new DataGridViewCellEventHandler(view_edit_smieciarze_Delete);
                Tryb_smieciarze.Text = "Aktualizuj";
            });

            btn_back_smieciarze.Click += new EventHandler((s, ev) =>
            {
                pnl_edit_smieciarze.Visible = false;
            });
        }
        //edycja uzytkownika - smieciarze
        private void view_edit_smieciarze_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserID = @UserID;";
            string query2 = "UPDATE Users_add_info SET Birth_date = @Birth_date, Bank_tran_det = @Bank_tran_det, Phone_num = @Phone_num, Domicile = @Domicile, Completed = @Completed WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", view_edit_smieciarze.Rows[e.RowIndex].Cells["Name"].Value);
                    command.Parameters.AddWithValue("@Surname", view_edit_smieciarze.Rows[e.RowIndex].Cells["Surname"].Value);
                    command.Parameters.AddWithValue("@Email", view_edit_smieciarze.Rows[e.RowIndex].Cells["Email"].Value);
                    command.Parameters.AddWithValue("@UserID", view_edit_smieciarze.Rows[e.RowIndex].Cells["UserID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", view_edit_smieciarze.Rows[e.RowIndex].Cells["UserID"].Value);
                    command2.Parameters.AddWithValue("@Birth_date", view_edit_smieciarze.Rows[e.RowIndex].Cells["Birth_date"].Value);
                    command2.Parameters.AddWithValue("@Bank_tran_det", view_edit_smieciarze.Rows[e.RowIndex].Cells["Bank_tran_det"].Value);
                    command2.Parameters.AddWithValue("@Phone_num", view_edit_smieciarze.Rows[e.RowIndex].Cells["Phone_num"].Value);
                    command2.Parameters.AddWithValue("@Domicile", view_edit_smieciarze.Rows[e.RowIndex].Cells["Domicile"].Value);
                    command2.Parameters.AddWithValue("@Completed", view_edit_smieciarze.Rows[e.RowIndex].Cells["Completed"].Value);

                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        //usuniecie uzytkownika - smieciarze
        private void view_edit_smieciarze_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                    string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
                    string query = "DELETE FROM Users_add_info WHERE UserID = @UserID";
                    string query2 = "DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", view_edit_smieciarze.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@UserID", view_edit_smieciarze.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Użytkownik został usunięty.", "Usuwanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //edycja kierowcy
        private void btn_edit_kierowcy_Click(object sender, EventArgs e)
        {
            pnl_edit_kierowcy.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT u.UserID, u.Name, u.Surname, u.Email, a.Birth_date, a.Bank_tran_det, a.Phone_num, a.Domicile, a.Completed FROM Users u INNER JOIN Users_add_info a ON u.UserID = a.UserID WHERE u.Department = 3;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_edit_kierowcy.DataSource = dataTable;

                    view_edit_kierowcy.CellValueChanged += new DataGridViewCellEventHandler(view_edit_kierowcy_Update);

                    connection.Close();
                }
            }
            btn_delete_kierowcy.Click += new EventHandler((s, ev) =>
            {
                view_edit_kierowcy.CellValueChanged -= new DataGridViewCellEventHandler(view_edit_kierowcy_Update);
                view_edit_kierowcy.CellClick += new DataGridViewCellEventHandler(view_edit_kierowcy_Delete);
                Tryb_kierowcy.Text = "Usuń";
            });

            btn_kierowcy_edit.Click += new EventHandler((s, ev) =>
            {
                view_edit_kierowcy.CellValueChanged += new DataGridViewCellEventHandler(view_edit_kierowcy_Update);
                view_edit_kierowcy.CellClick -= new DataGridViewCellEventHandler(view_edit_kierowcy_Delete);
                Tryb_kierowcy.Text = "Aktualizuj";
            });

            btn_back_kierowcy.Click += new EventHandler((s, ev) =>
            {
                pnl_edit_kierowcy.Visible = false;
            });
        }
        //edycja uzytkownika - kierowcy
        private void view_edit_kierowcy_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserID = @UserID;";
            string query2 = "UPDATE Users_add_info SET Birth_date = @Birth_date, Bank_tran_det = @Bank_tran_det, Phone_num = @Phone_num, Domicile = @Domicile, Completed = @Completed WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", view_edit_kierowcy.Rows[e.RowIndex].Cells["Name"].Value);
                    command.Parameters.AddWithValue("@Surname", view_edit_kierowcy.Rows[e.RowIndex].Cells["Surname"].Value);
                    command.Parameters.AddWithValue("@Email", view_edit_kierowcy.Rows[e.RowIndex].Cells["Email"].Value);
                    command.Parameters.AddWithValue("@UserID", view_edit_kierowcy.Rows[e.RowIndex].Cells["UserID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", view_edit_kierowcy.Rows[e.RowIndex].Cells["UserID"].Value);
                    command2.Parameters.AddWithValue("@Birth_date", view_edit_kierowcy.Rows[e.RowIndex].Cells["Birth_date"].Value);
                    command2.Parameters.AddWithValue("@Bank_tran_det", view_edit_kierowcy.Rows[e.RowIndex].Cells["Bank_tran_det"].Value);
                    command2.Parameters.AddWithValue("@Phone_num", view_edit_kierowcy.Rows[e.RowIndex].Cells["Phone_num"].Value);
                    command2.Parameters.AddWithValue("@Domicile", view_edit_kierowcy.Rows[e.RowIndex].Cells["Domicile"].Value);
                    command2.Parameters.AddWithValue("@Completed", view_edit_kierowcy.Rows[e.RowIndex].Cells["Completed"].Value);

                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        //usuniecie uzytkownika - kierowcy
        private void view_edit_kierowcy_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                    string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
                    string query = "DELETE FROM Users_add_info WHERE UserID = @UserID";
                    string query2 = "DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", view_edit_kierowcy.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@UserID", view_edit_kierowcy.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Użytkownik został usunięty.", "Usuwanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //edycja odbior
        private void btn_edit_odbior_Click(object sender, EventArgs e)
        {
            pnl_edit_odbior.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT u.UserID, u.Name, u.Surname, u.Email, a.Birth_date, a.Bank_tran_det, a.Phone_num, a.Domicile, a.Completed FROM Users u INNER JOIN Users_add_info a ON u.UserID = a.UserID WHERE u.Department = 4;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_edit_odbior.DataSource = dataTable;

                    view_edit_odbior.CellValueChanged += new DataGridViewCellEventHandler(view_edit_odbior_Update);

                    connection.Close();
                }
            }
            btn_delete_odbior.Click += new EventHandler((s, ev) =>
            {
                view_edit_odbior.CellValueChanged -= new DataGridViewCellEventHandler(view_edit_odbior_Update);
                view_edit_odbior.CellClick += new DataGridViewCellEventHandler(view_edit_odbior_Delete);
                Tryb_odbior.Text = "Usuń";
            });

            btn_odbior_edit.Click += new EventHandler((s, ev) =>
            {
                view_edit_odbior.CellValueChanged += new DataGridViewCellEventHandler(view_edit_odbior_Update);
                view_edit_odbior.CellClick -= new DataGridViewCellEventHandler(view_edit_odbior_Delete);
                Tryb_odbior.Text = "Aktualizuj";
            });

            btn_back_odbior.Click += new EventHandler((s, ev) =>
            {
                pnl_edit_odbior.Visible = false;
            });
        }
        //edycja uzytkownika - odbior
        private void view_edit_odbior_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserID = @UserID;";
            string query2 = "UPDATE Users_add_info SET Birth_date = @Birth_date, Bank_tran_det = @Bank_tran_det, Phone_num = @Phone_num, Domicile = @Domicile, Completed = @Completed WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", view_edit_odbior.Rows[e.RowIndex].Cells["Name"].Value);
                    command.Parameters.AddWithValue("@Surname", view_edit_odbior.Rows[e.RowIndex].Cells["Surname"].Value);
                    command.Parameters.AddWithValue("@Email", view_edit_odbior.Rows[e.RowIndex].Cells["Email"].Value);
                    command.Parameters.AddWithValue("@UserID", view_edit_odbior.Rows[e.RowIndex].Cells["UserID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", view_edit_odbior.Rows[e.RowIndex].Cells["UserID"].Value);
                    command2.Parameters.AddWithValue("@Birth_date", view_edit_odbior.Rows[e.RowIndex].Cells["Birth_date"].Value);
                    command2.Parameters.AddWithValue("@Bank_tran_det", view_edit_odbior.Rows[e.RowIndex].Cells["Bank_tran_det"].Value);
                    command2.Parameters.AddWithValue("@Phone_num", view_edit_odbior.Rows[e.RowIndex].Cells["Phone_num"].Value);
                    command2.Parameters.AddWithValue("@Domicile", view_edit_odbior.Rows[e.RowIndex].Cells["Domicile"].Value);
                    command2.Parameters.AddWithValue("@Completed", view_edit_odbior.Rows[e.RowIndex].Cells["Completed"].Value);

                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        //usuniecie uzytkownika - odbior
        private void view_edit_odbior_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                    string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
                    string query = "DELETE FROM Users_add_info WHERE UserID = @UserID";
                    string query2 = "DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", view_edit_odbior.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@UserID", view_edit_odbior.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Użytkownik został usunięty.", "Usuwanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //edycja segregacja
        private void btn_edit_seg_Click(object sender, EventArgs e)
        {
            pnl_edit_segregacja.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT u.UserID, u.Name, u.Surname, u.Email, a.Birth_date, a.Bank_tran_det, a.Phone_num, a.Domicile, a.Completed FROM Users u INNER JOIN Users_add_info a ON u.UserID = a.UserID WHERE u.Department = 5;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_edit_segregacja.DataSource = dataTable;

                    view_edit_segregacja.CellValueChanged += new DataGridViewCellEventHandler(view_edit_segregacja_Update);

                    connection.Close();
                }
            }
            btn_delete_segregacja.Click += new EventHandler((s, ev) =>
            {
                view_edit_segregacja.CellValueChanged -= new DataGridViewCellEventHandler(view_edit_segregacja_Update);
                view_edit_segregacja.CellClick += new DataGridViewCellEventHandler(view_edit_segregacja_Delete);
                Tryb_segregacja.Text = "Usuń";
            });

            btn_edit_segregacja.Click += new EventHandler((s, ev) =>
            {
                view_edit_segregacja.CellValueChanged += new DataGridViewCellEventHandler(view_edit_segregacja_Update);
                view_edit_segregacja.CellClick -= new DataGridViewCellEventHandler(view_edit_segregacja_Delete);
                Tryb_segregacja.Text = "Aktualizuj";
            });

            btn_back_segregacja.Click += new EventHandler((s, ev) =>
            {
                pnl_edit_segregacja.Visible = false;
            });
        }
        //edycja uzytkownika - segregacja
        private void view_edit_segregacja_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserID = @UserID;";
            string query2 = "UPDATE Users_add_info SET Birth_date = @Birth_date, Bank_tran_det = @Bank_tran_det, Phone_num = @Phone_num, Domicile = @Domicile, Completed = @Completed WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", view_edit_segregacja.Rows[e.RowIndex].Cells["Name"].Value);
                    command.Parameters.AddWithValue("@Surname", view_edit_segregacja.Rows[e.RowIndex].Cells["Surname"].Value);
                    command.Parameters.AddWithValue("@Email", view_edit_segregacja.Rows[e.RowIndex].Cells["Email"].Value);
                    command.Parameters.AddWithValue("@UserID", view_edit_segregacja.Rows[e.RowIndex].Cells["UserID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", view_edit_segregacja.Rows[e.RowIndex].Cells["UserID"].Value);
                    command2.Parameters.AddWithValue("@Birth_date", view_edit_segregacja.Rows[e.RowIndex].Cells["Birth_date"].Value);
                    command2.Parameters.AddWithValue("@Bank_tran_det", view_edit_segregacja.Rows[e.RowIndex].Cells["Bank_tran_det"].Value);
                    command2.Parameters.AddWithValue("@Phone_num", view_edit_segregacja.Rows[e.RowIndex].Cells["Phone_num"].Value);
                    command2.Parameters.AddWithValue("@Domicile", view_edit_segregacja.Rows[e.RowIndex].Cells["Domicile"].Value);
                    command2.Parameters.AddWithValue("@Completed", view_edit_segregacja.Rows[e.RowIndex].Cells["Completed"].Value);

                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        //usuniecie uzytkownika - segregacja
        private void view_edit_segregacja_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                    string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
                    string query = "DELETE FROM Users_add_info WHERE UserID = @UserID";
                    string query2 = "DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", view_edit_segregacja.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@UserID", view_edit_segregacja.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Użytkownik został usunięty.", "Usuwanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //edycja admin
        private void btn_edit_admin_Click(object sender, EventArgs e)
        {
            pnl_edit_admin.Visible = true;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT u.UserID, u.Name, u.Surname, u.Email, a.Birth_date, a.Bank_tran_det, a.Phone_num, a.Domicile, a.Completed FROM Users u INNER JOIN Users_add_info a ON u.UserID = a.UserID WHERE u.Department = 1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_edit_admin.DataSource = dataTable;

                    view_edit_admin.CellValueChanged += new DataGridViewCellEventHandler(view_edit_admin_Update);
                    
                    connection.Close();
                }
            }
            btn_delete.Click += new EventHandler((s, ev) =>
            {
                view_edit_admin.CellValueChanged -= new DataGridViewCellEventHandler(view_edit_admin_Update);
                view_edit_admin.CellClick += new DataGridViewCellEventHandler(view_edit_admin_Delete);
                Tryb_admins.Text = "Usuń";
            });

            btn_update_admins.Click += new EventHandler((s, ev) =>
            {
                view_edit_admin.CellValueChanged += new DataGridViewCellEventHandler(view_edit_admin_Update);
                view_edit_admin.CellClick -= new DataGridViewCellEventHandler(view_edit_admin_Delete);
                Tryb_admins.Text = "Aktualizuj";
            });

            btn_admins_back.Click += new EventHandler((s, ev) =>
            {
                pnl_edit_admin.Visible = false;
            });
        }
        //edycja uzytkownika - admin
        private void view_edit_admin_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Email = @Email WHERE UserID = @UserID;";
            string query2 = "UPDATE Users_add_info SET Birth_date = @Birth_date, Bank_tran_det = @Bank_tran_det, Phone_num = @Phone_num, Domicile = @Domicile, Completed = @Completed WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", view_edit_admin.Rows[e.RowIndex].Cells["Name"].Value);
                    command.Parameters.AddWithValue("@Surname", view_edit_admin.Rows[e.RowIndex].Cells["Surname"].Value);
                    command.Parameters.AddWithValue("@Email", view_edit_admin.Rows[e.RowIndex].Cells["Email"].Value);
                    command.Parameters.AddWithValue("@UserID", view_edit_admin.Rows[e.RowIndex].Cells["UserID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", view_edit_admin.Rows[e.RowIndex].Cells["UserID"].Value);
                    command2.Parameters.AddWithValue("@Birth_date", view_edit_admin.Rows[e.RowIndex].Cells["Birth_date"].Value);
                    command2.Parameters.AddWithValue("@Bank_tran_det", view_edit_admin.Rows[e.RowIndex].Cells["Bank_tran_det"].Value);
                    command2.Parameters.AddWithValue("@Phone_num", view_edit_admin.Rows[e.RowIndex].Cells["Phone_num"].Value);
                    command2.Parameters.AddWithValue("@Domicile", view_edit_admin.Rows[e.RowIndex].Cells["Domicile"].Value);
                    command2.Parameters.AddWithValue("@Completed", view_edit_admin.Rows[e.RowIndex].Cells["Completed"].Value);

                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
        //usuniecie uzytkownika - admin
        private void view_edit_admin_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
                    string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
                    string query = "DELETE FROM Users_add_info WHERE UserID = @UserID";
                    string query2 = "DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", view_edit_admin.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@UserID", view_edit_admin.Rows[e.RowIndex].Cells["UserID"].Value);

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Użytkownik został usunięty.", "Usuwanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            btn_anuluj.Visible = true;
            btn_dodaj.Visible = true;
            btn_dodaj_plik.Visible = false;
            btn_zaznacz.Visible = false;
            btn_odznacz.Visible = false;
            btn_pobierz.Visible = false;
            textBox_FilePath.Visible = true;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox_FilePath.Text = dlg.FileName;
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            btn_anuluj.Visible = false;
            btn_dodaj.Visible = false;
            btn_dodaj_plik.Visible = true;
            btn_zaznacz.Visible = true;
            btn_odznacz.Visible = true;
            btn_pobierz.Visible = true;
            textBox_FilePath.Visible = false;
        }


        private void btn_dodaj_Click_1(object sender, EventArgs e)
        {
            btn_anuluj.Visible = false;
            btn_dodaj.Visible = false;
            btn_dodaj_plik.Visible = true;
            btn_zaznacz.Visible = true;
            btn_odznacz.Visible = true;
            btn_pobierz.Visible = true;
            textBox_FilePath.Visible = false;

            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";

            using (Stream stream = File.OpenRead(textBox_FilePath.Text))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(textBox_FilePath.Text).Extension;
                string name = new FileInfo(textBox_FilePath.Text).Name;

                string query = "INSERT INTO Files VALUES (@FileName,@Extension,@File)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@FileName", SqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@Extension", SqlDbType.Char).Value = extn;
                        command.Parameters.Add("@File", SqlDbType.VarBinary).Value = buffer;

                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                    string query2 = "SELECT FileID,FileName,Extension FROM Files";
                    SqlDataAdapter adp = new SqlDataAdapter(query2, connection);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dGVFilesList.DataSource = dt;
                    }
                }
            }
            MessageBox.Show("Zapisano plik.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_Blank.Visible = true;
        }


        private void btn_create_harm_Click(object sender, EventArgs e)
        {
            pnl_create_schedule.Visible = true;
        }

        private void btn_back_cs_Click(object sender, EventArgs e)
        {
            pnl_create_schedule.Visible = false;
        }


        //tu kodzik do tworzenia harmonogramu

        private void btn_create_team_Click(object sender, EventArgs e)
        {
            pnl_create_team.Visible = true;
        }

        private void btn_back_team_Click(object sender, EventArgs e)
        {
            pnl_create_team.Visible = false;
        }

        private void btn_kierowcy_Click(object sender, EventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, UserID FROM Users WHERE Department = 3 AND Active = 1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_create_team.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void btn_odbior_Click(object sender, EventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, UserID FROM Users WHERE Department = 2 AND Active = 1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_create_team.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void btn_teams_Click(object sender, EventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT CONCAT(u_kierowca.Name, ' ', u_kierowca.Surname) AS Kierowca, CONCAT(u_smieciarz1.Name, ' ', u_smieciarz1.Surname) AS Smieciarz1, CONCAT(u_smieciarz2.Name, ' ', u_smieciarz2.Surname) AS Smieciarz2, COALESCE(t.RegNumber, 'Numer rejestracyjny') AS Rejestracja FROM Truck t LEFT JOIN Users u_kierowca ON u_kierowca.UserID = t.KierowcaID AND u_kierowca.Department = 3 LEFT JOIN Users u_smieciarz1 ON u_smieciarz1.UserID = t.Odbiorca1ID AND u_smieciarz1.Department = 2 LEFT JOIN Users u_smieciarz2 ON u_smieciarz2.UserID = t.Odbiorca2ID AND u_smieciarz2.Department = 2;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_create_team.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void btn_creatTeam_Click(object sender, EventArgs e)
        {
            string InsertQuery = "INSERT INTO Truck (KierowcaID, Odbiorca1ID, Odbiorca2ID, RegNumber) VALUES (@kierowcaID, @smieciarz1ID, @smieciarz2ID, @numerRejest);";
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            SqlConnection connection = new SqlConnection($"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True");
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand cmd = new SqlCommand(InsertQuery, connection, transaction);

                try
                {
                        cmd.Parameters.AddWithValue("@kierowcaID", txt_kierowca.Text);
                        cmd.Parameters.AddWithValue("@smieciarz1ID", txt_smieciarz_1.Text);
                        cmd.Parameters.AddWithValue("@smieciarz2ID", txt_smieciarz_2.Text);
                        cmd.Parameters.AddWithValue("@numerRejest", txt_nr_rejestr.Text);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Zespół został stworzony");
                }
                catch (SqlException sqlError)
                {
                    transaction.Rollback();
                    MessageBox.Show("Wprowadziłeś błędne dane");
                }
            }
        }

        private void btn_edit_team_Click(object sender, EventArgs e)
        {
            pnl_edit_team.Visible = true;
        }

        private void btn_back_editTeam_Click(object sender, EventArgs e)
        {
            pnl_edit_team.Visible = false;
            view_showTeam.Visible = false;
            view_editTeam.Visible = true;
        }

        private void btn_kierowcy_editTeam_Click(object sender, EventArgs e)
        {
            view_showTeam.Visible = true;
            view_editTeam.Visible = false;
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, UserID FROM Users WHERE Department = 3;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_showTeam.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void btn_smieciarze_editTeam_Click(object sender, EventArgs e)
        {
            view_showTeam.Visible = true;
            view_editTeam.Visible = false;
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT Name, Surname, UserID FROM Users WHERE Department = 2;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_showTeam.DataSource = dataTable;

                    connection.Close();
                }
            }
        }

        private void btn_teams_editTeam_Click(object sender, EventArgs e)
        {
            view_showTeam.Visible = false;
            view_editTeam.Visible = true;
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "SELECT COALESCE(TruckID,'id ciezarowki') AS TruckID, COALESCE(KierowcaID,'Kierowca') AS Kierowca, COALESCE(Odbiorca1ID,'Śmieciarz nr.1') AS Smieciarz, COALESCE(Odbiorca2ID,'Śmieciarz nr.2') AS Smieciarz2, COALESCE(RegNumber,'Numer rejestracyjny') AS Rejestracja FROM Truck;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    view_editTeam.DataSource = dataTable;

                    view_editTeam.CellValueChanged += new DataGridViewCellEventHandler(view_edit_team_Update);

                    connection.Close();
                }
            }
        }
        //edycja zespołów
        private void view_edit_team_Update(object sender, DataGridViewCellEventArgs e)
        {
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string connectionString = $"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string query = "UPDATE Truck SET KierowcaID = @kierowca, Odbiorca1ID = @odbiorca1, Odbiorca2ID = @odbiorca2, RegNumber = @rejestracja WHERE TruckID = @TruckID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kierowca", view_editTeam.Rows[e.RowIndex].Cells["Kierowca"].Value);
                    command.Parameters.AddWithValue("@odbiorca1", view_editTeam.Rows[e.RowIndex].Cells["Smieciarz"].Value);
                    command.Parameters.AddWithValue("@odbiorca2", view_editTeam.Rows[e.RowIndex].Cells["Smieciarz2"].Value);
                    command.Parameters.AddWithValue("@rejestracja", view_editTeam.Rows[e.RowIndex].Cells["Rejestracja"].Value);
                    command.Parameters.AddWithValue("@TruckID", view_editTeam.Rows[e.RowIndex].Cells["TruckID"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        private void checkBox_seg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_seg.Checked)
            {
                checkBox_nieseg.Checked = false;
            }
        }

        private void checkBox_nieseg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nieseg.Checked)
            {
                checkBox_seg.Checked = false;
            }
        }

        private void btn_create_schedule_Click(object sender, EventArgs e)
        {
            int rodzajsmieci;
            switch (true)
            {
                case bool _ when checkBox_seg.Checked:
                    rodzajsmieci = 1;
                    break;
                case bool _ when checkBox_nieseg.Checked:
                    rodzajsmieci = 2;
                    break;

                default:
                    MessageBox.Show("Musisz zaznaczyć rodzaj śmieci.");
                    return;
            }

            string InsertQuery = "";
            string serverAddress = ConfigurationManager.AppSettings["ServerAddress"];
            SqlConnection connection = new SqlConnection($"Data Source={serverAddress};Initial Catalog=DatabaseSmieci;Integrated Security=True");
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand cmd = new SqlCommand(InsertQuery, connection, transaction);

                try
                {
                    cmd.Parameters.AddWithValue("@kierowcaID", txt_kierowca.Text);
                    cmd.Parameters.AddWithValue("@smieciarz1ID", txt_smieciarz_1.Text);
                    cmd.Parameters.AddWithValue("@smieciarz2ID", txt_smieciarz_2.Text);
                    cmd.Parameters.AddWithValue("@numerRejest", txt_nr_rejestr.Text);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Harmonogram został stworzony");
                }
                catch (SqlException sqlError)
                {
                    transaction.Rollback();
                    MessageBox.Show("Wprowadziłeś błędne dane");
                }
            }
        }
    }
}
