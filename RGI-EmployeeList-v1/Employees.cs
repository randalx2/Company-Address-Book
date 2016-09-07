using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RGI_EmployeeList_v1
{
    class Employees : DataLayer           //USES INHERITANCE
    {
        //This class references the MS Access Database
        //Naming has to be exactly the same as the entry id's in the Database

        //Private member variables to store employee data
        private long _ID;   //Autonumbers are long integers
        private String _ext;
        private String _firstName;
        private String _surName;
        private String _campus;
        private String _department;
        private String _cell;

        //Other variables
        private String _errorInformation;
        private String _tableName = "employees"; //Same as the table name in MS Access
        private DataRow _row;

        protected DataSet _dataset;  //This attribute is available to the sub classes

        //Constructor
        public Employees(String connString) : base(connString)
        {
            ClearField();

        }

        private void ClearField()
        {
            //Private Utility method used to initialize / clear the data elements
            _ID = 0;
            _ext = "";
            _campus = "";
            _department = "";
            _cell = "";
            _firstName = "";
            _surName = "";
            _dataset = null;
            _errorInformation = "";
            _row = null;
            //_tableName = "employees";
        }

        //Accessor and Setter Properties for the private variables
        public long ID
        {
            set
            {
                _ID = value;
            }
            get
            {
                return _ID;
            }
        }

        public String Ext
        {
            set
            {
                _ext = value;
            }
            get
            {
                return _ext;
            }
        }

        public String FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public String Campus
        {
            set
            {
                _campus = value;
            }
            get
            {
                return _campus;
            }
        }

        public String Department
        {
            set
            {
                _department = value;
            }
            get
            {
                return _department;
            }
        }

        public String Cell
        {
            set
            {
                _cell = value;
            }
            get
            {
                return _cell;
            }
        }

       
        public String Surname
        {
            set
            {
                _surName = value;
            }
            get
            {
                return _surName;
            }
        }

        
        public String ErrorInformation
        {
            //No Setters for this class. It has read only ability
            get
            {
                return _errorInformation;
            }
        }

        public String TableName
        {
            //No Setters for this class. It has read only ability
            get
            {
                return _tableName;
            }
        }

        public DataRow Row
        {
            set
            {
                _row = value;
            }
            get
            {
                return _row;
            }
        }

        public DataSet DataSet
        {
            //No Setters for this class. It has read only ability
            get
            {
                return _dataset;
            }
        }

        public void Load_Members(DataRow row)
        {
            //Method loads the private variables with data
            //from the database

            if (row["ID"] is DBNull)
                _ID = 0;
            else
                _ID = long.Parse(row["ID"].ToString());

            if (row["EXT"] is DBNull)
                _ext = "";
            else
                _ext = row["EXT"].ToString();

            if (row["FIRST_NAME"] is DBNull)
                _firstName = "";
            else
                _firstName = row["FIRST_NAME"].ToString();

            if (row["CAMPUS"] is DBNull)
                _campus = "";
            else
                _campus = row["CAMPUS"].ToString();

            if (row["DEPARTMENT"] is DBNull)
                _department = "";
            else
                _department = row["DEPARTMENT"].ToString();

            if (row["CELL"] is DBNull)
                _cell = "";
            else
                _cell = row["CELL"].ToString();

            if (row["SURNAME"] is DBNull)
                _surName = "";
            else
                _surName = row["SURNAME"].ToString();
            
        }

        public DataSet GetAll()
        {
            try
            {
                _dataset = GetData("SELECT * FROM " + _tableName, _tableName); //SQL Query
                return _dataset;
            }
            catch
            {
                _errorInformation = ExtendedErrorInformation;
                return null;
            }
        }

        //Methods for Add, Edit and Delete Functionality
        public bool Add()
        {
            try
            {
                String SQL;
                SQL = "INSERT INTO " + _tableName + " (" +
                    "ID, EXT, FIRST_NAME, SURNAME, CAMPUS, DEPARTMENT, CELL) VALUES (" +
                    "'" + _ID + "', '" +
                    _ext + "', '" +
                    _firstName + "', '" +
                    _surName + "', '" +
                    _campus + "', '" +
                    _department + "', '" +
                    _cell + "')";

                return ExecuteSQLStatement(SQL);
            }
            catch(Exception ex)
            {
                _errorInformation += ex.Message;
                return false;
            }
        }

        public bool Edit()
        {
            try
            {
                String SQL;
                SQL = "UPDATE " + _tableName + " SET " +
                    "ID = '" + _ID + "', " +
                    "EXT = '" + _ext + "', " +
                    "FIRST_NAME = '" + _firstName + "', " +
                    "SURNAME = '" + _surName + "', " +
                    "CAMPUS = '" + _campus + "', " +
                    "DEPARTMENT = '" + _department + "', " +
                    "CELL = '" + _cell + "' WHERE ID = " + _ID;

                return ExecuteSQLStatement(SQL);
            }
            catch(Exception ex)
            {
                _errorInformation = ex.Message;
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                String SQL;
                SQL = "DELETE FROM employees WHERE ID = " + _ID;
                return ExecuteSQLStatement(SQL);
            }
            catch(Exception ex)
            {
                _errorInformation = ex.Message;
                return false;
            }
        }

        public bool FindByID(long lNumber)
        {
            String SQL = "select * from employees where ID = " + lNumber;
            DataTable _currentDataTable = GetDataTable(SQL, "employees");

            if(_currentDataTable != null)
            {
                _row = _currentDataTable.Rows[0];
                Load_Members(_row);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet FindByFirstName(String empName)
        {
            try
            {
                _dataset = GetData("SELECT * FROM employees WHERE FIRST_NAME LIKE '%" + empName + "%'", "employees");
                return _dataset;
            }
            catch
            {
                _errorInformation = ExtendedErrorInformation;
                return null;
            }
        }
      

    }
}
