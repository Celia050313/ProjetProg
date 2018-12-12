
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model{
    public class Model : IModel, IObserver {

        public Model() {
        }



        public static string getElement(string element)
        {
            switch (element)
            {
                case "serveur":
                    return "";

                case "commande":
                    return "";

                case "maitre":
                    return "";

                case "commis":
                    return "";

                case "client":
                    return "";

                case "chef":
                    return "";

                case "table":
                    return "";

                default:
                    return "";
            }


        }

        /// <summary>
        /// @return
        /// </summary>
        public static string getElement(string element,int id)
        {
            switch (element)
            {
                case "serveur":
                    return "";

                case "commande":
                    return "";

                case "maitre":
                    return "";

                case "commis":
                    return "";

                case "client":
                    return "";

                case "chef":
                    return "";

                case "table":
                    return "";

                default:
                    return "";
            }




          // return "";
        }


    }

    internal interface IObserver
    {
    }
}