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
    public partial class frmRichfieldList : Form
    {
        //Declare dynamic Objects
        //DataLayer myData;
        //Employees myEmployee;

        DataTable table = new DataTable();
        int indexRow;
        
        public frmRichfieldList()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRichfieldList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datRichfieldDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.datRichfieldDataSet.employees);

            BindingSource bs = new BindingSource(); //
            table = datRichfieldDataSet.employees; //Fill our table dynamic object
            bs.DataSource = table;   //
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs; //
       
            //For the binding navigator

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Take into account searching and editing using the DataView object
                //Try not changing the data source

           
                //=========================================================================
                employeesBindingSource.EndEdit(); //End all edits
                employeesTableAdapter.Update(datRichfieldDataSet.employees); //Update the database with THIS dataset

                //Can Use data from text boxes
               /* DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                newDataRow.Cells[0].Value = txtID.Text;
                newDataRow.Cells[1].Value = txtEXT.Text;
                newDataRow.Cells[2].Value = txtFirstName.Text;
                newDataRow.Cells[3].Value = txtSurname.Text;
                newDataRow.Cells[4].Value = txtCampus.Text;
                newDataRow.Cells[5].Value = txtDepartment.Text;
                newDataRow.Cells[6].Value = txtCELL.Text;*/

                MessageBox.Show("Database Updated");

                //Refill the local dataset
                this.employeesTableAdapter.Fill(this.datRichfieldDataSet.employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayEmployees employees = new frmDisplayEmployees();
            employees.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Alternate method commented out due to updation problems
            //DataView DV = new DataView(employeesTableAdapter.GetData());
           // DV.RowFilter = string.Format("[FIRST_NAME] LIKE '%{0}%'", txtSearchFirstName.Text);
           // dataGridView1.DataSource = DV;  
            //employeesBindingSource.DataSource = DV; //BIND THE NEW DATA

            //Clear the details boxes to avoid confusion
            clearDetailsBoxes();

            //Take into account updating after searching using First Name
            table.DefaultView.RowFilter = string.Format("[FIRST_NAME] LIKE '%{0}%'", txtSearchFirstName.Text);
          
        }

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            //ALTERNATE METHOD COMMENTED OUT DUE TO UPDATION PROBLEMS
            //DataView DV = new DataView(employeesTableAdapter.GetData());
            //DV.RowFilter = string.Format("[SURNAME] LIKE '%{0}%'", txtSearchSurname.Text);
            //dataGridView1.DataSource = DV;
            //employeesBindingSource.DataSource = DV;  //BIND THE NEW DATA

            //Clear the details boxes to avoid confusion
            clearDetailsBoxes();

            //Take into account updating after searching using Surname
            table.DefaultView.RowFilter = string.Format("[SURNAME] LIKE '%{0}%'", txtSearchSurname.Text);
  
        }

        private void txtSearchCell_TextChanged(object sender, EventArgs e)
        {
            //ALTERNATE METHOD COMMENTED OUT DUE TO UPDATION PROBLEMS
            //DataView DV = new DataView(employeesTableAdapter.GetData());
            //DV.RowFilter = string.Format("[CELL] LIKE '%{0}%'", txtSearchCell.Text);
            //dataGridView1.DataSource = DV;
            //employeesBindingSource.DataSource = DV;  //BIND THE NEW DATA

            //Clear the details boxes to avoid confusion
            clearDetailsBoxes();

            //Take into account updating after searching using Cell number
            table.DefaultView.RowFilter = string.Format("[CELL] LIKE '%{0}%'", txtSearchCell.Text);
        }

        private void txtSearchCampust_TextChanged(object sender, EventArgs e)
        {
            //ALTERNATE METHOD COMMENTED OUT DUE TO UPDATION PROBLEMS
            //DataView DV = new DataView(employeesTableAdapter.GetData());
            //DV.RowFilter = string.Format("[CAMPUS] LIKE '%{0}%'", txtSearchCampust.Text);
            //dataGridView1.DataSource = DV;
            //employeesBindingSource.DataSource = DV;  //BIND THE NEW DATA

            //Clear the details boxes to avoid confusion
            clearDetailsBoxes();

            //Take into account updating after searching using Campus
            table.DefaultView.RowFilter = string.Format("[CAMPUS] LIKE '%{0}%'", txtSearchCampust.Text);
        }

        private void txtSearchDept_TextChanged(object sender, EventArgs e)
        {
            //ALTERNATE METHOD COMMENTED OUT DUE TO UPDATION PROBLEMS
            //DataView DV = new DataView(employeesTableAdapter.GetData());
            //DV.RowFilter = string.Format("[DEPARTMENT] LIKE '%{0}%'", txtSearchDept.Text);
            //dataGridView1.DataSource = DV;

            //employeesBindingSource.DataSource = DV;  //BIND THE NEW DATA

            //Clear the details boxes to avoid confusion
            clearDetailsBoxes();

            //Take into account updating after searching using Department
            table.DefaultView.RowFilter = string.Format("[DEPARTMENT] LIKE '%{0}%'", txtSearchDept.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex; // get the selected Row Index
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                txtID.Text = row.Cells[0].Value.ToString();
                txtEXT.Text = row.Cells[1].Value.ToString();
                txtFirstName.Text = row.Cells[2].Value.ToString();
                txtSurname.Text = row.Cells[3].Value.ToString();
                txtCampus.Text = row.Cells[4].Value.ToString();
                txtDepartment.Text = row.Cells[5].Value.ToString();
                txtCELL.Text = row.Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " \nPlease exit and restart the application to correct indexing");
            }
       
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(txtSearchFirstName.Text != "")
            {
                txtSearchFirstName.Text = "";
            }

            if(txtSearchSurname.Text != "")
            {
                txtSearchSurname.Text = "";
            }

            if(txtSearchCampust.Text != "")
            {
                txtSearchCampust.Text = "";
            }

            if(txtSearchCell.Text != "")
            {
                txtSearchCell.Text = "";
            }

            if(txtSearchDept.Text != "")
            {
                txtSearchDept.Text = "";
            }

            //Spam the first name text box to return the default starting view
            txtSearchFirstName.Text = " ";
            txtSearchFirstName.Text = "";
        }

        private void clearDetailsBoxes()
        {
            txtEXT.Text = "";
            txtCELL.Text = "";
            txtCampus.Text = "";
            txtDepartment.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtID.Text = "";
        }
    }
}
