using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    public class CartesDesJoueur
{
    private List<Joueur> listdesjoueur;
    public CartesDesJoueur(List<Joueur> listdesjoueur)
    {
        this.listdesjoueur = listdesjoueur;
    }

    ////////////////////////////////////////////////////////////methode pour afficher les cartes des joueurs
    public void afficherLesCartes()
    {
        //afficher les carte des joueurs
        for (int i = 0; i < this.listdesjoueur.Count; i++)
        {
            Console.WriteLine("" + this.listdesjoueur[i].getNom() + " " + this.listdesjoueur[i].getPrenom());
            for (int j = 0; j < this.listdesjoueur[i].getHand().Count; j++)
            {
                Console.WriteLine(this.listdesjoueur[i].getHand()[j].getNumero() + " " + this.listdesjoueur[i].getHand()[j].getCouleur());
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

        }
    }

}

}