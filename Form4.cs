using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp_pass_manager
{
    public partial class updateForm : Form
    {
        public new String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public new String Site { get; set; }
        public String Description { get; set; }

        public updateForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            Name = "Name";
            Login = "Login";
            Password = "Password";
            Site = "Site";
            Description = "Description";

            
        }

        private void button1_Click(object sender, EventArgs e)
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
