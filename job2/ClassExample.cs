using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLesson1.job2
{
    public static class ClassExample
    {
        public static void DictionaryInterface()
        {
            Dictionary<IFruit, IFruitDescr> fruit = new Dictionary<IFruit, IFruitDescr>();

            fruit.Add(new Fruit("apple"), new Description("green"));
            fruit.Add(new Fruit("rasberry"), new Description("red"));
            fruit.Add(new Fruit("peach"), new Description("ripe"));
            fruit.Add(new Berry("watermelon"), new ExDescription("sweet"));




            foreach (var item in fruit)
            {
                Console.WriteLine($"Key: {item.Key.Name} Value: {item.Value.Descr}");
            }
        }
    }

    public class Fruit : IFruit
    {
        public string Name { get; }
        public Fruit(string fruitname)
        {
            Name = fruitname;
        }

    }

    public class Berry: IFruit
    {
        public string Name { get; }
        public Berry(string fruitname)
        {
            Name = fruitname;
        }

    }

    public class Description: IFruitDescr
    {
        public string Descr { get; }
        public Description(string fruitdescr)
        {
            Descr = fruitdescr;
        }
    }



    public class ExDescription : IFruitDescr
    {
        public string Descr { get; }
        public ExDescription(string fruitdescr)
        {
            Descr = fruitdescr;
        }
    }
}
