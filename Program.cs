using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array array = new string[5];
            ArrayList humans = new ArrayList();
            humans.Add("Dima");
            humans.Add("Kolyan");
            humans.Add("Petya");

            foreach(var human in humans)
            {
                Console.WriteLine(human);
            }

            humans.Remove("Kolyan");
            Console.WriteLine("----------");

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }


            Console.WriteLine("**** foreach через приватный метод");

            foreach (var human in humans) 
            {
                Output(human);
            }


            Console.ReadKey() ;
        }


        private static void Output(object ttt) => Console.WriteLine(ttt);

    }
}
