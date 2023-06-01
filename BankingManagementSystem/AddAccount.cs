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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingManagementSystem
{
    public partial class AddAccount : UserControl
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        AddAccountClass AddAcc = new AddAccountClass();

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn()
        {
            Namebox.Clear();
            EducationComBox.Text = " ";
            GenderComboBox.Text = "";
            AccTypeComboBox1.Text = "";
            Phonebox.Clear();
            InconeBox.Clear();
            AddresstextBox.Clear();
        }
        

            
            


        private void submitBtn_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show("edu:"+ EducationComBox.SelectedItem);
            if (Namebox.Text == "" ||  EducationComBox.SelectedItem.ToString() == "" || GenderComboBox.SelectedItem.ToString() == "" || Phonebox.Text.ToString() == "" || InconeBox.Text.ToString() == " " || AccTypeComboBox1.SelectedItem.ToString() == ""|| AddresstextBox.Text =="")
            {
                MessageBox.Show("Please Enter above all the field");
            }
            else
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(Phonebox.Text, "^[0-9]*$") || !System.Text.RegularExpressions.Regex.IsMatch(InconeBox.Text, "^[0-9]*$"))
                {
                    MessageBox.Show("You enrtered Characcter in phone box or in Income box");
                }
                else
                {
                     AddAcc.setDataAccMethod(Namebox.Text, int.Parse(Phonebox.Text), EducationComBox.SelectedItem.ToString(), GenderComboBox.SelectedItem.ToString(), int.Parse(InconeBox.Text), AddresstextBox.Text, AccTypeComboBox1.SelectedItem.ToString());
                    AddAcc.addAccount();
                  
                }

             
            }

            if (AddAcc.Flag == 1)
            {
               clearBtn();

            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearBtn();
        }
    }
}
