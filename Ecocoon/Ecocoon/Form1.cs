﻿using Microsoft.Win32;
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
            /*
            string connectionString = @"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True";
            string selectQuery = "SELECT Email FROM Administrators WHERE Email = '" + txt_user.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("'" + txt_user.Text + "'", txt_user.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string wartoscZBazy = reader.GetString(0);
                            if (wartoscZBazy == txt_user.Text)
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
                    }
                    else
                    {
                        // wartość nie została znaleziona w bazie danych
                    }

                    connection.Close();
                }
            }
            */
            if (txt_user.Text == "elo" && txt_pswd.Text == "siema")
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowsPswd_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txt_pswd_TextChanged_1(object sender, EventArgs e)
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
