using System.Reflection;
using Demo33;
namespace Demo35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string assemblyPath = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo34.1\bin\Debug\net8.0\Demo34.1.dll";
            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type[] alltypes = asm.GetTypes();

            for (int i = 0; i < alltypes.Length; i++)
            {
                Type type = alltypes[i]; // Emp

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];

                    if (attr is CompanyInfoAttribute)
                    {
                        CompanyInfoAttribute comp = attr as CompanyInfoAttribute;

                        Console.WriteLine($"Company Name: {comp.CompanyName}, Developer Name: {comp.DeveloperName}");
                    }
                }
            }
        }
    }
}
