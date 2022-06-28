using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;
using huiteUSA;


namespace huiteUSA
{ 
public class Personne
 {
        protected string nom;
        protected string prenom;

    public Personne(string nom, string prenom)
    {
        this.nom = nom;
        this.prenom = prenom;
    }

    public String getNom()
    {
        return this.nom;
    }

    public String getPrenom()
    {
        return this.prenom;
    }
    }
}

