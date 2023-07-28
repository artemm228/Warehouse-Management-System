using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Warehouse_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            tbusername.Text = "username";
            tbusername.ForeColor = SystemColors.GrayText;

            tbusername.Enter += tbusername_Enter;
            tbusername.Leave += tbusername_Leave;

            tbpassword.Text = "password";
            tbpassword.ForeColor = SystemColors.GrayText;

            tbpassword.Enter += tbpassword_Enter;
            tbpassword.Leave += tbpassword_Leave;


            btnlogin.FlatStyle = FlatStyle.Flat; // Set button style to flat
            btnlogin.FlatAppearance.BorderColor = Color.Black; // Set the desired border color
            btnlogin.FlatAppearance.BorderSize = 0;


            this.StartPosition = FormStartPosition.CenterScreen; // to center this form.
                                                                 // the form will be displayed in the center of the screen when it launches.
        }
        private void tbusername_Enter(object sender, EventArgs e)
        {
            if (tbusername.Text == "username")
            {
                tbusername.Text = "";
                tbusername.ForeColor = SystemColors.WindowText;
            }
        }
        private void tbusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbusername.Text))
            {
                tbusername.Text = "username";
                tbusername.ForeColor = SystemColors.GrayText;
            }
        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbusername.ForeColor == SystemColors.GrayText && tbpassword.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter username and password");
            else if (tbpassword.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter password");
            else if (tbusername.ForeColor == SystemColors.GrayText)
                MessageBox.Show("Error. Enter username");
            else
            {
                // transition to a functional form
            }

            
        }

        private void tbusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tbpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbpassword.Text))
            {
                tbpassword.Text = "password";
                tbpassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tbpassword_Enter(object sender, EventArgs e)
        {
            if (tbpassword.Text == "password")
            {
                tbpassword.Text = "";
                tbpassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void cbshow_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow_pass.Checked)
            {
                tbpassword.PasswordChar = '*';
            }
            else
            {
                tbpassword.PasswordChar = '\0';
            }
        }

        private void lbregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Registration registerForm = new Form_Registration();
            registerForm.Show();
        }
    }
}
