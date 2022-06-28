using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    public class Regles : Partie
    {
        private  int option=0;
        public  int verrifier(Partie p,Joueur player1, Arene arene, Packet_de_pioche deck, int sleep)
        {
            bool gotodeck = true;

            deck.remplireDeck(arene, null, 1);


            /////////////player 1
            //on supose que le joueur doit passer par la pioche avec gotodeck==true si le joueur a la carte il mettera gotodeck a false et ne piochera pas
            gotodeck = true;
            //if not blocked
            if (arene.getTable()[2] != "1")
            {
                //if 1 on table
                if (arene.getTable()[2] == "2")
                {
                    // search for 1 on hand
                    for (int i = 0; i < player1.getHand().Count; i++)
                    {
                        try
                        {
                            if (arene.getTable()[0] == player1.getHand()[i].getNumero())
                            {
                                player1.Jouer(i, arene);
                                gotodeck = false;
                                arene.getTable()[2] = "2";
                                option = 1;
                                Thread.Sleep(sleep);
                                break;
                            }
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }

                    }
                }
                //if not 1 on table
                else
                //if can play on table
                if (arene.getTable()[2] == "0")
                {
                    // search fo card on hand
                    for (int i = 0; i < player1.getHand().Count; i++)
                    {
                        try
                        {
                            if (arene.getTable()[0] == player1.getHand()[i].getNumero() || arene.getTable()[1] == player1.getHand()[i].getCouleur() || player1.getHand()[i].getNumero() == "8")
                            {
                                player1.Jouer(i, arene);
                                gotodeck = false;
                                if (arene.getTable()[0] == "1") arene.getTable()[2] = "2";
                                if (arene.getTable()[0] == "7") arene.getTable()[2] = "1";
                                option = 1;
                                Thread.Sleep(sleep);
                                break;
                            }
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }

                    }
                }

                if (gotodeck == true)
                {
                    if (arene.getTable()[2] == "2") { if (deck.getCount() > 0) { deck.pioche(player1, arene, 2); } else { deck.remplireDeck(arene, null, 1); deck.pioche(player1, arene, 2); } }
                    if (arene.getTable()[2] == "0") { if (deck.getCount() > 0) { deck.pioche(player1, arene, 1); } else { deck.remplireDeck(arene, null, 1); deck.pioche(player1, arene, 1); } }
                    arene.getTable()[2] = "0";
                    option = 1;
                    Thread.Sleep(sleep);
                }

            }
            else
            {
                arene.getTable()[2] = "0";
                player1.mise_a_jour(null, 4);
                Console.WriteLine("--------");
                option = 1;
                Thread.Sleep(sleep);
            }
            Console.WriteLine("--------");

            //voir si le joeur 1 a gagner
            if (player1.getHand().Count == 0)
            {

                Console.WriteLine("le joueur " + player1.getNom() + " " + player1.getPrenom() + ">>>>>>>>>>> a gagner");
                option = 0;
            }

            return option;

        }

    }
}
