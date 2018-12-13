using System;
using Model;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(5,"Table");



            Console.WriteLine(factory.AccesElement("Table",2,"ID"));





            if (factory==null)
            { Console.WriteLine("YouSK2"); };

        }
    }
}
