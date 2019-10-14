using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finally.Repository
{
    public class TheRepository
    {
        OleDbConnection conn = new OleDbConnection();

        public Boolean ConnectionBuild(String Import_FileName)
        {
            string fileExtension = Path.GetExtension(Import_FileName);
            bool key = false;
            if (fileExtension == ".xls")
            {
                key = true;
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            }
            else if (fileExtension == ".xlsx")
            {
                key = true;
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            }
            else
            {
                return key;
            }
            return key;
        }
        public DataTable ShowDetails()
        {
            conn.Open();

            OleDbCommand command = new OleDbCommand
            (
                "SELECT * FROM [SHEET1$] ", conn
            );

            DataSet dsDvds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public Boolean UpdateDetails(String day,String text, String Import_FileName)
        {
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand
                 (
                     "UPDATE [SHEET1$] SET Day" + day + "='1' where ID='" + text + "'", conn
                 );

                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public String ShowName(String text)
        {
            conn.Open();

            OleDbCommand command0 = new OleDbCommand
            (
                "SELECT Name FROM [SHEET1$] Where ID='"+text+"'", conn
            );

            DataSet dsDvds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command0);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable.Rows[0][0].ToString();

        }
        public Boolean Check(String day)
        {
            conn.Open();

            OleDbCommand command0 = new OleDbCommand
            (
                "SELECT Day"+day+" FROM [SHEET1$] ", conn
            );

            try
            {
                DataSet dsDvds = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command0);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }

        }
    }
}
