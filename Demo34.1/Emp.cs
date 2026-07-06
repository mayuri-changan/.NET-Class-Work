using Demo33;
using System.Text.Json.Serialization;
using Demo36;

namespace Demo34._1
{
    [Table(TableName = "Emp")]
    public class Emp
    {
        
        
            private int _EId;
            private string _EName;
            private string _EAddress;

        [Column(ColumnName = "Id", ColumnType = "int")]
        public int EId
            {
                get { return _EId; }
                set { _EId = value; }
            }
        [Column(ColumnName = "Name", ColumnType = "varchar(50)")]
        public string Ename
            {
                get { return _EName; }
                set { _EName = value; }
            }
        [Column(ColumnName = "Address", ColumnType = "varchar(50)")]
        public string EAddress
            {
                get { return _EAddress; }
                set { _EAddress = value; }
            }

        }
    }


