using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    public class Jeux_de_carte
    {
        //toutes les carte possible
        private List<Carte> JeuxCarte;
        private List<String> couleurs;
        private List<String> numero;

        public Jeux_de_carte()
        {
            this.JeuxCarte = new List<Carte>();
            this.couleurs = new List<String>() { "careau", "pique", "trefl", "coeur" };
            this.numero = new List<String>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valet", "Dame", "Roi" };

        }

        public List<Carte> getJeuxCards()
        {
            return this.JeuxCarte;
        }

        public void creer_les_cartes()
        {

            for (int i = 0; i < couleurs.Count; i++)
            {
                for (int j = 0; j < numero.Count; j++)
                {
                    Carte carte = new Carte(numero[j], couleurs[i]);
                    JeuxCarte.Add(carte);

                }

            }



        }

        ////////////////////////////////////////methode pour distribuer les cartes aleatoirement
        public void distribuer(List<Joueur> listjoueur)
        {
            //distribution aleatoire des cartes
            for (int i = 0; i < listjoueur.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    Random random = new Random();
                    int rn = random.Next(0, JeuxCarte.Count);
                    listjoueur[i].getHand().Add(JeuxCarte[rn]);
                    JeuxCarte.RemoveAt(rn);


                }
            }
        }

    }
    //////////////////////////////////////////////////////////////////////////////////// jeux de carte
}
