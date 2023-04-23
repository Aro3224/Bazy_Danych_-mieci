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
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_harmonogramy_Click(object sender, EventArgs e)
        {
            pnl_harmonogramy.Visible = true;
            pnl_segregowane.Visible = false;
            pnl_niesegregowane.Visible = false;
            pnl_edycja_danych.Visible = false;
            pnl_wydzialy.Visible = false;
        }

        private void btn_wydzialy_Click(object sender, EventArgs e)
        {
            pnl_wydzialy.Visible = true;
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = false;
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
        }

        private void btn_druki_pliki_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
        }

        private void btn_edycja_danych_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = true;
            pnl_add_acc.Visible = false;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
        }

        private void btn_new_acc_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = true;
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
        }

        private void smieciarze_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = true;
            pnl_kierowcy.Visible = false;
        }

        private void kierowcy_Click(object sender, EventArgs e)
        {
            pnl_administracja.Visible = false;
            pnl_smieciarze.Visible = false;
            pnl_kierowcy.Visible = true;
        }

        private void pnl_kierowcy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-16M54NJ;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FIO40UV;Initial Catalog=DatabaseSmieci;Integrated Security=True");
            string InsertQuery = "Insert into Administrators (Email) Values ('" + txt_add_email.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Użytkownik został dodany.");
        }
    }
}
