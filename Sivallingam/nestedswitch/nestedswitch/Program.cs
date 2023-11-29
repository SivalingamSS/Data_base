using System;
using System.Security.Cryptography.X509Certificates;

namespace nestedswitch
{
    class program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                switch (22)
                {
                    case 0:
                        Console.WriteLine("dsfghggiyk");
                        break;
                    case 1:
                        Console.WriteLine("dwezsds");
                        break;
                    case 2:
                        Console.WriteLine("dtujyt");
                        break;
                    case 3:
                        Console.WriteLine("dsfghggiyk");
                        break;
                    case 4:
                        Console.WriteLine("dsfghggiyk");
                        break;
                    default:
                        Console.WriteLine("bnfu");
                        break;
                }
            }
        }
        class quiz
        {
            public static void Main(string[] args)
            {
                int x = 10;
                int y = 20;
                int z = (x > y) ? (x++) : (x + y);
                Console.WriteLine(x);
            }
        }
    }
}