using System;
using Model;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(50);
            if(factory==null)
            { Console.WriteLine("YouSK2"); };

        }
    }
}
