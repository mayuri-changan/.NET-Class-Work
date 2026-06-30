namespace Demo22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Collection------");
            Book book=new Book();
            book.BookName = "Let us c";
            book.AuthorName = "Yashwant";
            Console.WriteLine(book.BookName);
            Console.WriteLine(book.AuthorName);

            

        }
        public class Book
        {
            private string _BookName;
            private string _AuthorName;
            public string AuthorName
            {
                get
                {
                    return _AuthorName;

                }
                set
                {
                    _AuthorName = value;
                }
            }
                public string BookName
                {
                get
                {
                    return _BookName;
                }
                set
                {
                    _BookName = value;

                }

                }

            }


        }
    }

