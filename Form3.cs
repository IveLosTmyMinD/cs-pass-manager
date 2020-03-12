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
    public partial class deleteForm : Form
    {
        
        public deleteForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
