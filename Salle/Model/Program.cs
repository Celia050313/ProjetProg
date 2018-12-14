using System;
using Model;

namespace Model
{
    class Program
    {

        private static string Element = "Serveur";
        private static string Champ = "Nom";
        /// <summary>
        /// Fonctionnement de la Factory : 
        /// 2 méthodes principales existent après la création de la factory spécifique à un type d'objet.
        ///  
        /// - La factory principale accepte 2 paramètres : le nombre d'objets à créer et le type d'objet 
        /// 
        /// - La méthode AccesElement accepte 3 paramètres : le nom de l'objet, le numéro de l'objet (son id), et les champs additionels
        /// (Pour l'exemple) , le champ supplémentaire ici est le champ "Nom", unique à la classe Serveur, mais peut être remplacé par "Etat" pour afficher l'Etat
        /// 
        /// - La méthode ModifElement accepte 4 paramètres : les mêmes paramètres que pour la méthode ci-dessus, mais aussi la nouvelle valeur du champ sélectionné
        /// (Pour l'exemple, lors de la création de la factory de serveur, le serveur n°3 s'appelle "George", mais après modification il s'appelle "Roger" 
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>
    static void Main(string[] args)
        {
            Factory factory = new Factory(4, Element);

            Console.WriteLine(factory.AccesElement(Element, 2, Champ));
            Console.WriteLine(factory.AccesElement(Element, 3, Champ));
            factory.ModifElement(Element, 3, Champ,"Roger");
            Console.WriteLine(factory.AccesElement(Element, 3, Champ));

        }
    }
}
