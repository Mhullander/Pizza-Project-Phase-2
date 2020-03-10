using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project_Phase_1
{
    public partial class frmPizzaParlor : Form
    {
        public frmPizzaParlor()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to close?");
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }

        private void gpbOrderNumber_Enter(object sender, EventArgs e)
        {

        }

        private void gpbPricing_Enter(object sender, EventArgs e)
        {

        }

        private void gpbPayment_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            
        }
    }
}
