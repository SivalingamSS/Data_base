using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Datetimeyear
{
    class name
    {        
        public void method()
        {
            int iyear;
         // int imonth;
            Console.WriteLine("Enter the year:");
            iyear = int.Parse(Console.ReadLine());
            Console.WriteLine("year is :" + iyear); //count weeks in year
            {
                Console.WriteLine(ISOWeek.GetWeeksInYear(iyear));
            }

            //to find leap year

            if (DateTime.IsLeapYear(iyear))
            {
                Console.WriteLine("It is leap year");
            }
            else
            {
                Console.WriteLine("It is not leap year");
            }

            //count days in year

            int i = 1; int days = 0;
            while (i <=12)
            {
                days += DateTime.DaysInMonth(iyear, i);
                i++;
            }
            Console.WriteLine(days);

            //count days in month

            int imonth;
            Console.WriteLine("Enter the month:");
            imonth = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(iyear, imonth));

            //count month in year
          
            int a=0,b=0,c=0;
           // imonth = int.Parse(Console.ReadLine());
         
            for (i = 1; i < 12; i++)
            {
                var man = DateTime.DaysInMonth(iyear, i);
                var result = (man == 31) ? a++ : (man == 30) ? b++ : c++;
             /*   if (man == 30)
                {
                    a++;

                }
                else if(man == 31) 
                {
                    b++;
                }
                else if (man == 29)
                {
                    c++;
                }
                el
                {
                    d++;
                }*/
            }
            Console.WriteLine( "there are 31 in "+  a);
            Console.WriteLine("there are 30 in " +   b);
            Console.WriteLine("there are others in " +    c);

        }
        public static void Main(string[] args)
        {
           name man=new name();
            man.method();
            
        }

    }

}

