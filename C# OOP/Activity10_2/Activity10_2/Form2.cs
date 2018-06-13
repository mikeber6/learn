using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10_2
{
    public partial class Form2 : Form
    {
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            ds = order.GetData();
            dgvOrders.DataSource = ds.Tables["Orders"];
            dgvPeople.DataSource = ds.Tables["Orders"];
            dgvPeople.DataMember = "OrdersToPeople";          


        }
    }
}
