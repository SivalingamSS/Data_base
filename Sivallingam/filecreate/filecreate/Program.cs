using System;
using System.IO;
using System.Text;

class FileCreation
{
    //Program to Create a File
    public void method1()
    {
        string fileName = @"H:\New folder\.txt";
        File.Create(fileName);

        Console.WriteLine("*************************\n");
    }
    // Program to Create a Directory
    public void method2()
    {
        Directory.CreateDirectory(@"H:\\New directory");
        Console.WriteLine("NewDirectory is Created in H Directory");

        Console.WriteLine("*************************\n");
    }
    // Program to Read a Text File
    public void method3()
    {
        string text = File.ReadAllText(@"H:\file read.txt");
        Console.WriteLine(text);

        Console.WriteLine("*************************\n");
    }
    // Program to Check the Information of the File
    public void method4()
    {
        FileInfo information = new FileInfo(@"H:\file read.txt");
        FileAttributes  name = information.Attributes;
        Console.WriteLine(name);

        Console.WriteLine("*************************\n");
    }
    // Program to View the Access Date and Time of a File
    public void method5()
    {
        FileInfo information = new FileInfo(@"H:\file read.txt");
        DateTime createdtime = information.CreationTime;
        Console.WriteLine("File is created  time: {0}", createdtime);
        createdtime = information.LastAccessTime;
        Console.WriteLine("File is accessed at lastly: {0}", createdtime);
        createdtime = information.LastWriteTime;
        Console.WriteLine("File is lastly in written: {0}", createdtime);

        Console.WriteLine("**************************\n");
    }
    //Program to Search Directories and List Files
    public void method6()
    {
        string[] list = Directory.GetFiles(@"H:\Sivallingam", "*.*",
                                      SearchOption.AllDirectories);
        foreach (string file in list)
        {
            Console.WriteLine(file);
        }
        Console.WriteLine("*************************\n");
    }
    // Program to Check if File Exists or Not
    public void method7()
    {
        if (File.Exists("file read.txt"))
        {
            Console.WriteLine("Specified file exists.");
        }
        else
        {
            Console.WriteLine("Specified file does not exist in the current directory.");
        }
        Console.WriteLine("*******************************\n");
    }
    // Program to List Files in Directory
    public void method8()
    {
        DirectoryInfo place = new DirectoryInfo(@"H:\Sivallingam\SivaFiles");
        FileInfo[] files = place.GetFiles();
        Console.WriteLine("Files in : ");
        foreach (FileInfo file in files)
        {
            Console.WriteLine("file name - {0}",file.Name );
        }

    }
    public static void Main()
    {
        FileCreation fi = new FileCreation();
        fi.method1();
        fi.method2();
        fi.method3();
        fi.method4();
        fi.method5();
        fi.method6();
        fi.method7();
        fi.method8();
    }
}
