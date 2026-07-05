using System.Reflection;
namespace Demo32


{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string assemblyPath = @"C:\Users\mayur\Desktop\.NET\CSharp1\Demo31\bin\Debug\net8.0\Demo31.dll";
            Assembly asm = Assembly.LoadFrom(assemblyPath);


            Type[] allTypes = asm.GetTypes();

            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];

                object dynamicallyCreatedObject = asm.CreateInstance(type.FullName); // Factory Method

                MethodInfo[] allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];

                    ParameterInfo[] allParameters = method.GetParameters();

                    object[] methodArguments = new object[allParameters.Length];

                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo currentParameter = allParameters[k];

                        Console.WriteLine($"Enter value for parameter {currentParameter.Name}: ");

                        string input = Console.ReadLine();
                        object? value = Convert.ChangeType(input, currentParameter.ParameterType);

                        methodArguments[k] = value;
                    }

                    
                    object? result = type.InvokeMember(
                        method.Name,
                        BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        methodArguments);

                    Console.WriteLine($"{method.Name} = {result}");

                }

            }
        }
    }
}
