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
        public  string ConStr = @"server=60.30.247.219;database=MRCS_0515;uid=pscadmin1;pwd=http://psc20131105;Connect Timeout=900";
        //public string ConStr = @"Server=(local)\MILESGESQL;Database=mrcs_0515;Integrated Security=true;";
        //public string ConStr = @"Server=(local);Database=mrcs_0515;Integrated Security=true;";
        private const string tblName = @"tblConvention";
        public  SqlConnection connect;
        private SqlCommand mycmd;
        private SqlDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private DataTable myTable;
        private static SQLUtils sqlUtils;
        public bool isConnected;
        private SQLUtils()
        {
            
        }
        /// <summary>
        /// 单例模式，获取实例
        /// </summary>
        /// <returns></returns>
        public static SQLUtils getInstance()
        {
            if (sqlUtils == null)
                sqlUtils = new SQLUtils();
            return sqlUtils;
        }
        public DataRow getInfo(Guid parentNodeGuid)
        {
            connect = new SqlConnection(ConStr);
            connect.Open();//打开数据连接
            mycmd = new SqlCommand();
            mycmd.Connection = connect;
            mycmd.CommandType = CommandType.Text;
            mycmd.CommandText = "select * from " + tblName + " where guid='"+ parentNodeGuid.ToString()+"'";
            myDataAdapter = new SqlDataAdapter(mycmd);
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet, tblName);
            DataTable table = dataSet.Tables[tblName];
            DataRow myRow = table.NewRow();
            return table.Rows[0];           
        }
        public void makeConnect()
        {
            try
            {
                connect = new SqlConnection(ConStr);
                connect.Open();//打开数据连接
                mycmd = new SqlCommand();
                mycmd.Connection = connect;
                mycmd.CommandType = CommandType.Text;
                mycmd.CommandText = "select * from " + tblName+" where guid="+ "'aa9059c8-c980-449d-beb3-33e98c34a7a8'";
                myDataAdapter = new SqlDataAdapter(mycmd);
                myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, tblName);
                myTable = myDataSet.Tables[tblName];
                isConnected = true;
            }
            catch (Exception err)
            {
                connect.Close();
                isConnected = false;
                Console.WriteLine(err.Message);
            }
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
