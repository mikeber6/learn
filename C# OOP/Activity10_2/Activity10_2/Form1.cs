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
    public partial class Form1 : Form
    {
        private DataSet _dataSet;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            _dataSet = person.GetData();
            dgvPeople.DataSource = _dataSet.Tables["Person"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.UpdateData(_dataSet.GetChanges());
        }
    }
}
