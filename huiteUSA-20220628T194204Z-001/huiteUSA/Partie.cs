using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

/////////////////////////////////////////////////////////////////////class partie
namespace huiteUSA
{
    public class Partie
{
    public  List<Joueur> listDesJoueur;
    public Partie()
    {
        this.listDesJoueur = new List<Joueur>();
    }

        public List<Joueur> GetList()
        {
            return this.listDesJoueur;
        }

        public void initListJoueur()
    {
        // intro
        Console.WriteLine("---Bienvenu au jeux de carte du Huit Americain---");

        ///////////////////////// Menu /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine(">>entrez le nombre de joueur : (minimum deux joueur)---  (entrez un nombre > 4 ou < 1  pour quiter le menu)");
        Console.WriteLine("--");
        int nbrJoueur = Convert.ToInt32(Console.ReadLine());
        //creation des joueurs


        if (nbrJoueur > 4 || nbrJoueur < 1)
        {
            Console.WriteLine(">>fermeture du jeu");
            System.Environment.Exit(1);
        }

        if (nbrJoueur < 2) nbrJoueur = 2;

        for (int i = 1; i <= nbrJoueur; i++)
        {
            Joueur player = new Joueur();
            Console.WriteLine(">>entrez le nom du joueur "+i);
            player.setNom("" + Console.ReadLine());
            Console.WriteLine(">>entrez le prenom du joueur "+i);
            player.setPrenom("" + Console.ReadLine());
            this.listDesJoueur.Add(player);
        }
        ////////////////////////////////////////////////////////////// fin menu ////////////////////////////////////////////////////////////////////////////////////////////////
    }




    ////////////////////////////// methode principale du jeux    (simulation du jeux)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void Demarrer(int sleep)
    {
        Console.WriteLine("****************************************************************D E M A R R A G E *****************************************************************");



        //>>commencement du jeux
        Arene arene = new Arene();

        Jeux_de_carte jc = new Jeux_de_carte();
        jc.creer_les_cartes();

        this.initListJoueur();
        jc.distribuer(this.listDesJoueur);

        Packet_de_pioche pilePioche = new Packet_de_pioche();
        pilePioche.remplireDeck(arene, jc.getJeuxCards(), 0);

        Peche peche = new Peche();
        this.listDesJoueur = peche.ordoner(this.listDesJoueur);
            

            CartesDesJoueur cartesJoueur = new CartesDesJoueur(this.listDesJoueur);
        cartesJoueur.afficherLesCartes();

        //////////////////////////////////affichage de la 1ere carte presente sur la table
        Carte carte1 = pilePioche.popCard();


        arene.getTable()[0] = carte1.getNumero();
        arene.getTable()[1] = carte1.getCouleur();
        arene.getTable()[2] = "0";
        Console.WriteLine("sur la table : " + arene.getTable()[0] + " " + arene.getTable()[1]);
        Console.WriteLine("--------");

            Regles r = new Regles();
        int play = 1;
        int i = 0;
        while (true)
        {
                play = r.verrifier(this,this.listDesJoueur[i], arene, pilePioche, sleep);
                if (play == 0) break;
                i++;
                if (i > this.listDesJoueur.Count - 1)
                {
                    i = 0;
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("carte restantes dans le paquet de pioche >>>>>>>>>  " + pilePioche.getCount() + " || carte sur la table >>" + arene.getTable()[0] + " " + arene.getTable()[1]);
                    Console.WriteLine("--------------------------------------------------------------------------");

                }
                
            }

    }
}
}

