
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerSimulation{
    public class FacadeCuisinier {


        private Plongeur plongeur;
        private Cuisinier cuisinier;
        private Commis commis;
        private chefDeCuisine chefCuisine;

        public FacadeCuisinier() {

            plongeur = new Plongeur();
            cuisinier = new Cuisinier();
            commis = new Commis();
            chefCuisine = new chefDeCuisine();
        }



        public void Cuisinier() {
            // TODO implement here
        }

        public void Commis() {
            // TODO implement here
        }

        public void Stock() {
            // TODO implement here
        }

        public void Client() {
            // TODO implement here
        }

        public void Scenarii() {


            // TODO implement here
        }

        public void Plongeur() {

            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                int n = 1000000;
                for (int ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                Console.WriteLine("Total:   {0:N0}", sum);
                Console.WriteLine("Mean:    {0:N2}", sum / n);
                Console.WriteLine("N:       {0:N0}", n);
            });
            t.Wait();
        }
        // TODO implement here
    }

        public void chefDeCuisine() {
            // TODO implement here
        }

    }
}