using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;  //Allow connection of databases in MS Access

namespace RGI_EmployeeList_v1
{
    class DataLayer
    {
        private OleDbConnection _conn;
        private String _connString;
        private String _extendedErrorInformation;

        public DataLayer(String connString)
        {
            _connString = connString;
            _conn = new OleDbConnection(_connString);
        }

        //Accessors and Setters using Properties
        public String ConnectionString
        {
            set
            {
                _connString = value;
            }

            get
            {
                return _connString;
            }
        }

        public String ExtendedErrorInformation
        {
            set
            {
                _extendedErrorInformation = value;
            }

            get
            {
                return _extendedErrorInformation;
            }
        }

        //Methods to execute against the database
        public bool ExecuteSQLStatement(String SQL)
        {
            OleDbCommand command = new OleDbCommand();
            try
            {
                command.Connection = _conn;
                command.CommandType = CommandType.Text;
                command.CommandText = SQL;

                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();

                command.ExecuteNonQuery(); //Doesn't return a result==>Update, Delete, Insert eg

                return true;
            }
            catch(Exception ex)
            {
                _extendedErrorInformation = ex.Message;
                return false;
            }

        }

        public DataTable GetDataTable(String SQL, String TableName)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQL, _conn);

            try
            {
                _conn.Open();
                DataAdapter.Fill(ds, TableName);
                DataTable dt = ds.Tables[TableName];
                return dt;
            }
            catch(Exception ex)
            {
                _extendedErrorInformation = ex.Message;
                return null;
            }
        }

        //Following method is very similar to previous method. This loads the dataset
        public DataSet GetData(String SQL, String TableName)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQL, _conn);

            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                DataAdapter.Fill(ds, TableName);
                return ds;
            }
            catch (Exception ex)
            {
                _extendedErrorInformation = ex.Message;
                return null;
            }
        }

    }
}
