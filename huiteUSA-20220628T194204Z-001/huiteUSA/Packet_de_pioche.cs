using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    public class Packet_de_pioche : Jeux_de_carte
    {
        //une pile  de pioche
        private Stack deck;

        public Packet_de_pioche()
        {
            this.deck = new Stack();
        }

        /////////////////////////systeme de pioches
        public void pioche(Joueur player, Arene arene, int option)
        {
            //si joeur a recu un 1 (As)
            if (option == 2)
            {
                //le joueur ramasse une carte
                try
                {
                    player.Piocher(this.deck);
                    //le joueur ramasse une 2eme carte
                    player.Piocher(this.deck);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                finally
                {   //le joueur ramasse une carte apres le remplisssage du pioche si le pioche et vide
                    remplireDeck(arene, null, 1);
                    player.Piocher(deck);
                }
                player.mise_a_jour(null, 3);

            }
            else
            {// si le joueur doit ramasser une seul carte
                try
                {//le joueur ramasse une carte
                    player.Piocher(deck);
                    player.mise_a_jour(null, 2);
                }
                catch (Exception e)
                {//le joueur ramasse une carte apres le remplisssage du pioche si le pioche et vide
                    Console.WriteLine(e.Message);
                    remplireDeck(arene, null, 1);
                    player.Piocher(deck);
                    player.mise_a_jour(null, 2);
                }

            }
        }

        public Carte popCard()
        {
            return (Carte)deck.Pop();
        }

        public int getCount()
        {
            return deck.Count;
        }


        ///////////////////////////////////////// remplire le packet de pioche
        public void remplireDeck(Arene arene, List<Carte> JeuxCarte, int option)
        {
            //remplire le paquet de pioche
            ////////////////////////////////si le packet de pioche est vide
            if (option == 1)
            {
                if (deck.Count == 0)
                {
                    try
                    {
                        Console.WriteLine("le paquet est vide >>>> remplissage  et melange");
                        Console.WriteLine("-------------------------------------");
                        Random random = new Random();

                        for (int i = 0; i < arene.getPlayedCards().Count; i++)
                        {
                            int rn = random.Next(0, arene.getPlayedCards().Count);
                            deck.Push(arene.getPlayedCards()[rn]);
                            arene.getPlayedCards().RemoveAt(rn);
                        }
                        //on efface les cartes de sur la table
                        //arene.getPlayedCards().Clear();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (option == 0)
            {//si le jeux vien de commencer
                foreach (Carte c in JeuxCarte)deck.Push(c);
            }
            Console.WriteLine("--------");
        }
    }
}




//////////////////////////////////////////////////////////////////////////////////// packet de pioche
