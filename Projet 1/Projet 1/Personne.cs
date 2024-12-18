using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_1
{
    internal class Personne
    {
        protected string Nom { get; }
        protected string Prenom {  get; }

        public Personne(string nom,string prenom) 
        {
            Nom = nom;
            Prenom = prenom;
        }
        public virtual void afficherDetails()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}");
        }
    }
    
}
