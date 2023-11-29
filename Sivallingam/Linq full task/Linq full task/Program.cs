using Linq_full_task.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections;
using Amazon.DynamoDBv2.Model;
using System.Threading.Channels;

public class program
{
    public void method()
    {
        //inner join task list

        IList<sameobject> list = new List<sameobject>()
         {
            new sameobject() { id = 1, name = "John", age = 13, Stuid = 1 },
            new sameobject() { id = 2, name = "Moin", age = 21, Stuid = 1 },
            new sameobject() { id = 3, name = "Bill", age = 18, Stuid = 2 },
            new sameobject() { id = 4, name = "Ram", age = 20, Stuid = 2 },
            new sameobject() { id = 5, name = "Ron", age = 15 },
         };
        IList<sameobject2> list1 = new List<sameobject2>()
         {
            new sameobject2() { Stuid = 1, stuname = "stu 1" },
            new sameobject2() { Stuid = 2, stuname = "stu 2" },
            new sameobject2() { Stuid = 3, stuname = "stu 3" },
         };

        var innerJoin = from s in list
                        join std in list1
                        on s.Stuid equals std.Stuid
                        select new
                        {
                            name = s.name,
                            stuname = std.stuname

                        };
        foreach (var same in innerJoin)
        {
            Console.WriteLine(" {0}  {1} ", same.name, same.stuname);

        }
        Console.WriteLine("***********************************\n");
    }
    public void method1()
    {
        // linq in max , min , count
        List<object> list = new List<object>()
        { "10","20","50","55"};
        var method = list.Count();
        var name = list.Max();
        var age = list.Min();
        Console.WriteLine(method);
        Console.WriteLine(age);
        Console.WriteLine(name);

        Console.WriteLine("****************************\n");
    }
    public void method2()
    {
        // groupby list
        IList<sameobject> list = new List<sameobject>()
         {
            new sameobject() { id = 1, name = "John", age = 13, Stuid = 1 },
            new sameobject() { id = 2, name = "Moin", age = 21, Stuid = 1 },
            new sameobject() { id = 3, name = "Bill", age = 18, Stuid = 2 },
            new sameobject() { id = 4, name = "Ram", age = 20, Stuid = 2 },
        };
        var method = list.GroupBy(s => s.age);

        foreach (var item in method)
        {
            Console.WriteLine("age : {0}", item.Key);
            foreach (sameobject item2 in item)
            {
                Console.WriteLine("name : {0}", item2.name);
            }
        }
        Console.WriteLine("**********************\n");
    }
    public void method3()
    {
        //any and contains
        IList<sameobject> list = new List<sameobject>()
         {
            new sameobject() { id = 1, name = "John", age = 13, Stuid = 1 },
            new sameobject() { id = 2, name = "Moin", age = 21, Stuid = 1 },
            new sameobject() { id = 3, name = "Bill", age = 18, Stuid = 2 },
            new sameobject() { id = 4, name = "Ram", age = 20, Stuid = 2 },
        };
        bool var = list.Any(s => s.age == 13);
        Console.WriteLine(var);

        List<object> list1 = new List<object>()
        { "10","20","50","55"};
        bool var1 = list1.Contains("10");
        Console.WriteLine(var1);

        Console.WriteLine("*****************************\n");
    }
    public void method4()
    {
        //select and selectmany
        IList<sameobject> list = new List<sameobject>()
         {
            new sameobject() { id = 1, name = "John", age = 13, Stuid = 1 },
            new sameobject() { id = 2, name = "Moin", age = 21, Stuid = 1 },
            new sameobject() { id = 3, name = "Bill", age = 18, Stuid = 2 },
            new sameobject() { id = 4, name = "Ram", age = 20, Stuid = 2 },
        };

        string[] str = { "Mobile", "Laptop", "Tablet" };
        var res = str.SelectMany(item => item.ToCharArray());
        Console.WriteLine("String converted to character array: ");
        foreach (char letter in res)
        {
            Console.Write(letter);
        }
        Console.WriteLine("***********************\n");

        var list2 = from s in list
                    select s.name;
        foreach (var s in list2)
            Console.WriteLine(s);

        Console.WriteLine("*********************\n");
    }
    public void method5()
    {
        //find given two dates in months


        var start = new DateTime(2013, 1, 1);
        var end = new DateTime(2013, 6, 22);
        end = new DateTime(end.Year, end.Month, DateTime.DaysInMonth(end.Year, end.Month));

        var diff = Enumerable.Range(0, Int32.MaxValue)
                             .Select(e => start.AddMonths(e))
                             .TakeWhile(e => e <= end)
                             .Select(e => e.ToString("MMMM"));
        foreach (string str in diff)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("**********************\n");

    }
    public void method6()
    {
        // merge json in list linq


        string time = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig1.json");
        string time1 = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig2.json");
        sameobject[] sum = JsonConvert.DeserializeObject<sameobject[]>(time);
        List<sameobject> Same = new List<sameobject>(sum);
        sameobject[] sun = JsonConvert.DeserializeObject<sameobject[]>(time1);
        List<sameobject> students = new List<sameobject>(sun);
        var resultedCol = Same.Intersect(students, new sameobjectComparer());
        foreach (sameobject s in resultedCol)
        {
            Console.WriteLine(s.name);
        }
        Console.WriteLine("*************************************\n");
    }



