using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project_Phase_1
{
    class Customers
    {
        private string custPhone;
        private string custName;
        private string custAddr1;
        private string custAddr2;
        private string custCity;
        private string custState;
        private string custZip;

        public string CustPhone
        {
            get { return custPhone; }
            set { custPhone = value; }
        }

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }

        public string CustAddr1
        {
            get { return custAddr1; }
            set { custAddr1 = value; }
        }

        public string CustAddr2
        {
            get { return custAddr2; }
            set { custAddr2 = value; }
        }

        public string CustCity
        {
            get { return custCity; }
            set { custCity = value; }
        }

        public string CustState
        {
            get { return custState; }
            set { custState = value; }
        }

        public string CustZip
        {
            get { return custZip; }
            set { custZip = value; }
        }

        public Customers() { }

        public Customers(string custPhone, string custName, string custAddr1, string custAddr2,
            string custCity, string custState, string custZip)
        {
            CustPhone = custPhone;
            CustName = custName;
            CustAddr1 = custAddr1;
            CustAddr2 = custAddr2;
            CustCity = custCity;
            CustState = custState;
            CustZip = custZip;

        }

    }
}
