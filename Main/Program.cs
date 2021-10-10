using System;
using FlyweightImplementation;
using static FlyweightImplementation.MATERIAL;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CatalogueToys catalogue = new CatalogueToys();
            for (int i = 1; i < 20; i++)
            {
                catalogue.CreateToys(i, "DOG", 'd', Plastic);
                catalogue.CreateToys(i * 2, "CAT", 'c', Wood);
                catalogue.CreateToys(i * 3, "BEZ", 'm', Metals);
            }
            catalogue.FlyweightOperationDraw();
        }
    }
}
