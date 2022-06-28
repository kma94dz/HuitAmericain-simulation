using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;

namespace huiteUSA
{
    //////////////////////////////////////////////////////////////////////////////////// carte
    public class Carte
    {
        private String numero;
        private String couleur;
        public Carte(String num, String coul)
        {
            this.numero = num;
            this.couleur = coul;
        }

        public String getNumero()
        {
            return this.numero;
        }
        public String getCouleur()
        {
            return this.couleur;
        }

    }
    //////////////////////////////////////////////////////////////////////////////////// carte
}
