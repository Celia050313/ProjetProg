using System;
using System.Collections.Generic;
using System.Text;
using Element;

namespace Model
{
    public class Factory
    {
        public ElemenT_ createCommande()
        {
            ElemenT_ Elem = new Element.ElemenT_();
            return Elem;
        }

        public Commis createCommis()
        {
            Commis Com = new Element.Commis();
            return Com;

        }
        

        public Serveur createServeur()
        {
            Serveur Ser = new Element.Serveur();
            return Ser;

        }

        public Client createClient()
        {
            Client Client = new Element.Client();
            return Client;
        }

        public MaitreHotel createMaitreHotel()
        {
            MaitreHotel MH = new Element.MaitreHotel();
            return MH;
        }

        public Table createTable()
        {
            Table tbl = new Element.Table();
            return tbl;
        }

        public static sealed getInstance()
        {

        }
    }
}
