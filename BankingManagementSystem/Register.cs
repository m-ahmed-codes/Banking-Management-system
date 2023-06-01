using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    public partial class Register : UserControl
    {

        public Register()
        {
            InitializeComponent();

        }
        RegisterAgentClass newAgent = new RegisterAgentClass();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
           

            if (Namebox.Text == "" || UserNameBox.Text == "" || PassBox.Text == "" || Phonebox.Text.ToString() == "" || AddressBox.Text == "")
            {
                MessageBox.Show("Please Enter above all the field");
            }
            else
            {
                if (!regex.IsMatch(Phonebox.Text))
                {
                    MessageBox.Show("Phone number must be Digit");
                }
                else
                {
                    newAgent.AddAgentdata(Namebox.Text, UserNameBox.Text, PassBox.Text, int.Parse(Phonebox.Text), AddressBox.Text);
                    newAgent.AgentSubmit();

                }
                
            }

            if (newAgent.Flag == 1)
            {
                clearBtn();

            }

        }

        private void clearBtn()
        {
            Namebox.Clear();
            UserNameBox.Clear();
            PassBox.Clear();
            Phonebox.Clear();
            AddressBox.Clear();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearBtn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("ViewAgent"))
            {
                ViewAgent newAgent = new ViewAgent();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["ViewAgent"].BringToFront();


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Phonebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
