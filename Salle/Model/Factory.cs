using System;
using System.Collections.Generic;
using System.Text;
using Element;
using System.Reflection;

namespace Model
{
    public class Factory
    {
        public int IDClient = 0;
        public int IDCommis = 0;
        public int IDChefRang = 0;
        public int IDTable = 0;
        public int IDCommande = 0;
        public int IDServeur = 0;
        public int IDMaitre = 0;

        //var TabClient = new List<Client>();


        List<Client> TabClient = new List<Client>();
        List<ChefDeRang> TabChefRang = new List<ChefDeRang>();
        List<Table> TabTable = new List<Table>();
        List<_Element> TabCommande = new List<_Element>();
        List<Serveur> TabServeur = new List<Serveur>();
        List<MaitreHotel> TabMaitre = new List<MaitreHotel>();
        List<Commis> TabCommis = new List<Commis>();

        ///  private object temporaire;



        /* public ElemenT_ createCommande(int id)
         {
             ElemenT_ Elem = new ElemenT_(id, "attente");
             return Elem;
         }

         public Commis createCommis(int id)
         {
             Commis Com = new Commis(id, "attente");
             return Com;

         }


         public Serveur createServeur(int id)
         {
             Serveur Ser = new Serveur(id,"attente","George");
             return Ser;

         }

         public Serveur createServeur(int id, string nm)
         {
             Serveur Ser = new Serveur(id, "attente", nm);
             return Ser;

         }

         public Client createClient(int id)
         {
             Client Client = new Client(id, "attente");
             return Client;
         }

         public MaitreHotel createMaitreHotel(int id)
         {
             MaitreHotel MH = new MaitreHotel(id, "attente");
             return MH;
         }

         public Table createTable(int id)
         {
             Table tbl = new Table(4,false,"attente",id);
             return tbl;
         }
         */

        public object container;

        public object AccesElement(string element, int id, string champ)
        {
            switch (element)
            {
                case "Table":
                    Type tTable = typeof(Table);
                    PropertyInfo PITable = tTable.GetProperty(champ);
                    container = PITable.GetValue(TabTable.Find(x => x.ID == id));
                    return container;
                    

                case "MaitreHotel":
                    Type tMaitre = typeof(MaitreHotel);
                    PropertyInfo PIMaitre = tMaitre.GetProperty(champ);
                    container = PIMaitre.GetValue(TabMaitre.Find(x => x.ID == id));
                    return container;



                case "Client":

                    Type tClient = typeof(Client);

                    Console.WriteLine(champ);
                   /* PropertyInfo[] PICLients = tClient.GetProperties();
                    Console.WriteLine("------");
                    foreach (PropertyInfo prop in PICLients)
                    { Console.WriteLine("\n" + prop); }
                    Console.WriteLine("------");*/
                    PropertyInfo PICLient = tClient.GetProperty(champ);
                    container = PICLient.GetValue(TabClient.Find(x => x.ID == id));
                    return container;


                case "Commis":

                    Type tCommis = typeof(Commis);
                    PropertyInfo PICommis = tCommis.GetProperty(champ);
                    container = PICommis.GetValue(TabCommis.Find(x => x.ID == id));
                    return container;


                case "ChefRang":

                    Type tChefRang = typeof(ChefDeRang);
                    PropertyInfo PIChefRang = tChefRang.GetProperty(champ);
                    container = PIChefRang.GetValue(TabChefRang.Find(x => x.ID == id));
                    return container;


                case "Serveur":

                    Type tServeur = typeof(Serveur);
                    PropertyInfo PIServeur = tServeur.GetProperty(champ);
                    container = PIServeur.GetValue(TabServeur.Find(x => x.ID == id));
                    return container;


                case "Commande":
                    Type tCommande = typeof(Commande);
                    PropertyInfo PICommande = tCommande.GetProperty(champ);
                    container = PICommande.GetValue(TabCommande.Find(x => x.ID == id));
                    return container;


                default:
                    return "ERROR";
                    
            }
        }



        public Factory(int obj, string objet)
        {
         
            for (int i = 0; i <obj; i++)
            {

               /* Random random = new Random();
                int ob = random.Next(1, 7);*/



                switch (objet) {
                    case "Table":
                        IDTable++;
                        Table tbl = new Table(4, false, "attente", IDTable);
                        TabTable.Add(tbl);
                        break;

                    case "MaitreHotel":
                        IDMaitre++;
                        MaitreHotel MH = new MaitreHotel(IDMaitre, "attente");
                         TabMaitre.Add(MH);
                        break;

                    case "Client":
                        IDClient++;
                        
                        Client Client = new Client(IDClient, "attente","cool","rapide");
                        TabClient.Add(Client);
                        break;

                    case "Commis":
                        IDCommis++;
                        Commis Com = new Commis(IDCommis, "attente");                       
                        TabCommis.Add(Com);
                        break;

                    case "ChefRang":
                        IDChefRang++;
                        ChefDeRang CR = new ChefDeRang(IDChefRang,"attente");         
                        TabChefRang.Add(CR);
                        break;

                    case "Serveur" :
                        IDServeur++;
                        if (IDServeur < 4)
                        {
                            if (IDServeur == 2)
                            {
                                Serveur Ser = new Serveur(IDServeur, "attente", "Norbert");

                                TabServeur.Add(Ser);
                            }
                            else
                            {
                                Serveur Ser = new Serveur(IDServeur, "en service", "George");

                                TabServeur.Add(Ser);
                            }
                        }
                        break;

                    case "Commande":
                        IDCommande++;
                        Commande Comd = new Commande(IDCommande, "attente");
                        TabCommande.Add(Comd);
                        break;

                    default:
                        i--;
                        break;



                }



            }
            /*


            Console.WriteLine("\nNom du Serveur avec l'ID 2 :  {0}", 
                TabServeur.Find(x => x.ID == 2).Nom);

            TabServeur.Find(x => x.ID == 2).Nom = "Bob";

            Console.WriteLine("\nNom du Serveur avec l'ID 2 :  {0}",
                TabServeur.Find(x => x.ID == 2).Nom);

    */



        }


    














    }       
}
