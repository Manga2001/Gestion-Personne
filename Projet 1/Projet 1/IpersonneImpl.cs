using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_1
{
    internal class IpersonneImpl : Ipersonne
    {

        private List<Personne> personnes; 

        public IpersonneImpl()
        {
            personnes = new List<Personne>();
        }
        public void AjouterPersonne(Personne personne)
        {
            personnes.Add(personne);
            Console.WriteLine("La Personne a été Ajouter avec Succé!");
        }
        public void AfficherPersonne()
        {
            Console.WriteLine("Affichage de la Liste des personnes :");
            foreach (var prs in personnes)
            {
                prs.afficherDetails();
            }
        }
        public void AfficherEnseignant()
        {
            Console.WriteLine("Affichage de la Liste des enseignants :");
            foreach (var prs in personnes)
            {
                if (prs is Enseignant)
                {
                    prs.afficherDetails();
                }
            }
        }
        public void AfficherEtudiant()
        {
            Console.WriteLine("Affichage de la Liste des étudiants :");
            foreach (var prs in personnes)
            {
                if (prs is Etudiant)
                {
                    prs.afficherDetails();
                }
            }
        }


    }
}
