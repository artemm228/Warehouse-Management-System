using System;
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
        }

        private void Form_Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Close();
            Application.Exit();
        }

        private async Task DeleteData()
        {
            try
            {
                string name = tbName.Text;

                // Data input validation
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a new name!");
                    return;
                }


                Client_System client = new Client_System();
                string[] response = await client.SendData("Delete", tbName.Text);
                string message = string.Join(Environment.NewLine, response);

                MessageBox.Show(message);

                if (message == "Delete Success!")
                {
                    // Clearing text fields
                    tbName.Text = string.Empty;
                    rtbdescription.Text = string.Empty;
                    numeric.Value = 0;
                    tbPrice.Text = string.Empty;

                    // It updates product information by retrieving new data from the database
                    this.stockDataDataSet1.Item.Clear();
                    this.itemTableAdapter1.Fill(this.stockDataDataSet1.Item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Task.Run(() => DeleteData());
        }


        private async Task AddData()
        {
            try
            {
                // Data input validation
                string name = tbName.Text.Trim();
                string description = rtbdescription.Text.Trim();
                int quantity = (int)numeric.Value; 
                string price = tbPrice.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(price))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }


                Client_System client = new Client_System();
                string[] response = await client.SendData("Add", tbName.Text, rtbdescription.Text, numeric.Text, tbPrice.Text);
                string message = string.Join(Environment.NewLine, response);

                MessageBox.Show(message);

                if (message == "Insert successful!")
                {
                    // Clearing text fields
                    tbName.Text = string.Empty;
                    rtbdescription.Text = string.Empty;
                    numeric.Value = 0;
                    tbPrice.Text = string.Empty;

                    // It updates product information by retrieving new data from the database
                    this.stockDataDataSet1.Item.Clear();
                    this.itemTableAdapter1.Fill(this.stockDataDataSet1.Item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             Task.Run(() => AddData());
        }

        private async Task EditData()
        {
            try
            {
                string name = tbName.Text;

                // Data input validation
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a new name!");
                    return;
                }

                Client_System client = new Client_System();
                string[] response = await client.SendData("Edit", tbName.Text, rtbdescription.Text, numeric.Text, tbPrice.Text);
                string message = string.Join(Environment.NewLine, response);

                MessageBox.Show(message);

                if (message == "Update successful!")
                {
                    // Clearing text fields
                    tbName.Text = string.Empty;
                    rtbdescription.Text = string.Empty;
                    numeric.Value = 0;
                    tbPrice.Text = string.Empty;

                    // It updates product information by retrieving new data from the database
                    this.stockDataDataSet1.Item.Clear();
                    this.itemTableAdapter1.Fill(this.stockDataDataSet1.Item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Task.Run(() => EditData());
        }

        private void Form_Management_Load(object sender, EventArgs e)
        {
            // This line of code allows you to load data into a table
            this.itemTableAdapter1.Fill(this.stockDataDataSet1.Item);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;

            // send a request to the server to search by name
            Client_System client = new Client_System();
            string[] response = await client.SendData("Search", search);

            // Processing the received response from the server
            if (response.Length > 0)
            {
                // Display search results in a messagebox
                string searchResults = string.Join(Environment.NewLine, response);
                MessageBox.Show($"Search Results:{Environment.NewLine}{searchResults}");

                // distribute the data from the response into the necessary text fields
                string[] resultParts = response[0].Split(new string[] { "Name: ", ", Description: ", ", Quantity: ", ", Price: " }, StringSplitOptions.RemoveEmptyEntries);

                if (resultParts.Length == 4)
                {
                    tbName.Text = resultParts[0];
                    rtbdescription.Text = resultParts[1];
                    numeric.Value = int.Parse(resultParts[2]);
                    tbPrice.Text = resultParts[3];

                    tbSearch.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Invalid response from server.");
                }
            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }
    }
}
