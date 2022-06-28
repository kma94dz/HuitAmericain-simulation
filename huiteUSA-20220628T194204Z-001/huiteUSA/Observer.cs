using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    //////////////////////////////////////////////////////////////////////////////////// observateur
    public class Observer
    {
        public void Notify(Joueur p, Carte carte, int option)
        {
            if (option == 1)
                Console.WriteLine("" + p.getNom() + " " + p.getPrenom() + "(" + (p.getHand().Count) + ")  a jouer: " + carte.getNumero() + " " + carte.getCouleur());
            if (option == 2)
                Console.WriteLine("" + p.getNom() + " " + p.getPrenom() + " a piocher 1 carte" + " (" + (p.getHand().Count) + ")");
            if (option == 3)
                Console.WriteLine("" + p.getNom() + " " + p.getPrenom() + " a piocher 2 cartes" + " (" + (p.getHand().Count-1) + ")");
            if (option == 4)
                Console.WriteLine("blocker>>(" + (p.getHand().Count) + ")" + p.getNom() + " " + p.getPrenom());
        }

    }
    //////////////////////////////////////////////////////////////////////////////////// observateur

}
