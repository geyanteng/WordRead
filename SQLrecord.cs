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
    class SQLUtils
    {
       // private const string ConStr = @"Server=(local)\MILESGESQL;Database=mrcs_0515;Integrated Security=true;";
        private const string ConStr = @"Server=(local);Database=mrcs_0515;Integrated Security=true;";
        private const string tblName = @"tblConvention";
        private SqlConnection connect;
        private SqlCommand mycmd;
        private SqlDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private DataTable myTable;
        private static SQLUtils sqlUtils;
        public bool isConnected;
        private SQLUtils(string connectString = ConStr, string tableName = tblName)
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
                isConnected = true;
                //Console.WriteLine( myTable.Rows[1]["Guid"].ToString());
            }
            catch (Exception err)
            {
                connect.Close();
                isConnected = false;
                MessageBox.Show(err.Message);
            }
        }
        public static SQLUtils getInstance()
        {
            if (sqlUtils == null)
                sqlUtils = new SQLUtils();
            return sqlUtils;
        }
        public void writeRow_local(ConventionRow conventionRow)
        {
            DataRow myRow = myTable.NewRow();
            myRow["Guid"] = conventionRow.Guid;
            myRow["Depth"] = conventionRow.Depth;
            myRow["ParentNodeGuid"] = conventionRow.ParentNodeGuid;
            myRow["Category"] = conventionRow.Category;
            myRow["TitleCn"] = conventionRow.TitleCn;
            myRow["TitleEn"] = conventionRow.TitleEn;
            myRow["TagCn"] = conventionRow.TagCn;
            //myRow["TagEn"] = conventionRow.TagEn;
            //myRow["QueryGuid"] = conventionRow.QueryGuid;
            //myRow["Note"] = conventionRow.Note;
            myRow["Display"] = conventionRow.Display;
            myRow["SequenceNumber"] = conventionRow.SequenceNumber;
            myRow["IDFolder"] = conventionRow.IDFolder;
            myRow["TitleCnFolder"] = conventionRow.TitleCnFolder;
            myRow["TitleEnFolder"] = conventionRow.TitleEnFolder;
            myRow["Purposes"] = conventionRow.Purposes;
            myRow["ShortTitleCn"] = conventionRow.ShortTitleCn;
            myRow["ShortTitleEn"] = conventionRow.ShortTitleEn;
            //myRow["LastEditDate"] = conventionRow.LastEditDate;
            //myRow["CreationDate"] = conventionRow.CreationDate;
            myRow["ConventionTypeKey"] = conventionRow.ConventionTypeKey;
            myTable.Rows.Add(myRow);
        }
        public void updateTable()
        {
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, "tblConvention");
            connect.Close();
            isConnected = false;
        }
    }
}
