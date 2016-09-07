using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGI_EmployeeList_v1
{
    public partial class frmDisplayEmployees : Form
    {
        private BindingManagerBase bindMgr;
        public frmDisplayEmployees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmDisplayEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datRichfieldDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.datRichfieldDataSet.employees);
            bindMgr = BindingContext[employeesBindingSource];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bindMgr.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindMgr.Position++;
        }
    }
}
