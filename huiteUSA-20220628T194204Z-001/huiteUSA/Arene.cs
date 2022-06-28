using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    //////////////////////////////////////////////////////////////////////////////////// arene
    public class Arene
    {
        //carte dernierement jouer
        private String[] Table;
        //une liste de toutes les cartes jouees 
        private List<Carte> playedCards;

        public Arene()
        {
            this.Table = new String[3];
            this.playedCards = new List<Carte>();
        }

        public String[] getTable()
        {
            return this.Table;
        }

        public List<Carte> getPlayedCards()
        {
            return this.playedCards;
        }

    }
    //////////////////////////////////////////////////////////////////////////////////// arene
}
