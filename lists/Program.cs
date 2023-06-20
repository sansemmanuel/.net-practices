using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People();
            Ceo ceo1 = new Ceo();
            Developer d1 = new Developer();
            Developer d2 = new Developer();
            Developer d3 = new Developer();
            Tester t1 = new Tester();
            Tester t2 = new Tester();
            Tester t3 = new Tester();
            d1.Technology = "c#";
            d2.Technology = "full stack";
            d3.Technology = "c#";
            d1.Project = "ypf";
            d2.Project = "unasigned";
            d3.Project = "ypf";
            List<Developer> developerList = new List<Developer>();
            developerList.Add(d1);
            developerList.Add(d2);
            developerList.Add(d3);
            /*Console.WriteLine("Developer quantity" + developerList.Count);
            Console.WriteLine("Technologies" + developerList[1].Technology);*/
            foreach(Developer item in developerList)
            {
                Console.WriteLine("Developer List" + item.Technology);
            }
            Console.ReadKey();
        }
    }
}
