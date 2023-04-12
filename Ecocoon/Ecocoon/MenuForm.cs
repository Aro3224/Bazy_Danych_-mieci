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
            pnl_edycja_danych.Visible= false;
            pnl_harmonogramy.Visible= false;
            pnl_wydzialy.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_wydzialy.Visible = true;
            pnl_harmonogramy.Visible = false;
            pnl_edycja_danych.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_harmonogramy.Visible = true;
            pnl_wydzialy.Visible = false;
            pnl_edycja_danych.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnl_edycja_danych.Visible = true;
            pnl_harmonogramy.Visible = false;
            pnl_wydzialy.Visible = false;
            pnl_add_acc.Visible = false;
        }

        private void button_new_acc_Click(object sender, EventArgs e)
        {
            pnl_add_acc.Visible = true;
        }
    }
}
