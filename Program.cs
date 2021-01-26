using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLesson1.job2;
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

            MyStack();
            MyQueue();
            MyHash();
            ExampleLinkedList();

            //Dictionary<IDescription, IFruit> fruit = new Dictionary<IDescription, IFruit>();
            ClassExample.DictionaryInterface();

            Console.ReadKey();

        }
        private static void Output(object ttt) => Console.WriteLine(ttt);


        #region  работаем с MyStack
        /// <summary>
        /// Работаем со стеком 
        /// </summary>
        public static void MyStack() 
        {
            Stack element = new Stack();

            element.Push("figa1");
            element.Push("figa2");
            element.Push("figa3");

            foreach (var vam in element) 
            {
                Console.WriteLine(vam);
            }

            var mystack = element.Pop();
            foreach (var vam in element)
            {
                Console.WriteLine(vam);
            }
        }
        #endregion
   
        #region Пример с очередью MyQueue
        /// <summary>
        /// Пример с очередью
        /// </summary>
        public static void MyQueue() 
        {
            Queue big = new Queue();
            big.Enqueue("people1");
            big.Enqueue("people2");
            big.Enqueue("people3");
            big.Enqueue("people4");

            big.Dequeue();
            foreach (var man in big) 
            {
                Console.WriteLine(man);
            }

            if (big.Contains("people1"))
            {
                Console.WriteLine("Есть people1");
            }
            else
                Console.WriteLine(" people1 отсуствует");
        }
        #endregion

        public static void MyHash()
        {
            Hashtable hash = new Hashtable();
            hash.Add("printer", "лазерный");
            hash.Add("lampa", "черная");
            hash.Add("monitor", "плоский");

            foreach (DictionaryEntry device in hash)
            {
                Console.WriteLine($"hash -{device.Key} - {device.Value}");
            }

            Console.WriteLine("Выборка их хэша по ключу. Лампа "+hash["lampa"]);
        }

        #region Работаем с LinkedList
        /// <summary>
        /// Работаем с LinkedList
        /// </summary>
        public static void ExampleLinkedList() 
        {
            LinkedList<string> month = new LinkedList<string>();

            month.AddFirst("январь");
            month.AddLast("февраль");
            month.AddLast("март");
            month.AddLast("апрель");
            month.AddLast("май");
            month.AddLast("июнь");
            month.AddLast("июль");
            month.AddLast("август");
            month.AddLast("сентябрь");
            month.AddLast("октябрь");
            month.AddLast("ноябрь");
            month.AddLast("декабрь");

            LinkedListNode<string> node = month.First;

            Console.WriteLine("************ работем с LinkedList");

            // Удаляем элемент со средины списка.
            if (month.Remove("июнь"))
                Console.WriteLine("месяц июнь удален успешно");
            else
                Console.WriteLine("грусть пкечаль");

            // посмотрим что осталось в списке
            while (node != null) 
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        #endregion
 
    }






}