    public void method7()
    {
        //left jion in linq

        IList<sameobject> list = new List<sameobject>()
         {
            new sameobject() { id = 1, name = "John", age = 13, Stuid = 1 },
            new sameobject() { id = 2, name = "Moin", age = 21, Stuid = 1 },
            new sameobject() { id = 3, name = "Bill", age = 18, Stuid = 2 },
            new sameobject() { id = 4, name = "Ram", age = 20, Stuid = 2 },
            new sameobject() { id = 5, name = "Ron", age = 15 },
         };
        IList<sameobject2> list1 = new List<sameobject2>()
         {
            new sameobject2() { Stuid = 1, stuname = "stu 1" },
            new sameobject2() { Stuid = 2, stuname = "stu 2" },
            new sameobject2() { Stuid = 3, stuname = "stu 3" },
         };
        var result = from e in list1
                     join d in list
                     on e.Stuid equals d.Stuid into empDept
                     from ed in empDept.DefaultIfEmpty()
                     select new
                     {
                         EmployeeName = e.Stuid,
                         DepartmentName = ed == null ? "No Department" : ed.name
                     };
        foreach (var item in result)
        {
            Console.WriteLine(item.EmployeeName + "\t | " + item.DepartmentName);
        }
        Console.ReadLine();
        Console.WriteLine("*********************************\n");
    }
    public void method8()
    {
        //sepecficd string take in linq

        string[] stud = { "siva", "mani", "kapilan", "maddy" };
        IEnumerable<string> result = from a in stud
                                     where a.StartsWith("s")
                                     select a;
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("*******************************\n");
    }
    public void method9()
    {
        //json in different of records
        string time = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig1.json");
        string time1 = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig2.json");
        sameobject[] sum = JsonConvert.DeserializeObject<sameobject[]>(time);
        List<sameobject> Same = new List<sameobject>(sum);
        sameobject[] sun = JsonConvert.DeserializeObject<sameobject[]>(time1);
        List<sameobject> students = new List<sameobject>(sun);
        var resultedCol = Same.Union(students, new sameobjectComparer());
        foreach (sameobject s in resultedCol)
        {
            Console.WriteLine(s.name);
        }
        Console.WriteLine("*************************************\n");

    }
    public void method10()
    {
        //merge tolinst json

        var time = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig1.json");
        var time1 = File.ReadAllText(@"H:\Sivallingam\Linq full task\Linq full task\jsconfig2.json");
        sameobject[] sum = JsonConvert.DeserializeObject<sameobject[]>(time);
        List<sameobject> Same = new List<sameobject>(sum);
        sameobject[] sun = JsonConvert.DeserializeObject<sameobject[]>(time1);
        List<sameobject> students = new List<sameobject>(sun);
        var MS = Same.Concat(students.ToList());

        foreach (var student in MS)
        {
            Console.WriteLine($" ID : {student.id} Name : {student.name}  stuid : {student.Stuid} age:{student.age}");
        }

        Console.WriteLine("***************************************\n");
    }
    public void method11()
    {
        //offset in oderby

        int[] marks = { 80, 55, 79, 99, 55, 99, 55, 56, 44 };
        System.Console.WriteLine(marks.Count());
        IEnumerable<int> selMarks = marks.Skip(2).Take(7);
        Console.WriteLine("Skipped the result of 1st two students...");
        System.Console.WriteLine(selMarks.Count());
        /* foreach (int res in selMarks)
         {
             Console.WriteLine(res);
         }*/
        Console.WriteLine("*******************************\n");
    }
    public void method12()
    {
        // 30,31 in one year
        int iyear = 2002;
        int month30 = 0;
        int month31 = 0;

        var man = Enumerable.Range(1, 12);

        var monthinyear30 = man.Where(man => DateTime.DaysInMonth(iyear, man) == 30);
        var monthinyear31 = man.Where(man => DateTime.DaysInMonth(iyear, man) == 31);
        Console.WriteLine("month in year 30,31");
        foreach (var month1 in monthinyear30)
        {
            month30++;
        }
        foreach (var month2 in monthinyear31)
        {
            month31++;
        }

        Console.WriteLine(month30);
        Console.WriteLine(month31);
        Console.WriteLine("*************************************\n");
    }
    public void Predicate()
    {
        //bool in predicate
        string[] Perdicate = { "A", "H", "a", "H", "over", "Jack" };
        bool contains = Perdicate.Contains("G");
        Console.WriteLine(contains);
        var moon = from s in Perdicate
                   where s.Contains("G")
                   select s;
        foreach (var s in moon)
            Console.WriteLine(s);
        Console.WriteLine("***************************\n");
    }
    public void method13()
    {
        //saturday and sunday

        var dates = GetWeekendDates(new DateTime(2022, 1, 1), new DateTime(2022, 12, 31));

        List<string> GetWeekendDates(DateTime startDate, DateTime endDate)
        {
            int CountSaturday = 0;
            int CountSunday = 0;
            List<string> weekendList = new List<string>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    CountSaturday++;
                    Console.WriteLine(date.ToString("yyyy-MM-dd"));
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    CountSunday++;
                    Console.WriteLine(date.ToString("yyyy-MM-dd"));
                }
            }
            Console.WriteLine($"Count of the Saturday is {CountSaturday}");
            Console.WriteLine($"Count of the Saturday is {CountSunday}");
            Console.WriteLine("************************************\n");
            return weekendList;
        }

    }
    public void method14()
    {
        //overlapped

        var firstOverlapDateRange = new DateRange(new(2023, 01, 07), new(2023, 01, 15));
        var secondOverlapDateRange = new DateRange(new(2023, 01, 12), new(2023, 01, 22));

        if (firstOverlapDateRange.Overlap(secondOverlapDateRange))
        {
            Console.WriteLine("Overlapped");
        }
        else
        {
            Console.WriteLine("not overlapped");
        }
        Console.WriteLine("*****************************\n");
    }
    public void method15()
    {
        //call function in linq method

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        var result = numbers
            .Where(x => x % 2 == 0) 
            .Select(x => Square(x)); 

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("******************************\n");
    }

    // Function to square a number
    static int Square(int number)
    {
        return number * number;
    }
    
    public class sameobjectComparer : IEqualityComparer<sameobject>
    {
        public bool Equals(sameobject x, sameobject y)
        {
            if (x.id == y.id &&
                            x.name.ToLower() == y.name.ToLower())
                return true;

            return false;


        }
        public int GetHashCode(sameobject obj)
        {
            return obj.name.GetHashCode();
        }

        public static void Main(string[] args)
        {
            program san = new program();
            san.method();
            san.method1();
            san.method2();
            san.method3();
            san.method4();
            san.method5();
            san.method6();
            san.method7();
            san.method8();
            san.method9();
            san.method10();
            san.method11();
            san.method12();
            san.Predicate();
            san.method13();
            san.method14();
            san.method15();
        }
    }
}



