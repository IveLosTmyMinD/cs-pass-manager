﻿using System;
using System.Windows.Forms;


namespace cp_pass_manager
{
    public partial class addData : Form
    {
        public new String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public new String Site { get; set; }
        public String Description { get; set; }

        public addData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddDataToDb_Load(object sender, EventArgs e)
        {
            Name = "Name";
            Login = "Login";
            Password = "Password";
            Site = "Site";
            Description = "Description";

            tbName.Text = Name;
            tbLogin.Text = Login;
            tbPass.Text = Password;
            tbSite.Text = Site;
            tbDesc.Text = Description;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            Login = tbLogin.Text;
            Password = tbPass.Text;
            Site = tbSite.Text;
            Description = tbDesc.Text;

            DialogResult = DialogResult.OK;
        }
        
    }
}
