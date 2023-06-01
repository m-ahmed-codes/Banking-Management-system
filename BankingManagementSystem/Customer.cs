using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    internal class Customer
    {
        string customerName;
        int customerPhoneNo;
        string customerEduaction;
        string customerGender;
        int customerIncome;
        string customerAddress;
        


        public Customer() { 
            customerName= string.Empty;
            customerPhoneNo= 0;
            customerEduaction   = string.Empty;
            customerGender = string.Empty;
            customerIncome = 0;
            customerAddress = string.Empty;
        }  
        
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int CustomerPhoneNo
        {
            get { return customerPhoneNo; }
            set { customerPhoneNo = value; }
        }
        public string CustomerEduaction
        {
            get { return customerEduaction; }
            set{customerEduaction = value;}
        }
        public string CustomerGender
        {
            get { return customerGender; }
            set { customerGender = value; }
        }

        public int CustomerIncome
        {
            get { return customerIncome; }
                        set
            {
                customerIncome = value;
            }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
                        set
            {
                customerAddress = value;
            }
        }

        public void setDataMethod(string CN , int CP, string CE , string CG, int CI,string CA)
        {
            customerName = CN;
            customerPhoneNo = CP;
            customerEduaction = CE;
            customerGender = CG;
            customerIncome = CI;
            customerAddress = CA;
        }






    }
}
