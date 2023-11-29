using Microsoft.VisualBasic;
using System;
using System.IO;

namespace consoleapp 
{
    class program
    {
        //one file to another file
        public void method1()
        {
            var myPath = @"H:\file read.txt";
            var newpath = @"H:\New folder (2)\file3.txt";
            File.Copy(myPath,newpath);
        }
        //compare two text file
        public void method2()
        {
            FileInfo f1 = new FileInfo(@"H:\file read.txt");
            FileInfo f2 = new FileInfo(@"H:\New folder (2)\file1.txt");
            FileInfo f3 = new FileInfo(@"H:\New folder emp");

            if (f1.Exists == f3.Exists)
            {
                Console.WriteLine("give file size is same ");
            }
            else
            {
                Console.WriteLine("give file size is not same");
            }
            Console.WriteLine("****************************\n");
        }
        // find file size
        public void method3()
        {
            {
                var size = GetDirectorySize(@"H:\Sivallingam");
                Console.WriteLine(size);
            }

            static long GetDirectorySize(string p)
            {
                
                string[] a = Directory.GetFiles(p, "*.*");
                long b = 0;
                foreach (string name in a)
                {
                  
                    FileInfo info = new FileInfo(name);
                    b += info.Length;
                }
              
                return b;
            }
            Console.WriteLine("*******************************\n");
        }
        //find drives
        public void method4()
        {
            Console.WriteLine("Computer Drives in my system:");
           
            DriveInfo[] driverslist = DriveInfo.GetDrives();
            foreach (DriveInfo d in driverslist)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  File type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine(" Total size of drive:{0, 15} bytes ", d.TotalSize);
                    Console.Read();
                }
            }
        }
        public static void Main()
        {
            program f1 = new program();
            //f1.method1();
            f1.method2();
            f1.method3();
            f1.method4();
        }
    }

}

