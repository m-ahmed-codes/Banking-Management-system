using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    public partial class ChangePass : UserControl
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            Login login  = new Login();
            login.ChangePassword(OldPassTextBox.Text, NewPassTextBox.Text);
        }
    }
}
