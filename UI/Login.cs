﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMA
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            textpassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textusrname.Text == "admin" || textpassword.Text == "admin")
            {
                MessageBox.Show("Login Succesfull");
                 new Patient().Show();
            this.Hide();
            }
            else
            {
                textusrname.Clear();
                textpassword.Clear();
                MessageBox.Show("Credentials is not correct");
            }
           
        }
    }
}