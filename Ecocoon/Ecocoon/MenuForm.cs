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
        public MenuForm()
        {
            InitializeComponent();
            pnl_edycja_danych.Visible = true;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
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
        }

        private void btn_druki_pliki_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = true;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_druki_pliki.Visible = false;
            pnl_powiadomienia.Visible = false;
            pnl_raport_odp.Visible = false;
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True");

            if (checkbox_admin.Checked && txt_add_email.Text != "") 
            {
                string InsertQuery = "Insert into Users (Email, Role) Values ('" + txt_add_email.Text + "', 1)";
                con.Open();
                SqlCommand cmd = new SqlCommand(InsertQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Użytkownik został dodany.");
            }
            else if (checkbox_user.Checked && txt_add_email.Text != "") 
            {
                string InsertQuery2 = "Insert into Users (Email, Role) Values ('" + txt_add_email.Text + "', 2)";
                con.Open();
                SqlCommand cmd = new SqlCommand(InsertQuery2, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Użytkownik został dodany.");
            }
            else if (!checkbox_admin.Checked && !checkbox_user.Checked)
            {
                MessageBox.Show("Musisz zaznaczyć tylko jedną rolę.");
            }
            else if(txt_add_email.Text == "")
            {
                MessageBox.Show("Musisz wprowadzić email");
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


    }
}
