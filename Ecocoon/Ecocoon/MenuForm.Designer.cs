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
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnl_harmonogramy = new System.Windows.Forms.Panel();
            this.napis_harmonogramy = new System.Windows.Forms.TextBox();
            this.pnl_wydzialy = new System.Windows.Forms.Panel();
            this.napis_wydzialy = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnl_edycja_danych = new System.Windows.Forms.Panel();
            this.pnl_add_acc = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.label_add_email = new System.Windows.Forms.Label();
            this.txt_add_email = new System.Windows.Forms.TextBox();
            this.button_new_acc = new System.Windows.Forms.Button();
            this.pnl_left.SuspendLayout();
            this.pnl_up.SuspendLayout();
            this.pnl_harmonogramy.SuspendLayout();
            this.pnl_wydzialy.SuspendLayout();
            this.pnl_edycja_danych.SuspendLayout();
            this.pnl_add_acc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.Green;
            this.pnl_left.Controls.Add(this.button7);
            this.pnl_left.Controls.Add(this.button4);
            this.pnl_left.Controls.Add(this.button3);
            this.pnl_left.Controls.Add(this.button2);
            this.pnl_left.Controls.Add(this.button1);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(229, 540);
            this.pnl_left.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 329);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 47);
            this.button7.TabIndex = 6;
            this.button7.Text = "  Edycja danych";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "   Mail";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "   Druki i pliki";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "   Wydziały";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Harmonogramy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_up
            // 
            this.pnl_up.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_up.Controls.Add(this.button6);
            this.pnl_up.Controls.Add(this.button5);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(229, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(731, 61);
            this.pnl_up.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(656, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 61);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(575, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 61);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pnl_harmonogramy
            // 
            this.pnl_harmonogramy.Controls.Add(this.napis_harmonogramy);
            this.pnl_harmonogramy.Location = new System.Drawing.Point(229, 59);
            this.pnl_harmonogramy.Name = "pnl_harmonogramy";
            this.pnl_harmonogramy.Size = new System.Drawing.Size(731, 481);
            this.pnl_harmonogramy.TabIndex = 2;
            // 
            // napis_harmonogramy
            // 
            this.napis_harmonogramy.Location = new System.Drawing.Point(319, 165);
            this.napis_harmonogramy.Name = "napis_harmonogramy";
            this.napis_harmonogramy.Size = new System.Drawing.Size(107, 24);
            this.napis_harmonogramy.TabIndex = 0;
            this.napis_harmonogramy.Text = "Harmonogramy";
            // 
            // pnl_wydzialy
            // 
            this.pnl_wydzialy.Controls.Add(this.napis_wydzialy);
            this.pnl_wydzialy.Location = new System.Drawing.Point(229, 59);
            this.pnl_wydzialy.Name = "pnl_wydzialy";
            this.pnl_wydzialy.Size = new System.Drawing.Size(731, 481);
            this.pnl_wydzialy.TabIndex = 3;
            // 
            // napis_wydzialy
            // 
            this.napis_wydzialy.Location = new System.Drawing.Point(281, 172);
            this.napis_wydzialy.Name = "napis_wydzialy";
            this.napis_wydzialy.Size = new System.Drawing.Size(68, 24);
            this.napis_wydzialy.TabIndex = 0;
            this.napis_wydzialy.Text = "Wydziały";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pnl_edycja_danych
            // 
            this.pnl_edycja_danych.Controls.Add(this.pnl_add_acc);
            this.pnl_edycja_danych.Controls.Add(this.button_new_acc);
            this.pnl_edycja_danych.Location = new System.Drawing.Point(229, 59);
            this.pnl_edycja_danych.Name = "pnl_edycja_danych";
            this.pnl_edycja_danych.Size = new System.Drawing.Size(731, 481);
            this.pnl_edycja_danych.TabIndex = 4;
            // 
            // pnl_add_acc
            // 
            this.pnl_add_acc.BackColor = System.Drawing.Color.PaleGreen;
            this.pnl_add_acc.Controls.Add(this.button_add);
            this.pnl_add_acc.Controls.Add(this.label_add_email);
            this.pnl_add_acc.Controls.Add(this.txt_add_email);
            this.pnl_add_acc.Location = new System.Drawing.Point(415, 0);
            this.pnl_add_acc.Name = "pnl_add_acc";
            this.pnl_add_acc.Size = new System.Drawing.Size(316, 482);
            this.pnl_add_acc.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Ivory;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Location = new System.Drawing.Point(182, 218);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 33);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // label_add_email
            // 
            this.label_add_email.AutoSize = true;
            this.label_add_email.Location = new System.Drawing.Point(22, 81);
            this.label_add_email.Name = "label_add_email";
            this.label_add_email.Size = new System.Drawing.Size(257, 17);
            this.label_add_email.TabIndex = 1;
            this.label_add_email.Text = "Wprowadź Email nowego użytkownika";
            // 
            // txt_add_email
            // 
            this.txt_add_email.Location = new System.Drawing.Point(22, 112);
            this.txt_add_email.Name = "txt_add_email";
            this.txt_add_email.Size = new System.Drawing.Size(257, 24);
            this.txt_add_email.TabIndex = 0;
            // 
            // button_new_acc
            // 
            this.button_new_acc.BackColor = System.Drawing.Color.Ivory;
            this.button_new_acc.FlatAppearance.BorderSize = 0;
            this.button_new_acc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_new_acc.Location = new System.Drawing.Point(30, 59);
            this.button_new_acc.Name = "button_new_acc";
            this.button_new_acc.Size = new System.Drawing.Size(160, 39);
            this.button_new_acc.TabIndex = 0;
            this.button_new_acc.Text = "Nowy użytkownik";
            this.button_new_acc.UseVisualStyleBackColor = false;
            this.button_new_acc.Click += new System.EventHandler(this.button_new_acc_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnl_edycja_danych);
            this.Controls.Add(this.pnl_wydzialy);
            this.Controls.Add(this.pnl_harmonogramy);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_left);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_up.ResumeLayout(false);
            this.pnl_harmonogramy.ResumeLayout(false);
            this.pnl_harmonogramy.PerformLayout();
            this.pnl_wydzialy.ResumeLayout(false);
            this.pnl_wydzialy.PerformLayout();
            this.pnl_edycja_danych.ResumeLayout(false);
            this.pnl_add_acc.ResumeLayout(false);
            this.pnl_add_acc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_left;
        private Button button1;
        private Panel pnl_up;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Panel pnl_harmonogramy;
        private TextBox napis_harmonogramy;
        private Panel pnl_wydzialy;
        private TextBox napis_wydzialy;
        private Button button7;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Panel pnl_edycja_danych;
        private Panel pnl_add_acc;
        private Button button_new_acc;
        private Button button_add;
        private Label label_add_email;
        private TextBox txt_add_email;
    }
}