using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{

    ///////////////////////////////////////////////////////////////////////////la class Joueur
    public class Joueur : Personne
    {
        private List<Carte> hand;

        public Joueur() : base("", "")
        {
            this.hand = new List<Carte>();
        }


        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }


        public List<Carte> getHand()
        {
            return this.hand;
        }

        public void Jouer(int i, Arene arene)
        {
            arene.getTable()[1] = this.hand[i].getCouleur();
            arene.getTable()[0] = this.hand[i].getNumero();
            arene.getTable()[2] = "0";
            arene.getPlayedCards().Add(this.hand[i]);
            Carte tmp = this.hand[i];
            this.hand.RemoveAt(i);
            this.mise_a_jour(tmp, 1);
        }

        public void Piocher(Stack deck)
        {
            this.hand.Add((Carte)deck.Pop());
        }




        public void mise_a_jour(Carte carte, int option)
        {
            Observer o = new Observer();
            o.Notify(this, carte, option);

        }



    }
    ///////////////////////////////////////////////////////////////////////////la class Joueur
    ///
}
