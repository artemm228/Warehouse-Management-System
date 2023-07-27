﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Warehouse_Management_System
{
    public partial class Form_Registration : Form
    {
        private bool passwordVisible = false;
        public Form_Registration()
        {
            InitializeComponent();


            tbname.Text = "Name";
            tbname.Enter += tbname_Enter; tbname.Leave += tbname_Leave;
            tbname.ForeColor = SystemColors.GrayText;

            tbsurname.Text = "Surname";
            tbsurname.Enter += tbsurname_Enter; tbsurname.Leave += tbsurname_Leave;
            tbsurname.ForeColor = SystemColors.GrayText;

            tbnewlogin.Text = "New login";
            tbnewlogin.Enter += tbnewlogin_Enter; tbnewlogin.Leave += tbnewlogin_Leave;
            tbnewlogin.ForeColor = SystemColors.GrayText;

            tbnewpassword.Text = "Password";
            tbnewpassword.Enter += tbnewpassword_Enter; tbnewpassword.Leave += tbnewpassword_Leave;
            tbnewpassword.ForeColor = SystemColors.GrayText;


            btnmask.FlatAppearance.BorderSize = 0;

            btnsign.FlatStyle = FlatStyle.Flat;
            btnsign.FlatAppearance.BorderSize = 0;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            if (tbname.ForeColor == SystemColors.GrayText && 
                tbsurname.ForeColor == SystemColors.GrayText &&
                tbnewlogin.ForeColor == SystemColors.GrayText &&
                tbnewpassword.ForeColor == SystemColors.GrayText) {

                    MessageBox.Show("Error. Enter data in all fields!"); 
            }
            else if (tbname.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter Name");
            else if (tbsurname.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter Surname");
            else if (tbnewlogin.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter new login");
            else if (tbnewpassword.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter password");
            else
            {
                this.Close();
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
            }
        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmask_Click(object sender, EventArgs e)
        {
            if (passwordVisible == false)
            {

                btnmask.Image = Image.FromFile(@"..\..\images\hide.png");
                passwordVisible = true;

                if (tbnewpassword.ForeColor != SystemColors.GrayText)
                    tbnewpassword.PasswordChar = '*';
            }
            else
            {

                btnmask.Image = Image.FromFile(@"..\..\images\show.png");
                passwordVisible = false;
                tbnewpassword.PasswordChar = '\0';
            }
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }



        private void tbname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        private void tbsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        private void tbnewlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        private void tbnewpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }



        private void tbname_Enter(object sender, EventArgs e)
        {
            if (tbname.Text == "Name")
            {
                tbname.Text = "";
                tbname.ForeColor = SystemColors.WindowText;
            }
        }
        private void tbname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbname.Text))
            {
                tbname.Text = "Name";
                tbname.ForeColor = SystemColors.GrayText;
            }
        }


        private void tbsurname_Enter(object sender, EventArgs e)
        {
            if (tbsurname.Text == "Surname")
            {
                tbsurname.Text = "";
                tbsurname.ForeColor = SystemColors.WindowText;
            }
        }
        private void tbsurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbsurname.Text))
            {
                tbsurname.Text = "Surname";
                tbsurname.ForeColor = SystemColors.GrayText;
            }
        }


        private void tbnewlogin_Enter(object sender, EventArgs e)
        {
            if (tbnewlogin.Text == "New login")
            {
                tbnewlogin.Text = "";
                tbnewlogin.ForeColor = SystemColors.WindowText;
            }
        }
        private void tbnewlogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnewlogin.Text))
            {
                tbnewlogin.Text = "New login";
                tbnewlogin.ForeColor = SystemColors.GrayText;
            }
        }


        private void tbnewpassword_Enter(object sender, EventArgs e)
        {
            if (tbnewpassword.Text == "Password")
            {
                tbnewpassword.Text = "";
                tbnewpassword.ForeColor = SystemColors.WindowText;
            }
        }
        private void tbnewpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnewpassword.Text))
            {
                tbnewpassword.Text = "Password";
                tbnewpassword.ForeColor = SystemColors.GrayText;
            }
        }

        
    }
}
