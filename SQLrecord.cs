using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace WordRead
{
    class SQLrecord
    {
        private const string ConStr = @"Server=(local)\MILESGESQL;Database=mrcs;Integrated Security=true";
        private const string tblName = @"tblConvention";
        private SqlConnection connect;
        private SqlCommand mycmd;
        private SqlDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private DataTable myTable;
      
        public SQLrecord(string connectString = ConStr, string tableName = tblName)
        {
            try
            {           
                connect = new SqlConnection(connectString);
                connect.Open();//打开数据连接
                mycmd = new SqlCommand();
                mycmd.Connection = connect;
                mycmd.CommandType = CommandType.Text;
                mycmd.CommandText = @"select * from " + tableName;
                myDataAdapter = new SqlDataAdapter(mycmd);
                myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, tableName);
                myTable = myDataSet.Tables[tableName];
                Console.WriteLine( myTable.Rows[1]["Guid"].ToString());
            }
            catch(Exception err)
            {
                connect.Close();
                MessageBox.Show(err.Message);
            }
        }
        public void ins_Guid()
        {

        }

    }
}
