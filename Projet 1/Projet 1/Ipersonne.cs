using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_1
{
    internal interface Ipersonne
    {
        void AjouterPersonne(Personne personne);
        void AfficherPersonne();
        void AfficherEnseignant();
        void AfficherEtudiant();
    }
}
