using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_1
{
    internal class Etudiant : Personne
    {
        public string Niveau { get; }
        public Etudiant(string nom, string prenom, string niveau)
            : base(nom, prenom)
        {
            Niveau = niveau;
        }
        public override void afficherDetails()
        {
            base.afficherDetails();
            Console.WriteLine($"Matière enseignée: {Niveau}");
        }
    }
}
