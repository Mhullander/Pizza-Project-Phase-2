using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Project_Phase_1
{
    public partial class frmPizzaParlor : Form
    {
        //Constant Pizza Size and Topping Price Variable
        const Single sngTax = .07f;
        const Single sngSmall = 7.00f;
        const Single sngMedium = 12.00f;
        const Single sngLarge = 15.00f;
        const Single sngExtraCheese = 1.50f;
        const Single sngPepperoni = 2.00f;
        const Single sngSausage = 2.00f;
        const Single sngArtichoke = 0.75f;
        const Single sngMushroom = 0.50f;
        const Single sngSunTomato = 1.00f;
        const Single sngBlackOlives = 0.50f;
        const Single sngOnion = 0.50f;
        const Single sngSpinach = 0.75f;
        const Single sngGreenPepper = 0.50f;
        bool blnName;
        bool blnAddr1;
        bool blnPhone;
        bool blnCity;
        bool blnZip;
        public frmPizzaParlor()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strState;
            string strPath = Application.StartupPath + "/../../StateAbbrev.txt";
            FileStream fsStates = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            StreamReader srStates = new StreamReader(fsStates);
            while (!srStates.EndOfStream)
            {
                strState = srStates.ReadLine();
                cboState.Items.Add(strState);
            }
            srStates.Close();

            cboState.SelectedItem = "MN";
            radSmall.Checked = true;
            nudQuantity.Value = 1;
            cboPayment.SelectedIndex = 0;

            btnAccept.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult  dlgAnswer;
            dlgAnswer = MessageBox.Show("Do you want to Close?", "Close Form", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button2);

            if (dlgAnswer == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void tmrDT_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            this.Price();
         

        }

        public void Price()
        {
            //Calculate pricing by size
            Single sngPrice;

            if (radSmall.Checked)
            {
                sngPrice = sngSmall;
            }
            else if (radMedium.Checked)
            {
                sngPrice = sngMedium;
            }
            else
            {
                sngPrice = sngLarge;
            }
            //Calculate additional toppings
            if (chkArtichoke.Checked)
            {
                sngPrice += sngArtichoke;
            }
            if (chkBlackOlive.Checked)
            {
                sngPrice += sngBlackOlives;
            }
            if (chkExtraCheese.Checked)
            {
                sngPrice += sngExtraCheese;
            }
            if (chkGreenPepper.Checked)
            {
                sngPrice += sngGreenPepper;
            }
            if (chkMushroom.Checked)
            {
                sngPrice += sngMushroom;
            }
            if (chkOnion.Checked)
            {
                sngPrice += sngOnion;
            }
            if (chkPepperoni.Checked)
            {
                sngPrice += sngPepperoni;
            }
            if (chkSausage.Checked)
            {
                sngPrice += sngSausage;
            }
            if (chkSpinach.Checked)
            {
                sngPrice += sngSpinach;
            }
            if (chkSundriedTomato.Checked)
            {
                sngPrice += sngSunTomato;
            }
            // Calculate subtotal of Pizza (Size, toppings, number of pizzas)
            sngPrice *= Convert.ToSingle(nudQuantity.Value);
            lblSub.Text = sngPrice.ToString("c");

            //Calculate Tax
            Single sngTaxTotal;
            sngTaxTotal = sngPrice * sngTax;
            lblTaxTotal.Text = sngTaxTotal.ToString("c");

            //Calculate Grand Total
            Single sngGrandTotal;
            sngGrandTotal = sngPrice + sngTaxTotal;
            lblGTotal.Text = sngGrandTotal.ToString("c");

        }

        public void clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            mtbPhone.Clear();
            mtbZip.Clear();
            chkArtichoke.Checked = false;
            chkBlackOlive.Checked = false;
            chkExtraCheese.Checked = false;
            chkGreenPepper.Checked = false;
            chkMushroom.Checked = false;
            chkMute.Checked = false;
            chkOnion.Checked = false;
            chkPepperoni.Checked = false;
            chkSausage.Checked = false;
            chkSpinach.Checked = false;
            chkSundriedTomato.Checked = false;
            cboState.SelectedItem = "MN";
            radSmall.Checked = true;
            nudQuantity.Value = 1;
            cboPayment.SelectedIndex = 0;
            blnPhone = false;
            blnName = false;
            blnAddr1 = false;
            blnCity = false;
            blnZip = false;
            EnableAccept();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.clear();
        }
       

        public void EnableAccept()
        {
            if (blnPhone && blnName && blnAddr1 && blnCity && blnZip)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            blnPhone = false;
            if (mtbPhone.Text.Length == 10)
            {
                errProv.Clear();
                blnPhone = true;
                EnableAccept();
            }
            else
            {
                errProv.SetError(mtbPhone, "Must enter a 10 digit phone number!");
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            blnName = false;
            if (txtName.Text.Length > 4 && txtName.Text.Length <26)
            {
                errProv.Clear();
                blnName = true;
                EnableAccept();
            }
            else
            {
                errProv.SetError(txtName, "Invalid Length");
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            blnAddr1 = false;
            if (txtAddress.Text.Length > 4 && txtAddress.Text.Length < 26)
            {
                errProv.Clear();
                blnAddr1 = true;
                EnableAccept();
            }
            else
            {
                errProv.SetError(txtAddress, "Invalid Length");
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            blnCity = false;
            if (txtCity.Text.Length > 1 && txtCity.Text.Length < 26)
            {
                errProv.Clear();
                blnCity = true;
                EnableAccept();
            }
            else
            {
                errProv.SetError(txtCity, "Invalid Length");
            }
        }

        private void mtbZip_Leave(object sender, EventArgs e)
        {
            blnZip = false;
            if (mtbZip.Text.Length == 5 || mtbZip.Text.Length == 9)
            {
                errProv.Clear();
                blnZip = true;
                EnableAccept();
            }
            else
            {
                errProv.SetError(mtbZip, "Invalid Length");
            }
        }


        private int orderNum = 0;
        
        private void btnAccept_Click(object sender, EventArgs e)
        {
       
            orderNum++;
            lblNumber.Text = orderNum.ToString();


            Customers objCustomer = new Customers();
            objCustomer.CustPhone = mtbPhone.Text;
            objCustomer.CustName = txtName.Text;
            objCustomer.CustAddr1 = txtAddress.Text;
            objCustomer.CustAddr2 = txtAddress2.Text;
            objCustomer.CustCity = txtCity.Text;
            objCustomer.CustState = cboState.Text;
            objCustomer.CustZip = mtbZip.Text;

            string strPath = Application.StartupPath + "/Transaction.txt";
            
            FileStream fsTransaction = new FileStream(strPath, FileMode.Append, FileAccess.Write);
            StreamWriter swTransactions = new StreamWriter(fsTransaction);
                
            swTransactions.WriteLine(lblNumber.Text);
            swTransactions.WriteLine(objCustomer.CustPhone);
            swTransactions.WriteLine(objCustomer.CustName);
            swTransactions.WriteLine(lblGTotal.Text);
            lblNumber.Text += Environment.NewLine;
            objCustomer.CustPhone += Environment.NewLine;
            objCustomer.CustName += Environment.NewLine;
            lblGTotal.Text += Environment.NewLine;
            swTransactions.Close();

            MessageBox.Show("Pizza is on the way!");

            this.clear();





        }

        private void mtbPhone_Enter(object sender, EventArgs e)
        {
            blnPhone = false;
            EnableAccept();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            blnName = false;
            EnableAccept();
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            blnAddr1 = false;
            EnableAccept();
        }

        private void txtCity_Enter(object sender, EventArgs e)
        {
            blnCity = false;
            EnableAccept();
        }

        private void mtbZip_Enter(object sender, EventArgs e)
        {
            blnZip = false;
            EnableAccept();
        }
    }

}
