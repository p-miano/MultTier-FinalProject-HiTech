using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechLibrary.BLL;

namespace Hi_TechApp
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            DataSet dsCustomers = customer.GetAllCustomers();
            dtGridCustomers.DataSource = dsCustomers.Tables["Customers"];
        }
    }
}
