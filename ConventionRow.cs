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
    class ConventionRow
    {
        public const int FIELDCOUNT= 21;//一条公约记录的字段数
        private void ConventionRow_Init()
        {
            this._Purposes = 0;
            this._Display = (int)ConventionOptions.DISPLAY.IS_DISPLAY;
            this._ConventionTypeKey = 3;
        }
        public ConventionRow(string titleCn, ConventionOptions.CATEGORY category)
        {
            this._TitleCn = this._TitleEn = this._ShortTitleCn = this._ShortTitleEn = titleCn;
            this._Category = (int)category;
            this._Guid = Guid.NewGuid();
            ConventionRow_Init();
        }
        public ConventionRow(ConventionOptions.CATEGORY category)
        {
            this._Category = (int)category;
            this._Guid = Guid.NewGuid();
            ConventionRow_Init();
        }
        //用于创建根节点
        public ConventionRow(Guid guid,int depth,string IDfolder,string titlecnfolder)
        {
            this._Category = (int)ConventionOptions.CATEGORY.IS_CATEGORY;
            this._Guid = guid;
            this._Depth = depth;
            ConventionRow_Init();
            this._IDFolder = IDfolder;
            this._TitleCnFolder = this._TitleEnFolder = titlecnfolder;
        }
        public ConventionRow(Guid parentNodeGuid, int depth, string titleCn,
            int sequenceNumber, ConventionOptions.CATEGORY category)
        {
            this._TitleCn = this._TitleEn = this._ShortTitleCn = this._ShortTitleEn = titleCn;
            this._Category = (int)category;
            this._Guid = Guid.NewGuid();
            ConventionRow_Init();
            this._ParentNodeGuid = parentNodeGuid;
            this._SequenceNumber = sequenceNumber;
            this._Depth = depth;
        }
        //ConventionRow parentConventionRow,
        public ConventionRow(ConventionRow parentConventionRow, string titleCn,
            int sequenceNumber, ConventionOptions.CATEGORY category,string tagcn=null)
        {
            this._TitleCn = this._TitleEn = this._ShortTitleCn = this._ShortTitleEn = titleCn;
            this._Category = (int)category;
            this._Guid = Guid.NewGuid();
            ConventionRow_Init();
            this._ParentNodeGuid = parentConventionRow.Guid;
            this._SequenceNumber = sequenceNumber;
            this._Depth = parentConventionRow.Depth+1;
            this._IDFolder = parentConventionRow.IDFolder + "#" + this.Guid;
            this._TitleCnFolder = this._TitleEnFolder=parentConventionRow.TitleCnFolder + "#@`" + this.TitleCn;
            this._TagCn  = tagcn; 
        }
        public ConventionRow(Guid parentNodeGuid, int depth, string titleCn,
         int sequenceNumber, ConventionOptions.CATEGORY category,string idfolder,string titlecnfolder)
        {
            this._TitleCn = this._TitleEn = this._ShortTitleCn = this._ShortTitleEn = titleCn;
            this._Category = (int)category;
            this._Guid = Guid.NewGuid();
            ConventionRow_Init();
            this._ParentNodeGuid = parentNodeGuid;
            this._SequenceNumber = sequenceNumber;
            this._Depth = depth;
            this._IDFolder = idfolder;
            this._TitleCnFolder =this._TitleEnFolder= titlecnfolder;
        }
        private Guid _Guid;
        public Guid Guid
        {
            get { return _Guid; }
            /*set{
                if (value.GetType().ToString() != "Guid")
                    throw new ArgumentException("value", "输入值不是Guid数据类型");
                _Guid = value;
            }*/
        }
        private int _Depth;
        public int Depth
        {
            get { return _Depth; }
            set
            {
                if (value.GetType().ToString() != "int" || value < 0)
                    throw new ArgumentException("value", "输入值不是int数据类型或小于0");
                _Depth = value;
            }
        }
        private Guid _ParentNodeGuid;
        public Guid ParentNodeGuid
        {
            get { return _ParentNodeGuid; }
            set
            {
                //if (value.GetType().ToString() != "Guid")
                //    throw new ArgumentException("value", "输入值不是Guid数据类型");
                _ParentNodeGuid = value;
            }
        }
        private int _Category;
        public int Category
        {
            get { return _Category; }
            set
            {
                if (value != 1 || value != 2)
                    throw new ArgumentException("value", "Category只能为1或2");
                _Category = value;
            }
        }
        private string _TitleCn;
        public string TitleCn
        {
            get { return _TitleCn; }
            set { _TitleCn = value; }
        }
        private string _TitleEn;
        public string TitleEn
        {
            get { return _TitleEn; }
            set { _TitleEn = value; }
        }
        private string _TagCn;
        public string TagCn
        {
            get { return _TagCn; }
            set { _TagCn = value; }
        }
        //private string _TagEn;
        //public string TagEn
        //{
        //    get { return _TagEn; }
        //    set { _TagEn = value; }
        //}
        //private Guid _QueryGuid;
        //public Guid QueryGuid
        //{
        //    get { return _QueryGuid; }
        //    set { 
        //        if(value!=null||value.GetType().ToString()!="Guid")
        //            throw new ArgumentException("value", "输入值非空或不是Guid数据类型");
        //        _QueryGuid = value; }
        //}
        //private string _Note;
        //public string Note
        //{
        //    get { return _Note; }
        //    set { _Note = value; }
        //}
        private int _Display;
        public int Display
        {
            get { return _Display; }
            set
            {
                if (value != 0 || value != 1)
                    throw new ArgumentException("value", "必须为0或1");
                _Display = value;
            }
        }
        private int _SequenceNumber;
        public int SequenceNumber
        {
            get { return _SequenceNumber; }
            set { _SequenceNumber = value; }
        }
        private string _IDFolder;
        public string IDFolder
        {
            get { return _IDFolder; }
            set { _IDFolder = value; }
        }
        private string _TitleCnFolder;
        public string TitleCnFolder
        {
            get { return _TitleCnFolder; }
            set { _TitleCnFolder = value; }
        }
        private string _TitleEnFolder;
        public string TitleEnFolder
        {
            get { return _TitleEnFolder; }
            set { _TitleEnFolder = value; }
        }
        private int _Purposes;
        public int Purposes
        {
            get { return _Purposes; }
            set { _Purposes = value; }
        }
        private string _ShortTitleCn;
        public string ShortTitleCn
        {
            get { return _ShortTitleCn; }
            set { _ShortTitleCn = value; }
        }
        private string _ShortTitleEn;
        public string ShortTitleEn
        {
            get { return _ShortTitleEn; }
            set { _ShortTitleEn = value; }
        }
        private int _ConventionTypeKey;
        public int ConventionTypeKey
        {
            get { return _ConventionTypeKey; }
            set { _ConventionTypeKey = value; }
        }
//         private DateTime _LastEditDate;
//         public DateTime LastEditDate
//         {
//             get { return _LastEditDate; }
//             set { _LastEditDate = value; }
//         }
//         private DateTime _CreationDate;
//         public DateTime CreationDate
//         {
//             get { return _CreationDate; }
//             set { _CreationDate = value; }
//         }
    }
}