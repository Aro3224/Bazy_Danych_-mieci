namespace Ecocoon
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.btn_harmonogramy = new System.Windows.Forms.Button();
            this.btn_wydzialy = new System.Windows.Forms.Button();
            this.btn_druki_pliki = new System.Windows.Forms.Button();
            this.btn_mail = new System.Windows.Forms.Button();
            this.btn_edycja_danych = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnl_edycja_danych = new System.Windows.Forms.Panel();
            this.pnl_add_acc = new System.Windows.Forms.Panel();
            this.label_add_email = new System.Windows.Forms.Label();
            this.txt_add_email = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new_acc = new System.Windows.Forms.Button();
            this.pnl_left.SuspendLayout();
            this.pnl_up.SuspendLayout();
            this.pnl_edycja_danych.SuspendLayout();
            this.pnl_add_acc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.Green;
            this.pnl_left.Controls.Add(this.btn_edycja_danych);
            this.pnl_left.Controls.Add(this.btn_mail);
            this.pnl_left.Controls.Add(this.btn_druki_pliki);
            this.pnl_left.Controls.Add(this.btn_wydzialy);
            this.pnl_left.Controls.Add(this.btn_harmonogramy);
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(229, 540);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_up
            // 
            this.pnl_up.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_up.Controls.Add(this.button7);
            this.pnl_up.Controls.Add(this.button6);
            this.pnl_up.Location = new System.Drawing.Point(229, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(731, 61);
            this.pnl_up.TabIndex = 1;
            // 
            // btn_harmonogramy
            // 
            this.btn_harmonogramy.FlatAppearance.BorderSize = 0;
            this.btn_harmonogramy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_harmonogramy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_harmonogramy.Image = ((System.Drawing.Image)(resources.GetObject("btn_harmonogramy.Image")));
            this.btn_harmonogramy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_harmonogramy.Location = new System.Drawing.Point(0, 117);
            this.btn_harmonogramy.Name = "btn_harmonogramy";
            this.btn_harmonogramy.Size = new System.Drawing.Size(229, 47);
            this.btn_harmonogramy.TabIndex = 0;
            this.btn_harmonogramy.Text = "   Harmonogramy";
            this.btn_harmonogramy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_harmonogramy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_harmonogramy.UseVisualStyleBackColor = true;
            this.btn_harmonogramy.Click += new System.EventHandler(this.btn_harmonogramy_Click);
            // 
            // btn_wydzialy
            // 
            this.btn_wydzialy.FlatAppearance.BorderSize = 0;
            this.btn_wydzialy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wydzialy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_wydzialy.Image = ((System.Drawing.Image)(resources.GetObject("btn_wydzialy.Image")));
            this.btn_wydzialy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_wydzialy.Location = new System.Drawing.Point(0, 170);
            this.btn_wydzialy.Name = "btn_wydzialy";
            this.btn_wydzialy.Size = new System.Drawing.Size(229, 47);
            this.btn_wydzialy.TabIndex = 1;
            this.btn_wydzialy.Text = "   Wydziały";
            this.btn_wydzialy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_wydzialy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_wydzialy.UseVisualStyleBackColor = true;
            this.btn_wydzialy.Click += new System.EventHandler(this.btn_wydzialy_Click);
            // 
            // btn_druki_pliki
            // 
            this.btn_druki_pliki.FlatAppearance.BorderSize = 0;
            this.btn_druki_pliki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_druki_pliki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_druki_pliki.Image = ((System.Drawing.Image)(resources.GetObject("btn_druki_pliki.Image")));
            this.btn_druki_pliki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_druki_pliki.Location = new System.Drawing.Point(0, 223);
            this.btn_druki_pliki.Name = "btn_druki_pliki";
            this.btn_druki_pliki.Size = new System.Drawing.Size(229, 47);
            this.btn_druki_pliki.TabIndex = 2;
            this.btn_druki_pliki.Text = "   Druki i pliki";
            this.btn_druki_pliki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_druki_pliki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_druki_pliki.UseVisualStyleBackColor = true;
            this.btn_druki_pliki.Click += new System.EventHandler(this.btn_druki_pliki_Click);
            // 
            // btn_mail
            // 
            this.btn_mail.FlatAppearance.BorderSize = 0;
            this.btn_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_mail.Image = ((System.Drawing.Image)(resources.GetObject("btn_mail.Image")));
            this.btn_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mail.Location = new System.Drawing.Point(0, 276);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Size = new System.Drawing.Size(229, 47);
            this.btn_mail.TabIndex = 3;
            this.btn_mail.Text = "   Mail";
            this.btn_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mail.UseVisualStyleBackColor = true;
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // btn_edycja_danych
            // 
            this.btn_edycja_danych.FlatAppearance.BorderSize = 0;
            this.btn_edycja_danych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edycja_danych.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edycja_danych.Image = ((System.Drawing.Image)(resources.GetObject("btn_edycja_danych.Image")));
            this.btn_edycja_danych.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edycja_danych.Location = new System.Drawing.Point(0, 329);
            this.btn_edycja_danych.Name = "btn_edycja_danych";
            this.btn_edycja_danych.Size = new System.Drawing.Size(229, 47);
            this.btn_edycja_danych.TabIndex = 4;
            this.btn_edycja_danych.Text = "   Edycja danych";
            this.btn_edycja_danych.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edycja_danych.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edycja_danych.UseVisualStyleBackColor = true;
            this.btn_edycja_danych.Click += new System.EventHandler(this.btn_edycja_danych_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(575, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 61);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(656, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 61);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnl_edycja_danych
            // 
            this.pnl_edycja_danych.Controls.Add(this.btn_new_acc);
            this.pnl_edycja_danych.Controls.Add(this.pnl_add_acc);
            this.pnl_edycja_danych.Location = new System.Drawing.Point(229, 58);
            this.pnl_edycja_danych.Name = "pnl_edycja_danych";
            this.pnl_edycja_danych.Size = new System.Drawing.Size(731, 482);
            this.pnl_edycja_danych.TabIndex = 2;
            // 
            // pnl_add_acc
            // 
            this.pnl_add_acc.BackColor = System.Drawing.Color.PaleGreen;
            this.pnl_add_acc.Controls.Add(this.btn_add);
            this.pnl_add_acc.Controls.Add(this.txt_add_email);
            this.pnl_add_acc.Controls.Add(this.label_add_email);
            this.pnl_add_acc.Location = new System.Drawing.Point(415, 0);
            this.pnl_add_acc.Name = "pnl_add_acc";
            this.pnl_add_acc.Size = new System.Drawing.Size(316, 482);
            this.pnl_add_acc.TabIndex = 0;
            // 
            // label_add_email
            // 
            this.label_add_email.AutoSize = true;
            this.label_add_email.Location = new System.Drawing.Point(22, 81);
            this.label_add_email.Name = "label_add_email";
            this.label_add_email.Size = new System.Drawing.Size(257, 17);
            this.label_add_email.TabIndex = 0;
            this.label_add_email.Text = "Wprowadź Email nowego użytkownika";
            // 
            // txt_add_email
            // 
            this.txt_add_email.Location = new System.Drawing.Point(22, 112);
            this.txt_add_email.Name = "txt_add_email";
            this.txt_add_email.Size = new System.Drawing.Size(257, 24);
            this.txt_add_email.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Ivory;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(182, 218);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 33);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Dodaj";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_new_acc
            // 
            this.btn_new_acc.BackColor = System.Drawing.Color.Ivory;
            this.btn_new_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_acc.Location = new System.Drawing.Point(30, 59);
            this.btn_new_acc.Name = "btn_new_acc";
            this.btn_new_acc.Size = new System.Drawing.Size(160, 39);
            this.btn_new_acc.TabIndex = 1;
            this.btn_new_acc.Text = "Nowy użytkownik";
            this.btn_new_acc.UseVisualStyleBackColor = false;
            this.btn_new_acc.Click += new System.EventHandler(this.btn_new_acc_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnl_edycja_danych);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_left);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.pnl_left.ResumeLayout(false);
            this.pnl_up.ResumeLayout(false);
            this.pnl_edycja_danych.ResumeLayout(false);
            this.pnl_add_acc.ResumeLayout(false);
            this.pnl_add_acc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Button btn_wydzialy;
        private System.Windows.Forms.Button btn_harmonogramy;
        private System.Windows.Forms.Button btn_edycja_danych;
        private System.Windows.Forms.Button btn_mail;
        private System.Windows.Forms.Button btn_druki_pliki;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnl_edycja_danych;
        private System.Windows.Forms.Button btn_new_acc;
        private System.Windows.Forms.Panel pnl_add_acc;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_add_email;
        private System.Windows.Forms.Label label_add_email;
    }
}