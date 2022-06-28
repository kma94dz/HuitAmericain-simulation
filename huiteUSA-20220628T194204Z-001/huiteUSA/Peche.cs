using System;
using System.Collections.Generic;
using System.Text;

namespace huiteUSA
{
    public class Peche
    {
        private List<Joueur> Ordre;

        public Peche()
        {
            this.Ordre = new List<Joueur>();
        }

       public List<Joueur> ordoner(List<Joueur> j)
       {
            foreach (Joueur p in j)
                this.Ordre.Add(p);

            foreach(Joueur p in j)
            {
                Console.WriteLine(">>a quel tour "+p.getNom()+" va jouer");
                int Joueur = Convert.ToInt32(Console.ReadLine());
                this.Ordre[Joueur-1] = p;
            }
            return this.Ordre;
        }


        public List<Joueur> ChangerLeSence()
        {
            this.Ordre.Reverse();
            return this.Ordre;
        }

    }
}
