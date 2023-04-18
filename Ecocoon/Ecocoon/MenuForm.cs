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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_harmonogramy_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
        }

        private void btn_wydzialy_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
        }

        private void btn_druki_pliki_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = false;
        }

        private void btn_edycja_danych_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = true;
            pnl_add_acc.Visible = false;
        }

        private void btn_new_acc_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = true;
        }
    }
}
