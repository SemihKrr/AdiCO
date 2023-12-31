﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzKitchen
{
    public partial class FormLogin : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //////
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                var account = db.Accounts.Where(x => x.Email == txtEmail.Text).ToList();
                if(account.Count > 0)
                {
                    if(txtPassword.Text == account[0].Password)
                    {
                        var role = account[0].Role;

                        if(role == "Admin")
                        {
                            this.Hide();
                            new FormNavigationAdmin()
                            { 
                                adminID = account[0].ID
                            }.Show();
                        }
                        else if(role == "Chef")
                        {
                            this.Hide();
                            new FormNavigationChef()
                            {
                                chefID = account[0].ID
                            }.Show();
                        }
                        else
                        {
                            this.Hide();
                            new FormNavigationTable()
                            {
                                cashierID = account[0].ID
                            }.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email or password is wrong ...");
                    }
                }
                else
                {
                    MessageBox.Show("Email or password is wrong ...");
                }
            }
            else
            {
                MessageBox.Show("Fill up email and password ...");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {       
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture=new System.Globalization.CultureInfo("en");
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
            }
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
