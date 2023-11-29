/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Datetimeyear_naveenna.NewFolder
{
    public class Class1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            Calendar[] myCals = new Calendar[1];
            myCals[0] = new GregorianCalendar();
            int i, j, iYear;
            DateTime myDT = new DateTime(year);
            for (i = 0; i < myCals.Length; i++)
            {
                 iYear = myCals[i].GetYear(myDT);
                Console.WriteLine("   DaysInYear: {0}", myCals[i].GetDaysInYear(iYear));
            }
        }
    }
}
*/