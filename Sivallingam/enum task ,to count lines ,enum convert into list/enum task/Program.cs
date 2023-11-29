using System;
using System.ComponentModel;
using System.ComponentModel;
using System.Threading.Channels;
using System.Xml.Schema;

namespace consoleapp
{
    class Program
    {
        public enum Task
        {
            siva ,
            kapilan,
            mani ,
            dharun,
            kandan
        }
      
        public enum FlagshipSmartphone
        {
            [Description("iPhone 13 Pro Max")]
            Apple,
            [Description("Samsung Galaxy Note 20")]
            Samsung,
            [Description("OnePlus 9 Pro")]
            OnePlus,
            [Description("Google Pixel 6 Pro")]
            Google
        }
    
        // to find integer value it enum
        public void method1()
        {
            foreach(int task in Enum.GetValues(typeof(Task)))
            {
                Console.WriteLine(task);
            }

            
            Console.WriteLine("*********************\n");
        }
        //enum convert into list
        public void method()
        {
            List<Task> days = Enum.GetValues(typeof(Task))
                        .Cast<Task>()
                        .ToList();

            Console.WriteLine(String.Join(Environment.NewLine, days));


            Console.WriteLine("*************************\n");
        }
        public void method2()
        {
            var dayNames = new List<string> { "Monday", "Tuesday ", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var dayValues = new List<DayOfWeek>();
            foreach (var dayName in dayNames)
            {
                var dayValue = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayName);

                dayValues.Add(dayValue);
            }
        
            Console.WriteLine(String.Join(Environment.NewLine, dayValues ));

            Console.WriteLine("*************************\n");
        }
        //count file lines 
        //count file words
        public void method3()
        {
            int count = File.ReadAllLines(@"H:\file read.txt").Length;
            Console.WriteLine("Number of lines: " + count);

            var readFile = File.ReadAllText(@"H:\file read.txt");
            var str = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine("Number of words: " + str.Length);

            Console.WriteLine("*************************\n");
        }
        //to replace in file postion 
        public void method4()
        {
            string text = File.ReadAllText(@"H:\file read.txt");
            text = text.Replace("welcome", "new value");
            File.WriteAllText(@"H:\file read.txt", text);
            Console.WriteLine(text);

            Console.WriteLine("***************************\n");
        }
        //get  size in file 
        //to get exctension
        public void method5()
        {
           
            string fi = @"H:\file read.txt";
            string filename = File.ReadAllText(fi);
            long size = filename.Length;
            Console.WriteLine("File Size : {0}", size);

            string FileName = @"H:\file read.txt";
            string FileExtension = System.IO.Path.GetExtension(FileName);

            Console.WriteLine("fileextension : "  + FileExtension);

            Console.WriteLine("*******************\n");
        }
        public void method6()
        {
            FlagshipSmartphone Samsung = FlagshipSmartphone.Samsung;
            string Description = Samsung.GetEnumDescription();
            Console.WriteLine(Description);

            var value = FlagshipSmartphone.Samsung.GetEnumDescription();
            Console.WriteLine(value);

           
        }
        public static void Main()
        {
           Program obj = new Program();
            obj.method1();
            obj.method();
            obj.method2();
            obj.method3();
            obj.method4();
            obj.method5();
            obj.method6();
        }
    }
}
