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
        public string ConStr = @"server=60.30.247.219;database=MRCS_0515;uid=pscadmin1;pwd=http://psc20131105;Connect Timeout=900";
        //public string ConStr = @"Server=(local)\MILESGESQL;Database=mrcs_0515;Integrated Security=true;";
        public string ConStrLocal = @"Server=(local);Database=mrcs_0515;Integrated Security=true;";
        private string tblName = @"tblConvention";
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
        /// <summary>
        /// 根据Guid获取一条记录。用来获取根节点信息
        /// </summary>
        /// <param name="parentNodeGuid"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 连接数据库，创建本地myTable
        /// </summary>
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
        /// <summary>
        /// 向本地myTable中写入一条记录。
        /// </summary>
        /// <param name="conventionRow"></param>
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
        /// <summary>
        /// 提交myTable到数据库，更新数据
        /// </summary>
        public void updateTable()
        {
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, "tblConvention");
            connect.Close();
            isConnected = false;
        }
        /// <summary>
        /// 根据父节点列表删除各父节点下的子节点
        /// </summary>
        /// <param name="parentGuids"></param>
        public bool executeDelete(List<Guid> parentGuids)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand();
                SqlConnection conn = new SqlConnection(ConStr);
                sqlComm.Connection = conn;
                foreach (var each in parentGuids)
                {
                    sqlComm.CommandText = "delete from " + tblName + " where ParentNodeGuid = '" + each + "'";
                    sqlComm.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 删除一个父节点下的子节点
        /// </summary>
        /// <param name="parentGuid"></param>
        public bool executeDelete(Guid parentGuid)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand();
                SqlConnection conn = new SqlConnection(ConStr);
                sqlComm.Connection = conn;
                sqlComm.CommandText = "delete from " + tblName + " where ParentNodeGuid = '" + parentGuid + "'";
                sqlComm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 执行一条sql指令
        /// </summary>
        /// <param name="strCmd"></param>
        /// <returns></returns>
        public bool executeCommand(string strCmd)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand();
                SqlConnection conn = new SqlConnection(ConStr);
                sqlComm.Connection = conn;
                sqlComm.CommandText = strCmd;
                sqlComm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void updateData()
        {
            try
            {
                string tableName = "tblConventionQuery";
                SqlConnection sqlconnect = new SqlConnection(ConStrLocal);
                sqlconnect.Open();//打开数据连接
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconnect;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "select * from " + tableName;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcmd);
                DataSet sqlDataSet = new DataSet();
                sqlDataAdapter.Fill(sqlDataSet, tableName);
                DataTable sqlTable = sqlDataSet.Tables[tableName];
                for (int i=0;i<sqlTable.Rows.Count;i++)
                {
                    string GTLimit = sqlTable.Rows[i]["GTLimit"].ToString();
                    string regExp_9999 = @"9{4,}";
                    Regex reg = new Regex(regExp_9999);
                    Match match = reg.Match(GTLimit);
                    if (match.Length > 0)
                    {
                        sqlTable.Rows[i]["GTLimit"] = null;
                    }
                }                
                // 将DataSet的修改提交至“数据库”
                SqlCommandBuilder sqlSqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(sqlDataSet, tableName);
            }
            catch (Exception err)
            {            
                Console.WriteLine(err.Message);
            }
        }
        public void conventionCount(TreeView treeConventionCount)
        {
            try
            {
                string tableName = "tblConvention";
                SqlConnection sqlconnect = new SqlConnection(ConStrLocal);
                sqlconnect.Open();//打开数据连接
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconnect;
                sqlcmd.CommandType = CommandType.Text;
                DataSet sqlDataSet = new DataSet();
                sqlcmd.CommandText = "select Guid,ParentNodeGuid,TitleEn,ShortTitleEn from " + tableName;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcmd);
                sqlDataAdapter.Fill(sqlDataSet, tableName);
                DataTable tblAllData = sqlDataSet.Tables[tableName];
                //add root node of the convention tree
                string rootGuid = "fa6fe77d-7a97-4735-9da2-cd54c1c5fdcd";
                sqlcmd.CommandText = "select * from " + tableName + " where Guid='"+rootGuid+"'";
                sqlDataAdapter.Fill(sqlDataSet, "tblResult");
                DataTable tblResult = sqlDataSet.Tables["tblResult"];
                Tree<DataRow> treeConventionRow = new Tree<DataRow>(tblResult.Rows[0]);
                tblResult.Reset();

                sqlcmd.CommandText = "select * from " + tableName + " where ParentNodeGuid='" + rootGuid + "'";
                sqlDataAdapter.Fill(sqlDataSet, "tblResult");
                for(int i=0;i< tblResult.Rows.Count; i++)
                {             
                    Tree<DataRow> node = new Tree<DataRow>(tblResult.Rows[i]);
                    treeConventionRow.AddNode(node);
                    string Guid = node.Data["Guid"].ToString();
                    sqlcmd.CommandText = "select * from " + tableName + " where ParentNodeGuid='" + Guid + "'";
                    sqlDataAdapter.Fill(sqlDataSet, "tblResult_" + i);
                    DataTable tblResult_i = sqlDataSet.Tables["tblResult_" + i];
                    for (int j=0;j< tblResult_i.Rows.Count; j++)
                    {
                        Tree<DataRow> node1 = new Tree<DataRow>(tblResult_i.Rows[j]);
                        node.AddNode(node1);
                        string Guid1 = node1.Data["Guid"].ToString();
                        sqlcmd.CommandText = "select * from " + tableName + " where ParentNodeGuid='" + Guid1 + "'";
                        sqlDataAdapter.Fill(sqlDataSet, "tblResult_" + i+"_"+j);
                        DataTable tblResult_i_j = sqlDataSet.Tables["tblResult_" + i + "_" + j];
                        for(int k=0;k< tblResult_i_j.Rows.Count; k++)
                        {
                            Tree<DataRow> node2 = new Tree<DataRow>(tblResult_i_j.Rows[k]);
                            node1.AddNode(node2);
                            string Guid2 = node2.Data["Guid"].ToString();
                            sqlcmd.CommandText = "select * from " + tableName + " where ParentNodeGuid='" + Guid2 + "'";
                            sqlDataAdapter.Fill(sqlDataSet, "tblResult_" + i + "_" + j+"_"+k);
                            DataTable tblResult_i_j_k = sqlDataSet.Tables["tblResult_" + i + "_" + j + "_" + k];
                            for (int l = 0; l < tblResult_i_j_k.Rows.Count; l++)
                            {
                                Tree<DataRow> node3 = new Tree<DataRow>(tblResult_i_j_k.Rows[l]);
                                node2.AddNode(node3);
                                string Guid3 = node3.Data["Guid"].ToString();
                                sqlcmd.CommandText = "select * from " + tableName + " where ParentNodeGuid='" + Guid3 + "'";
                                sqlDataAdapter.Fill(sqlDataSet, "tblResult_" + i + "_" + j + "_" + k+"_"+l);
                                DataTable tblResult_i_j_k_l = sqlDataSet.Tables["tblResult_" + i + "_" + j + "_" + k+"_"+l];
                                for (int m = 0; m < tblResult_i_j_k_l.Rows.Count; m++)
                                {
                                    Tree<DataRow> node4 = new Tree<DataRow>(tblResult_i_j_k_l.Rows[m]);
                                    node3.AddNode(node4);
                                }
                            }
                        }
                    }
                }
                TreeNode viewNode0 = new TreeNode(treeConventionRow.NodeNumber + " : origin convention");
                treeConventionCount.Nodes.Add(viewNode0);
                for(int i = 0; i < treeConventionRow.NodeNumber; i++)
                {
                    Tree<DataRow> node1 = treeConventionRow.Nodes[i];
                    string title1 = node1.Data["ShortTitleEn"].ToString();
                    if (title1 == string.Empty)
                        title1 = node1.Data["TitleEn"].ToString();
                    TreeNode viewNode1 = new TreeNode(node1.NodeNumber + " : " + title1);
                    viewNode0.Nodes.Add(viewNode1);
                    for (int j = 0; j < node1.NodeNumber; j++)
                    {
                        Tree<DataRow> node2 = node1.Nodes[j];
                        string title2 = node2.Data["TitleEn"].ToString();
                        TreeNode viewNode2 = new TreeNode(node2.NodeNumber + " : " + title2);
                        viewNode1.Nodes.Add(viewNode2);
                        for (int k = 0; k < node2.NodeNumber; k++)
                        {
                            Tree<DataRow> node3 = node2.Nodes[k];
                            string title3 = node3.Data["TitleEn"].ToString();
                            TreeNode viewNode3 = new TreeNode(node3.NodeNumber + " : " + title3);
                            viewNode2.Nodes.Add(viewNode3);
                            for (int l = 0; l < node3.NodeNumber; l++)
                            {
                                Tree<DataRow> node4 = node3.Nodes[l];
                                string title4 = node4.Data["TitleEn"].ToString();
                                TreeNode viewNode4 = new TreeNode(node4.NodeNumber + " : " + title4);
                                viewNode3.Nodes.Add(viewNode4);
                            }
                        }
                    }
                }                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}