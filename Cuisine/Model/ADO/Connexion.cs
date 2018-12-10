using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Model.ADO
{
    class Connexion
    {

        public Connexion()
        {

        }

        public void Connect()
        {
            MySqlConnection
           SqlConnection connec = new SqlConnection("Data Source = DESKTOP - URQ2J9H; Initial Catalog = Master_Chef; Integrated Security = True");
        }
    }

}

        

