using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private User u;

        public Form1()
        {
            InitializeComponent();
            u = new User();
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\punza\\Desktop\\winform\\WindowsFormsApp1\\WindowsFormsApp1\\json1.json");
            u.LoadUsersFromJson(jsonFilePath);
            button2.Click += new EventHandler(btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = textBox3.Text;
            var password = textBox4.Text;

            if (u.IsValid(username, password))
            {
                label5.Text = "Correct";
                label5.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label5.Text = "Wrong input";
                label5.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}