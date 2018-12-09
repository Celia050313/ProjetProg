using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Model.ADO
{
    class Connexion
    {



        public Connexion()
        {

        }

        public void Connect()
        {

            SqlConnection connexion = new SqlConnection("Data Source = DESKTOP - URQ2J9H; Initial Catalog = Master_Chef; Integrated Security = True");
        }
    }

}

        

