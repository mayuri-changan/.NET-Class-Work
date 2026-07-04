using System.Net;
using System.Xml.Linq;


namespace Demo28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================ FILE IO =================\n");

            string filePath = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo28\Data\data.txt";
            string filePath1 = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo28\Data\emp.txt";

            FileStream fs = null;

            // Write to data.txt
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("Welcome to File IO");

            writer.Flush();
            writer.Close();
            fs.Close();

            Console.WriteLine("Data written successfully.");

            // Read from data.txt
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(fs);

                string data = reader.ReadToEnd();

                reader.Close();
                fs.Close();

                Console.WriteLine("\nContents of data.txt:");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("data.txt does not exist.");
            }

            // Write Employee data to emp.txt
            if (File.Exists(filePath1))
            {
                fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath1, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writer1 = new StreamWriter(fs);

            Emp emp = new Emp();
            emp.Id = 555;
            emp.Name = "Hugh Jackman";
            emp.Address = "NYC";

            writer1.WriteLine($"{emp.Id}, {emp.Name}, {emp.Address}");

            writer1.Flush();
            writer1.Close();
            fs.Close();

            Console.WriteLine("Employee data written successfully.");
        }
    }

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetEmpDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Address: {Address}");
        }
    }
}