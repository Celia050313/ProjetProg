using System;
using System.Collections.Generic;
using System.Text;
using Element;

namespace Model
{
    public class Factory
    {
        public int ObjACreer;

        public int IDClient = 0;
        public int IDCommis = 0;
        public int IDChefRang = 0;
        public int IDTable = 0;
        public int IDCommande = 0;
        public int IDServeur = 0;
        public int IDMaitre = 0;

        //var TabClient = new List<Client>();

        public object[] TabChefRang;
        public object[] TabClient;
        public object[] TabTable;
        public object[] TabCommande;
        public object[] TabServeur;
        public object[] TabMaitre;
        private object temporaire;

        public object[] TabCommis;

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
            ObjectDumper.Dumper.Dump();
            return tbl;
        }
        */
        public Factory(int obj)
        {
            this.ObjACreer = obj;
            for (int i = 0; i < ObjACreer; i++)
            {
                Random random = new Random();
                int ob = random.Next(1, 7);



                switch (ob) {
                    case 1:
                        IDTable++;
                        Table tbl = new Table(4, false, "attente", IDTable);
                        TabMaitre[IDTable - 1] = tbl;



                        break;
                    case 2:
                        IDMaitre++;
                        MaitreHotel MH = new MaitreHotel(IDMaitre, "attente");
                        TabMaitre[IDMaitre - 1] = MH;
                        break;
                    case 3:
                        IDClient++;
                        Client Client = new Client(IDClient, "attente");
                        TabClient[IDClient - 1] = Client;
                        break;
                    case 4:
                        IDCommis++;
                        Commis Com = new Commis(IDCommis, "attente");
                        TabCommis[IDCommis - 1] = Com;
                        
                        break;
                    case 5:
                        IDChefRang++;
                        ChefDeRang CR = new ChefDeRang(IDChefRang,"attente");
                        TabChefRang[IDChefRang - 1] = CR;
                        break;
                    case 6 when IDServeur<4 :
                        IDServeur++;
                        if (IDServeur == 2)
                        { Serveur Ser = new Serveur(IDServeur, "attente", "Norbert");
                            TabServeur[IDServeur - 1] = Ser;
                        }
                        else
                        { Serveur Ser = new Serveur(IDServeur, "attente", "George");
                            TabServeur[IDServeur - 1] = Ser;
                        }

                        break;
                    case 7:
                        IDCommande++;
                        ElemenT_ Elem = new ElemenT_(IDCommande, "attente");
                        TabCommande[IDCommande - 1] = Elem ;
                        break;
                    default:
                        Console.WriteLine("=====ERROR=====");
                        break;



                }



            }
            Console.WriteLine("Nbr Table = " + IDTable);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr Maitre = " + IDMaitre);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr Client = " + IDClient);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr Commis = " + IDCommis);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr ChefRang = " + IDChefRang);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr Serveur = " + IDServeur);
            Console.WriteLine("-----------");
            Console.WriteLine("Nbr Commande = " + IDCommande);





      







            
        }


    














    }       
}
