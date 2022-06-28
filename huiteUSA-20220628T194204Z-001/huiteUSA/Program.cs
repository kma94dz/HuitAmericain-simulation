using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace huiteUSA
{
    ///////////////////////////////////////////class principal du jeux
    class Program
    {


        public static void Main(String[] args)
        {
            Partie partie = new Partie();
            partie.Demarrer(10);

        }
    }
    /// ///////////////////////////////////////////////////////////////////////////

    /////////////////////////////////////////////////////////////////////interface
    public interface Fonction_Du_Jeux_De_Carte
    {
        void distribuer(Joueur player1, Joueur player2, Joueur player3, Joueur player4, int nbrjoueur);
        void afficherLesCartes(Joueur player1, Joueur player2, Joueur player3, Joueur player4, int nbrjoueur);
        void pioche(Joueur player, int option);
        void remplireDeck(int option);
    }
    /////////////////////////////////////////////////////////////////////interface

}