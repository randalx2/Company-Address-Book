namespace RGI_EmployeeList_v1
{
    partial class frmDisplayEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEXT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datRichfieldDataSet = new RGI_EmployeeList_v1.datRichfieldDataSet();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtCampus = new System.Windows.Forms.TextBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.lblCellno = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new RGI_EmployeeList_v1.datRichfieldDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datRichfieldDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEXT
            // 
            this.lblEXT.AutoSize = true;
            this.lblEXT.Location = new System.Drawing.Point(34, 26);
            this.lblEXT.Name = "lblEXT";
            this.lblEXT.Size = new System.Drawing.Size(28, 13);
            this.lblEXT.TabIndex = 0;
            this.lblEXT.Text = "EXT";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EXT", true));
            this.textBox1.Location = new System.Drawing.Point(90, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.datRichfieldDataSet;
            // 
            // datRichfieldDataSet
            // 
            this.datRichfieldDataSet.DataSetName = "datRichfieldDataSet";
            this.datRichfieldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FIRST_NAME", true));
            this.txtFirstName.Location = new System.Drawing.Point(90, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "SURNAME", true));
            this.txtSurname.Location = new System.Drawing.Point(90, 98);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(197, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(27, 101);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // txtCampus
            // 
            this.txtCampus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "CAMPUS", true));
            this.txtCampus.Location = new System.Drawing.Point(90, 139);
            this.txtCampus.Name = "txtCampus";
            this.txtCampus.Size = new System.Drawing.Size(197, 20);
            this.txtCampus.TabIndex = 7;
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(27, 142);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(45, 13);
            this.lblCampus.TabIndex = 6;
            this.lblCampus.Text = "Campus";
            this.lblCampus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDepartment
            // 
            this.txtDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "DEPARTMENT", true));
            this.txtDepartment.Location = new System.Drawing.Point(90, 181);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(197, 20);
            this.txtDepartment.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(27, 184);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department";
            // 
            // txtCellNo
            // 
            this.txtCellNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "CELL", true));
            this.txtCellNo.Location = new System.Drawing.Point(90, 226);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(197, 20);
            this.txtCellNo.TabIndex = 11;
            // 
            // lblCellno
            // 
            this.lblCellno.AutoSize = true;
            this.lblCellno.Location = new System.Drawing.Point(27, 229);
            this.lblCellno.Name = "lblCellno";
            this.lblCellno.Size = new System.Drawing.Size(41, 13);
            this.lblCellno.TabIndex = 10;
            this.lblCellno.Text = "Cell No";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(61, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(178, 268);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // frmDisplayEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 303);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.lblCellno);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtCampus);
            this.Controls.Add(this.lblCampus);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDisplayEmployees";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frmDisplayEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datRichfieldDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEXT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtCampus;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Label lblCellno;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private datRichfieldDataSet datRichfieldDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private datRichfieldDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}