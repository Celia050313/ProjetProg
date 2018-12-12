using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerSimulation
{
    public class GestionTemps
    {
        public delegate void VoidDel();
        public int Jour { get; set; }
        public int Heure { get; set; }
        public int Minute { get; set; }
        public int Seconde { get; set; }

        public event VoidDel ProJour;
        public event VoidDel ProHeure;
        public event VoidDel ProMinute;
        public event VoidDel ProSeconde;

        public event VoidDel OuvertureStaff;
        public event VoidDel OuvertureClient;
        public event VoidDel FermetureStaff;
        public event VoidDel FermetureClient;
        public event VoidDel ChangementStaff;
        
        public GestionTemps()
        {
            Jour = Heure = Minute = Seconde = 0;

            ProJour = ProHeureDefaut;
            ProHeure = ProHeureDefaut;
            ProMinute = ProMinuteDefaut;
        }



        public void Go()
        {
            if (Seconde++ >= 60)
            {
                Seconde = 0;
                ProMinute();
            }
        }

        private void ProMinuteDefaut()
        {
            if(Minute++ >= 60)
            {
                Minute = 0;
                ProHeure();
            }
        }

        private void ProHeureDefaut()
        {
            if(Heure++ >= 24)
            {
                Heure = 0;
                ProJour();
                FermetureStaff();
            }

            switch (Heure)
            {
                case 10:
                    OuvertureStaff();
                    break;

                case 12:
                    OuvertureClient();
                    break;

                case 15:
                    FermetureClient();
                    break;

                case 17:
                    ChangementStaff();
                    break;

                case 22:
                    FermetureClient();
                    break;

            }
        }

        private void ProJourDefaut()
        {
            Jour++;
        }


    }
}
