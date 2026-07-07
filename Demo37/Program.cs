
using System.Diagnostics;
using System.Reflection;
using Demo36;


    internal class Program
    {
    static void Main(string[] args)
    {
        string assemblyPath = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo34.1\bin\Debug\net8.0\Demo34.1.dll";

        Assembly asm = Assembly.LoadFrom(assemblyPath);

        Type[] allTypes = asm.GetTypes();

        for (int i = 0; i < allTypes.Length; i++)
        {
            Type type = allTypes[i];

            Attribute[] attr = type.GetCustomAttributes().ToArray();

            string query = "CREATE TABLE ";

            for (int j = 0; j < attr.Length; j++)
            {
                Attribute currentAttr = attr[j];
                if (currentAttr is TableAttribute)
                {
                    TableAttribute table = currentAttr as TableAttribute;

                    query = query + table.TableName + "( ";
                }
            }

            PropertyInfo[] allProperties = type.GetProperties();

            for (int j = 0; j < allProperties.Length; j++)
            {
                PropertyInfo currentProp = allProperties[j];

                Attribute[] propAttr = currentProp.GetCustomAttributes().ToArray();
                for (int k = 0; k < propAttr.Length; k++)
                {
                    Attribute attribute = propAttr[k];
                    if (attribute is ColumnAttribute)
                    {
                        ColumnAttribute column = attribute as ColumnAttribute;

                      
                        query = query + column.ColumnName + " " + column.ColumnType + ",";
                    }
                }

            }
           

            query = query.TrimEnd(',') + ")";
            Console.WriteLine(query);

            File.WriteAllText(@"C:\Users\mayur\Desktop\.NET\CSharp1\Demo37\Sql\myquery.sql",query);
            Console.WriteLine("Done");
        }
    }
}

