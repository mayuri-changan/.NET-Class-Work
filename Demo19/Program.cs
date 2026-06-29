using System.Security.Cryptography.X509Certificates;

namespace Demo19
{
    public delegate void ResultHandler(int mrk);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std= new Student();
            std._Pass += new ResultHandler(std.Pass_student);
            std._Fail += new ResultHandler(std.Fail_student);
            Console.WriteLine("Enter your marks");
            std.Mark=Convert.ToInt32(Console.ReadLine());


        }
    }
    public class Student
    {

        public event ResultHandler _Pass;
        public event ResultHandler _Fail;
        private int _Mark;
        public int Mark
        {
            set
            {
                _Mark = value;
                if (_Mark > 50)
                    _Pass(_Mark);
                else
                    _Fail(_Mark);

            }
            get
            {
                return _Mark;
            }
        }

        public void RaiseEvent(int mrk)
        {
            if (mrk > 50)
            {
                _Pass.Invoke(mrk);
            }
            else
            {
                _Fail(mrk);
            }
        }
    
        public void Pass_student(int mrk)
            {
            Console.WriteLine($"congratulations you are pass  with  {mrk}  marks");
            }
        public void Fail_student(int mrk)
        {
            Console.WriteLine($" you are fail with {mrk} marks");
        }
        }
        }



        
