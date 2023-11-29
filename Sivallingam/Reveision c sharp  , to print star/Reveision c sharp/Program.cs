using System;
public class program
{
    //public abstract void mymethod();
    public void method()
    {
        int id = 2233;
        Console.WriteLine("enter the application number");
        Console.WriteLine(id);

    }
    class program2 : program
    {
        public  void mymethod()
        {
            string str = "Hello";
            char[] chasracters = str.ToCharArray();
            for (int i = 0; i < chasracters.Length; i++)
            {
                Console.WriteLine(chasracters);
            }
        }
    }
  
     class Program3 :program2
    {

        public  void method1()
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        class Program4 :Program3 
        {
            public class Base
            {
                public int num1;
            }
            public class Derived : Base
            {
                public int num2;
            }
            public class program
            {
                static void Main(string[] args)
                {
                    Program3 p = new Program3();
                    p.method();
                    p.mymethod();
                    p.method1();
                    Base ob1 = new Base();
                    Derived ob2 = new Derived();
                    ob1.num1 = 20;
                    // Access to protected member as it is inherited by the Derived class  
                    ob2.num2 = 90;
                    Console.WriteLine("Number2 value {0}", ob2.num2);
                    Console.WriteLine("Number1 value which is protected {0}", ob1.num1);
                    Console.ReadLine();
                }
            }
        }
    }
}

