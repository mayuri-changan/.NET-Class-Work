using System.Diagnostics;
//using System.Security.Cryptography.X509Certificates;

namespace Demo46
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            #region
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.ManagedThreadId);
            #endregion

            #region Normal Method Call
            //Method1();
            //Method2(); t1.start();
            //Method3();
            #endregion

            #region Call to method by using Thread

            //Thread t1 = new Thread(Method1) { Name = "th 01" };
            //Thread t2 = new Thread(Method2) { Name = "th 02" };
            //Thread t3 = new Thread(Method3) { Name = "th 03" };

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //ThreadStart st = new ThreadStart(Method2);
            //Thread t2 = new Thread(st);

            #endregion

            #region isAlive and Join Method
            //F1();
            //F2();
            //Console.WriteLine("Main method execution started");
            //Thread t4 = new Thread(F1);
            //t4.Start();
            //Thread t5 = new Thread(F2);
            //t5.Start();

            //if (t4.Join(1000))
            //{
            //    Console.WriteLine("F1 execution complete");
            //}
            //t5.Join();
            //Console.WriteLine("F2 execution complete");

            //if (t4.IsAlive)
            //{
            //    Console.WriteLine("F1 execution is still going on");
            //}
            //else
            //{
            //    Console.WriteLine("F1 execution is complete");
            //}

            //Console.WriteLine("Main method execution complete");
            #endregion

            #region Normal Method Call: timetaken =146180 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    DoSomethingComplex();
            //}
            //watch.Stop();
            //Console.WriteLine($"Time taken= {watch.ElapsedTicks} ticks");
            #endregion

            #region using Thread and ThreadStart: timeTaken = 265109 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(DoSomethingComplex));
            //    t.Start();
            //}
            //watch.Stop();
            //Console.WriteLine($"Time taken= {watch.ElapsedTicks} ticks");
            #endregion

            #region using Thread and ThreadStart: timeTaken =  86947 
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 10; i++)
            {
                Task tsk = new Task(new Action(DoSomethingComplex));
                tsk.Start();
                Console.WriteLine($"Current task Id: {tsk.Id}");
            }
            watch.Stop();
            Console.WriteLine($"Time taken= {watch.ElapsedTicks} ticks");
            #endregion

            #region ParallelForEach - Implicit Parallel Programming
            // TPL - Task Parallel Library: System.Threading.Tasks
            // Time taken =   
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // Time taken =   255717 
            //foreach (var item in arr)
            //{
            //    Console.WriteLine($"Number: {item}, Thread id: {Thread.CurrentThread.ManagedThreadId}");
            //}
            // time taken =  
            Parallel.ForEach(arr, (item) =>
            {
                Console.WriteLine($"Number: {item},---Task Id :{Task.CurrentId}");
                //Console.WriteLine($"Number: {item},---Task Id :{Task.CurrentId},--- Thread id: {Thread.CurrentThread.ManagedThreadId}");
            });
            //Parallel.For();

            sw.Stop();
            Console.WriteLine($"Time Taken : {sw.ElapsedTicks} ticks");
            #endregion

            #region Parallel LINQ
            List<Emp> allEmployees = new List<Emp>() {
             new Emp(){ ID =11,Name ="Mayuri", Address ="Sangavi"},
             new Emp(){ ID =12,Name ="Priya", Address ="Aundh"},
             new Emp(){ ID =13,Name ="Swapnil", Address ="Wakad"},
             new Emp(){ ID =14,Name ="Tushar", Address ="Hinjewadi"},
             new Emp(){ ID =15,Name ="Tanu", Address ="kothrud"}
            };

            
            var result = (from emp in allEmployees.AsParallel()
                          where emp.Address.StartsWith("N")
                          select emp);

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Address: {emp.Address}");

            }

            #endregion

        }
        static void F1()
        {
            Console.WriteLine("F1 method execution started");
            Thread.Sleep(5000);
            Console.WriteLine("method F1 is awake");
            Console.WriteLine("F1 execution complete");
        }
        static void F2()
        {
            Console.WriteLine("F2 method execution started");
        }
        static void Method1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method1 - Count: {i}");
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method2 - Count: {i}");
            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method3 - Count: {i}");
            }
        }
        public static void DoSomethingComplex()
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    
                }
            }
        }
    }
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }


}

