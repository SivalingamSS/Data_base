using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_full_task.model
{
    public class sameobject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int Stuid { get; set; }
    }
    public class sameobject2
    {
        public int Stuid { get;  set; }
        public string stuname { get; set; }
        
    }
   
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string department { get; set; }

    }
    public class student2
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string department { get; set; }

    }
    public class DateRange
    {
        public DateOnly Start { get; private set; }
        public DateOnly End { get; private set; }

        public DateRange(DateOnly start, DateOnly end)
        {
            Start = start;
            End = end;
        }

        public bool Overlap(DateRange range)
        {
            return Start < range.End && End > range.Start;
        }
    }

}
