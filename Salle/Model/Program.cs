using System;
using Model;

namespace Model
{
    class Program
    {

        private static string Element = "Serveur";
        private static string Champ = "Nom";
        
    static void Main(string[] args)
        {
            Factory factory = new Factory(4, Element);

            Console.WriteLine(factory.AccesElement(Element, 2, Champ));
            Console.WriteLine(factory.AccesElement(Element, 3, Champ));



        }
    }
}
