namespace Q5_101LINQQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            List<Student> students = new List<Student>()
        {
            new Student { Id = 101, Name = "Mayuri", Department = "IT", Marks = 85 },
            new Student { Id = 102, Name = "Rahul", Department = "HR", Marks = 70 },
            new Student { Id = 103, Name = "Amit", Department = "IT", Marks = 92 },
            new Student { Id = 104, Name = "Sneha", Department = "Sales", Marks = 65 },
            new Student { Id = 105, Name = "Pooja", Department = "IT", Marks = 78 }
        };
            List<Department> departments = new List<Department>()
        {
        new Department { DepartmentName = "IT", Manager = "Mr. Sharma" },
        new Department { DepartmentName = "HR", Manager = "Mrs. Joshi" },
        new Department { DepartmentName = "Sales", Manager = "Mr. Patil" }
        };

            // Query 1
            Console.WriteLine("\n========== Query 1 : Display All Students ==========");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Department} {s.Marks}");
            }

            // Query 2
            Console.WriteLine("\n========== Query 2 : Marks > 75 ==========");
            var q2 = students.Where(s => s.Marks > 75);
            foreach (var s in q2)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 3
            Console.WriteLine("\n========== Query 3 : IT Department ==========");
            var q3 = students.Where(s => s.Department == "IT");
            foreach (var s in q3)
            {
                Console.WriteLine($"{s.Name}");
            }

            // Query 4
            Console.WriteLine("\n========== Query 4 : Name Starts With 'A' ==========");
            var q4 = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in q4)
            {
                Console.WriteLine(s.Name);
            }

            // Query 5
            Console.WriteLine("\n========== Query 5 : Sort By Marks ==========");
            var q5 = students.OrderBy(s => s.Marks);
            foreach (var s in q5)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 6
            Console.WriteLine("\n========== Query 6 : Sort By Marks Descending ==========");
            var q6 = students.OrderByDescending(s => s.Marks);
            foreach (var s in q6)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 7
            Console.WriteLine("\n========== Query 7 : Total Students ==========");
            Console.WriteLine(students.Count());

            // Query 8
            Console.WriteLine("\n========== Query 8 : Highest Marks ==========");
            Console.WriteLine(students.Max(s => s.Marks));

            // Query 9
            Console.WriteLine("\n========== Query 9 : Lowest Marks ==========");
            Console.WriteLine(students.Min(s => s.Marks));

            // Query 10
            Console.WriteLine("\n========== Query 10 : Average Marks ==========");
            Console.WriteLine(students.Average(s => s.Marks));
            // Query 11
            Console.WriteLine("\n========== Query 11 : Sum of Marks ==========");
            Console.WriteLine(students.Sum(s => s.Marks));
            // Query 12
            Console.WriteLine("\n========== Query 12 : First Student ==========");
            Console.WriteLine(students.First().Name);
            // Query 13
            Console.WriteLine("\n========== Query 13 : Last Student ==========");
            Console.WriteLine(students.Last().Name);

            // Query 14
            Console.WriteLine("\n========== Query 14 : Student with ID 103 ==========");
            var q14 = students.FirstOrDefault(s => s.Id == 103);

            if (q14 != null)
            {
                Console.WriteLine($"{q14.Id} {q14.Name} {q14.Department} {q14.Marks}");
            }

            // Query 15
            Console.WriteLine("\n========== Query 15 : Any Student Scored More Than 90 ==========");
            Console.WriteLine(students.Any(s => s.Marks > 90));

            // Query 16
            Console.WriteLine("\n========== Query 16 : All Students Passed ==========");
            Console.WriteLine(students.All(s => s.Marks >= 40));

            // Query 17
            Console.WriteLine("\n========== Query 17 : Display Only Student Names ==========");
            var q17 = students.Select(s => s.Name);

            foreach (var name in q17)
            {
                Console.WriteLine(name);
            }

            // Query 18
            Console.WriteLine("\n========== Query 18 : Display Name and Marks ==========");
            var q18 = students.Select(s => new { s.Name, s.Marks });

            foreach (var item in q18)
            {
                Console.WriteLine($"{item.Name} {item.Marks}");
            }

            // Query 19
            Console.WriteLine("\n========== Query 19 : Distinct Departments ==========");
            var q19 = students.Select(s => s.Department).Distinct();

            foreach (var dept in q19)
            {
                Console.WriteLine(dept);
            }

            // Query 20
            Console.WriteLine("\n========== Query 20 : First Three Students ==========");
            var q20 = students.Take(3);

            foreach (var s in q20)
            {
                Console.WriteLine($"{s.Name}");
            }

            // Query 21
            Console.WriteLine("\n========== Query 21 : Skip First Two Students ==========");
            var q21 = students.Skip(2);

            foreach (var s in q21)
            {
                Console.WriteLine($"{s.Name}");
            }

            // Query 22
            Console.WriteLine("\n========== Query 22 : Students Between 70 and 90 Marks ==========");
            var q22 = students.Where(s => s.Marks >= 70 && s.Marks <= 90);

            foreach (var s in q22)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 23
            Console.WriteLine("\n========== Query 23 : Group Students By Department ==========");
            var q23 = students.GroupBy(s => s.Department);

            foreach (var group in q23)
            {
                Console.WriteLine("\nDepartment : " + group.Key);

                foreach (var s in group)
                {
                    Console.WriteLine($"{s.Name} {s.Marks}");
                }
            }

            // Query 24
            Console.WriteLine("\n========== Query 24 : Student Names in Alphabetical Order ==========");
            var q24 = students.OrderBy(s => s.Name);

            foreach (var s in q24)
            {
                Console.WriteLine(s.Name);
            }

            // Query 25
            Console.WriteLine("\n========== Query 25 : Student with Highest Marks ==========");
            var q25 = students.OrderByDescending(s => s.Marks).First();
            Console.WriteLine($"{q25.Name} {q25.Marks}");
            // Query 26
            Console.WriteLine("\n========== Query 26 : Reverse Order ==========");
            var q26 = students.AsEnumerable().Reverse();
            foreach (var s in q26)
                Console.WriteLine(s.Name);

            // Query 27
            Console.WriteLine("\n========== Query 27 : Contains Department IT ==========");
            Console.WriteLine(students.Select(s => s.Department).Contains("IT"));

            // Query 28
            Console.WriteLine("\n========== Query 28 : Student Names in Uppercase ==========");
            var q28 = students.Select(s => s.Name.ToUpper());
            foreach (var name in q28)
                Console.WriteLine(name);

            // Query 29
            Console.WriteLine("\n========== Query 29 : Student Names in Lowercase ==========");
            var q29 = students.Select(s => s.Name.ToLower());
            foreach (var name in q29)
                Console.WriteLine(name);

            // Query 30
            Console.WriteLine("\n========== Query 30 : Name Length ==========");
            var q30 = students.Select(s => new { s.Name, Length = s.Name.Length });
            foreach (var s in q30)
                Console.WriteLine($"{s.Name} : {s.Length}");

            // Query 31
            Console.WriteLine("\n========== Query 31 : Even Marks ==========");
            var q31 = students.Where(s => s.Marks % 2 == 0);
            foreach (var s in q31)
                Console.WriteLine($"{s.Name} {s.Marks}");

            // Query 32
            Console.WriteLine("\n========== Query 32 : Odd Marks ==========");
            var q32 = students.Where(s => s.Marks % 2 != 0);
            foreach (var s in q32)
                Console.WriteLine($"{s.Name} {s.Marks}");

            // Query 33
            Console.WriteLine("\n========== Query 33 : Marks >= 80 ==========");
            var q33 = students.Where(s => s.Marks >= 80);
            foreach (var s in q33)
                Console.WriteLine($"{s.Name} {s.Marks}");

            // Query 34
            Console.WriteLine("\n========== Query 34 : Name Contains 'a' ==========");
            var q34 = students.Where(s => s.Name.ToLower().Contains("a"));
            foreach (var s in q34)
                Console.WriteLine(s.Name);

            // Query 35
            Console.WriteLine("\n========== Query 35 : Department = HR ==========");
            var q35 = students.Where(s => s.Department == "HR");
            foreach (var s in q35)
                Console.WriteLine(s.Name);

            // Query 36
            Console.WriteLine("\n========== Query 36 : Second Student ==========");
            Console.WriteLine(students.Skip(1).First().Name);

            // Query 37
            Console.WriteLine("\n========== Query 37 : Last Two Students ==========");
            var q37 = students.Skip(students.Count - 2);
            foreach (var s in q37)
                Console.WriteLine(s.Name);

            // Query 38
            Console.WriteLine("\n========== Query 38 : Top Two Highest Marks ==========");
            var q38 = students.OrderByDescending(s => s.Marks).Take(2);
            foreach (var s in q38)
                Console.WriteLine($"{s.Name} {s.Marks}");

            // Query 39
            Console.WriteLine("\n========== Query 39 : Lowest Two Marks ==========");
            var q39 = students.OrderBy(s => s.Marks).Take(2);
            foreach (var s in q39)
                Console.WriteLine($"{s.Name} {s.Marks}");

            // Query 40
            Console.WriteLine("\n========== Query 40 : Student Count in IT ==========");
            Console.WriteLine(students.Count(s => s.Department == "IT"));

            // Query 41
            Console.WriteLine("\n========== Query 41 : Total Marks of IT Students ==========");
            Console.WriteLine(students.Where(s => s.Department == "IT").Sum(s => s.Marks));

            // Query 42
            Console.WriteLine("\n========== Query 42 : Average Marks of IT Students ==========");
            Console.WriteLine(students.Where(s => s.Department == "IT").Average(s => s.Marks));

            // Query 43
            Console.WriteLine("\n========== Query 43 : Highest Marks in IT ==========");
            Console.WriteLine(students.Where(s => s.Department == "IT").Max(s => s.Marks));

            // Query 44
            Console.WriteLine("\n========== Query 44 : Lowest Marks in IT ==========");
            Console.WriteLine(students.Where(s => s.Department == "IT").Min(s => s.Marks));

            // Query 45
            Console.WriteLine("\n========== Query 45 : Students Sorted by Department ==========");
            var q45 = students.OrderBy(s => s.Department);
            foreach (var s in q45)
                Console.WriteLine($"{s.Department} - {s.Name}");

            // Query 46
            Console.WriteLine("\n========== Query 46 : Sort by Department Then Marks ==========");
            var q46 = students.OrderBy(s => s.Department)
                              .ThenByDescending(s => s.Marks);
            foreach (var s in q46)
                Console.WriteLine($"{s.Department} {s.Name} {s.Marks}");

            // Query 47
            Console.WriteLine("\n========== Query 47 : First Student in IT ==========");
            var q47 = students.FirstOrDefault(s => s.Department == "IT");
            Console.WriteLine($"{q47.Name}");

            // Query 48
            Console.WriteLine("\n========== Query 48 : Student IDs ==========");
            var q48 = students.Select(s => s.Id);
            foreach (var id in q48)
                Console.WriteLine(id);

            // Query 49
            Console.WriteLine("\n========== Query 49 : Students Passing (>40) ==========");
            var q49 = students.Where(s => s.Marks > 40);
            foreach (var s in q49)
                Console.WriteLine($"{s.Name}");

            // Query 50
            Console.WriteLine("\n========== Query 50 : Display Student Details ==========");
            foreach (var s in students)
            {
                Console.WriteLine($"ID:{s.Id} Name:{s.Name} Dept:{s.Department} Marks:{s.Marks}");

            }
            // Query 51
            Console.WriteLine("\n========== Query 51 : Concat ==========");

            List<Student> students2 = new List<Student>()
{
    new Student{Id=106,Name="Rohit",Department="HR",Marks=81},
    new Student{Id=107,Name="Kiran",Department="Sales",Marks=75}
};

            var q51 = students.Concat(students2);

            foreach (var s in q51)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Department} {s.Marks}");
            }

            // Query 52
            Console.WriteLine("\n========== Query 52 : Union ==========");

            var q52 = students.Select(s => s.Department)
                              .Union(students2.Select(s => s.Department));

            foreach (var dept in q52)
            {
                Console.WriteLine(dept);
            }

            // Query 53
            Console.WriteLine("\n========== Query 53 : Intersect ==========");

            List<string> dept1 = new List<string>() { "IT", "HR", "Sales" };
            List<string> dept2 = new List<string>() { "IT", "Admin", "Sales" };

            var q53 = dept1.Intersect(dept2);

            foreach (var d in q53)
            {
                Console.WriteLine(d);
            }

            // Query 54
            Console.WriteLine("\n========== Query 54 : Except ==========");

            var q54 = dept1.Except(dept2);

            foreach (var d in q54)
            {
                Console.WriteLine(d);
            }

            // Query 55
            Console.WriteLine("\n========== Query 55 : SequenceEqual ==========");

            List<int> list1 = new List<int>() { 10, 20, 30 };
            List<int> list2 = new List<int>() { 10, 20, 30 };

            Console.WriteLine(list1.SequenceEqual(list2));

            // Query 56
            Console.WriteLine("\n========== Query 56 : ElementAt ==========");

            var q56 = students.ElementAt(2);

            Console.WriteLine($"{q56.Name} {q56.Marks}");

            // Query 57
            Console.WriteLine("\n========== Query 57 : ElementAtOrDefault ==========");

            var q57 = students.ElementAtOrDefault(10);

            if (q57 == null)
                Console.WriteLine("No Student Found");
            else
                Console.WriteLine(q57.Name);

            // Query 58
            Console.WriteLine("\n========== Query 58 : First IT Student ==========");

            var q58 = students.First(s => s.Department == "IT");

            Console.WriteLine($"{q58.Name}");

            // Query 59
            Console.WriteLine("\n========== Query 59 : Last IT Student ==========");

            var q59 = students.Last(s => s.Department == "IT");

            Console.WriteLine($"{q59.Name}");

            // Query 60
            Console.WriteLine("\n========== Query 60 : Reverse Student Names ==========");

            var q60 = students.Select(s => s.Name).Reverse();

            foreach (var name in q60)
            {
                Console.WriteLine(name);
            }

            // Query 61
            Console.WriteLine("\n========== Query 61 : Names with Length ==========");

            var q61 = students.Select(s => new
            {
                s.Name,
                Length = s.Name.Length
            });

            foreach (var item in q61)
            {
                Console.WriteLine($"{item.Name} : {item.Length}");
            }

            // Query 62
            Console.WriteLine("\n========== Query 62 : Display Unique Marks ==========");

            var q62 = students.Select(s => s.Marks).Distinct();

            foreach (var mark in q62)
            {
                Console.WriteLine(mark);
            }

            // Query 63
            Console.WriteLine("\n========== Query 63 : Top 2 Highest Marks ==========");

            var q63 = students.OrderByDescending(s => s.Marks).Take(2);

            foreach (var s in q63)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }
            // Query 64
            Console.WriteLine("\n========== Query 64 : Single() ==========");
            var q64 = students.Single(s => s.Id == 101);
            Console.WriteLine($"{q64.Id} {q64.Name} {q64.Marks}");


            // Query 65
            Console.WriteLine("\n========== Query 65 : SingleOrDefault() ==========");
            var q65 = students.SingleOrDefault(s => s.Id == 200);

            if (q65 == null)
                Console.WriteLine("Student Not Found");


            // Query 66
            Console.WriteLine("\n========== Query 66 : DefaultIfEmpty() ==========");

            List<Student> emptyStudents = new List<Student>();

            var q66 = emptyStudents.DefaultIfEmpty();

            foreach (var s in q66)
            {
                if (s == null)
                    Console.WriteLine("Collection is Empty");
            }


            // Query 67
            Console.WriteLine("\n========== Query 67 : ToDictionary() ==========");

            Dictionary<int, Student> q67 = students.ToDictionary(s => s.Id);

            foreach (var item in q67)
            {
                Console.WriteLine($"{item.Key} {item.Value.Name}");
            }


            // Query 68
            Console.WriteLine("\n========== Query 68 : ToLookup() ==========");

            var q68 = students.ToLookup(s => s.Department);

            foreach (var group in q68)
            {
                Console.WriteLine("\nDepartment : " + group.Key);

                foreach (var s in group)
                {
                    Console.WriteLine($"{s.Name} {s.Marks}");
                }
            }


            // Query 69
            Console.WriteLine("\n========== Query 69 : Contains() ==========");

            bool q69 = students.Select(s => s.Name).Contains("Mayuri");

            Console.WriteLine(q69);


            // Query 70
            Console.WriteLine("\n========== Query 70 : ThenBy() ==========");

            var q70 = students
                        .OrderBy(s => s.Department)
                        .ThenBy(s => s.Name);

            foreach (var s in q70)
            {
                Console.WriteLine($"{s.Department} {s.Name}");
            }


            // Query 71
            Console.WriteLine("\n========== Query 71 : ThenByDescending() ==========");

            var q71 = students
                        .OrderBy(s => s.Department)
                        .ThenByDescending(s => s.Marks);

            foreach (var s in q71)
            {
                Console.WriteLine($"{s.Department} {s.Name} {s.Marks}");
            }


            // Query 72
            Console.WriteLine("\n========== Query 72 : LongCount() ==========");

            Console.WriteLine(students.LongCount());


            // Query 73
            Console.WriteLine("\n========== Query 73 : Aggregate() ==========");

            int total = students
                        .Select(s => s.Marks)
                        .Aggregate((x, y) => x + y);

            Console.WriteLine("Total Marks = " + total);


            // Query 74
            Console.WriteLine("\n========== Query 74 : Aggregate (Maximum Marks) ==========");

            int max = students
                        .Select(s => s.Marks)
                        .Aggregate((x, y) => x > y ? x : y);

            Console.WriteLine("Maximum Marks = " + max);


            // Query 75
            Console.WriteLine("\n========== Query 75 : Aggregate (Minimum Marks) ==========");

            int min = students
                        .Select(s => s.Marks)
                        .Aggregate((x, y) => x < y ? x : y);

            Console.WriteLine("Minimum Marks = " + min);

            // Query 76
            Console.WriteLine("\n========== Query 76 : Skip Last Student ==========");
            var q76 = students.Take(students.Count - 1);
            foreach (var s in q76)
            {
                Console.WriteLine(s.Name);
            }

            // Query 77
            Console.WriteLine("\n========== Query 77 : Take Last 2 Students ==========");
            var q77 = students.Skip(students.Count - 2);
            foreach (var s in q77)
            {
                Console.WriteLine(s.Name);
            }

            // Query 78
            Console.WriteLine("\n========== Query 78 : Names in Upper Case ==========");
            var q78 = students.Select(s => s.Name.ToUpper());
            foreach (var name in q78)
            {
                Console.WriteLine(name);
            }

            // Query 79
            Console.WriteLine("\n========== Query 79 : Names in Lower Case ==========");
            var q79 = students.Select(s => s.Name.ToLower());
            foreach (var name in q79)
            {
                Console.WriteLine(name);
            }

            // Query 80
            Console.WriteLine("\n========== Query 80 : Student Name Length ==========");
            var q80 = students.Select(s => new
            {
                s.Name,
                Length = s.Name.Length
            });

            foreach (var item in q80)
            {
                Console.WriteLine($"{item.Name} : {item.Length}");
            }

            // Query 81
            Console.WriteLine("\n========== Query 81 : Even Marks ==========");
            var q81 = students.Where(s => s.Marks % 2 == 0);

            foreach (var s in q81)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 82
            Console.WriteLine("\n========== Query 82 : Odd Marks ==========");
            var q82 = students.Where(s => s.Marks % 2 != 0);

            foreach (var s in q82)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 83
            Console.WriteLine("\n========== Query 83 : Maximum Marks Student ==========");
            var q83 = students.OrderByDescending(s => s.Marks).First();

            Console.WriteLine($"{q83.Name} {q83.Marks}");

            // Query 84
            Console.WriteLine("\n========== Query 84 : Minimum Marks Student ==========");
            var q84 = students.OrderBy(s => s.Marks).First();

            Console.WriteLine($"{q84.Name} {q84.Marks}");

            // Query 85
            Console.WriteLine("\n========== Query 85 : Students Above Average ==========");
            double avg = students.Average(s => s.Marks);

            var q85 = students.Where(s => s.Marks > avg);

            foreach (var s in q85)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 86
            Console.WriteLine("\n========== Query 86 : Students Below Average ==========");
            var q86 = students.Where(s => s.Marks < avg);

            foreach (var s in q86)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }

            // Query 87
            Console.WriteLine("\n========== Query 87 : Name Contains 'a' ==========");
            var q87 = students.Where(s => s.Name.ToLower().Contains("a"));

            foreach (var s in q87)
            {
                Console.WriteLine(s.Name);
            }

            // Query 88
            Console.WriteLine("\n========== Query 88 : Marks Between 60 and 80 ==========");
            var q88 = students.Where(s => s.Marks >= 60 && s.Marks <= 80);

            foreach (var s in q88)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }
            // Query 89
            Console.WriteLine("\n========== Query 89 : Students Sorted By Name ==========");

            var q89 = students.OrderBy(s => s.Name);

            foreach (var s in q89)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }


            // Query 90
            Console.WriteLine("\n========== Query 90 : Students Sorted By Marks ==========");

            var q90 = students.OrderBy(s => s.Marks);

            foreach (var s in q90)
            {
                Console.WriteLine($"{s.Name} {s.Marks}");
            }


            // Query 91
            Console.WriteLine("\n========== Query 91 : Student Names Only ==========");

            var q91 = students.Select(s => s.Name);

            foreach (var name in q91)
            {
                Console.WriteLine(name);
            }


            // Query 92
            Console.WriteLine("\n========== Query 92 : Student IDs Only ==========");

            var q92 = students.Select(s => s.Id);

            foreach (var id in q92)
            {
                Console.WriteLine(id);
            }


            // Query 93
            Console.WriteLine("\n========== Query 93 : Students in IT Department ==========");

            var q93 = students.Where(s => s.Department == "IT");

            foreach (var s in q93)
            {
                Console.WriteLine($"{s.Name}");
            }


            // Query 94
            Console.WriteLine("\n========== Query 94 : Students Not in IT ==========");

            var q94 = students.Where(s => s.Department != "IT");

            foreach (var s in q94)
            {
                Console.WriteLine($"{s.Name}");
            }


            // Query 95
            Console.WriteLine("\n========== Query 95 : Display Student Count ==========");

            Console.WriteLine(students.Count());


            // Query 96
            Console.WriteLine("\n========== Query 96 : Highest Marks ==========");

            Console.WriteLine(students.Max(s => s.Marks));


            // Query 97
            Console.WriteLine("\n========== Query 97 : Lowest Marks ==========");

            Console.WriteLine(students.Min(s => s.Marks));


            // Query 98
            Console.WriteLine("\n========== Query 98 : Total Marks ==========");

            Console.WriteLine(students.Sum(s => s.Marks));


            // Query 99
            Console.WriteLine("\n========== Query 99 : Average Marks ==========");

            Console.WriteLine(students.Average(s => s.Marks));


            // Query 100
            Console.WriteLine("\n========== Query 100 : Student with Highest Marks ==========");

            var q100 = students.OrderByDescending(s => s.Marks).First();

            Console.WriteLine($"{q100.Name} {q100.Marks}");


            // Query 101
            Console.WriteLine("\n========== Query 101 : Display All Students ==========");

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Department} {s.Marks}");
            }

        }

    }
}