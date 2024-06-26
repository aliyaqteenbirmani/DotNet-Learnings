using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
   
    class DemoProject
    {
        public static Days MeetingDate { get; set; } = Days.Monday;
        //static void Main(string[] args)
        //{

        //    foreach (int i in Enum.GetValues(typeof(Days))) 
        //        Console.WriteLine(i + ":" + (Days)i);
            
        //    foreach (string j in Enum.GetNames(typeof(Days))) 
        //        Console.WriteLine(j);
        //    Console.ReadLine();
        //}
    }
}
