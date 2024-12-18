using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_1
{
    internal class Enseignant : Personne
    {
        public string Matiere {  get;  }
        public Enseignant(string nom, string prenom, string matier)
            :base(nom,prenom)
        {
            Matiere = matier;
        }
        public override void afficherDetails()
        {
            base.afficherDetails();
            Console.WriteLine($"Matière enseignée: {Matiere}");
        }
    }
}
