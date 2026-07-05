using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Demo30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Id = 10;
            emp.Name = "Mayuri Changan";
            emp.Address = "Navi Sangavi,Pune";

            string filepath = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo28\Data\empdata.xml";
            string filepath2 = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo28\Data\empdata.json";

            FileStream fs = null;

            #region XML Serialization

            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            XmlSerializer xr = new XmlSerializer(typeof(Emp));
            xr.Serialize(fs, emp);

            fs.Close();

            Console.WriteLine("XML Serialization Done");

            #endregion

            #region JSON Serialization

            if (File.Exists(filepath2))
            {
                fs = new FileStream(filepath2, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath2, FileMode.OpenOrCreate, FileAccess.Write);
            }

            JsonSerializer.Serialize(fs, emp);

            fs.Close();

            Console.WriteLine("JSON Serialization Done");

            #endregion

            #region JSON DeSerialization

            if (File.Exists(filepath2))
            {
                fs = new FileStream(filepath2, FileMode.Open, FileAccess.Read);

                Emp emp1 = JsonSerializer.Deserialize<Emp>(fs);

                fs.Close();

                if (emp1 != null)
                {
                    emp1.GetEmpDetails();
                }
            }
            else
            {
                Console.WriteLine("File does not exist!!");
            }

            #endregion
        }
    }

    public class Emp
    {
        private int _EID;
        private string _EName;
        private string _EAddress;

        public int Id
        {
            get { return _EID; }
            set { _EID = value; }
        }

        // JsonIgnore ki wajah se Name JSON me save nahi hoga
        [JsonIgnore]
        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }

        public void GetEmpDetails()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Address : {Address}");
        }
    }
}