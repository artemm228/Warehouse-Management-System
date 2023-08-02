﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows;

namespace Warehouse_Management_System
{
    public partial class Form_Management : Form
    {
        public Form_Management()
        {
            InitializeComponent();

            btnDelete.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatStyle = FlatStyle.Flat;

            btnDelete.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
        }

        private void Form_Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Close();
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Client_System client = new Client_System();
                string[] response = await client.SendData("Add", tbName.Text, tbPrice.Text, rtbdescription.Text, numeric.Text);
                string message = string.Join(Environment.NewLine, response);
                
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
