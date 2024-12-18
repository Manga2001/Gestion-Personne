using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Projet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IpersonneImpl gestionPrs = new IpersonneImpl();
            int choix;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Ajouter une personne");
                Console.WriteLine("2. Afficher toutes les personnes");
                Console.WriteLine("3. Afficher tous les enseignants");
                Console.WriteLine("4. Afficher tous les étudiants");
                Console.WriteLine("5. Quitter");
                Console.Write("Faite Votre choix: ");

                if (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                    continue;
                }
                switch (choix)
                {
                    case 1:
                        Console.Write("Nom: ");
                        string nom = Console.ReadLine();
                        Console.Write("Prénom: ");
                        string prenom = Console.ReadLine();
                        Console.Write("Type (1 pour Enseignant, 2 pour Étudiant): ");
                        int type = int.Parse(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Matière enseignée: ");
                            string matiere = Console.ReadLine();
                            gestionPrs.AjouterPersonne(new Enseignant(nom, prenom, matiere));
                        }
                        else if (type == 2)
                        {
                            Console.Write("Niveau d'études: ");
                            string niveau = Console.ReadLine();
                            gestionPrs.AjouterPersonne(new Etudiant(nom, prenom, niveau));
                        }
                        else
                        {
                            Console.WriteLine("Type invalide.");
                        }
                        break;

                    case 2:
                        gestionPrs.AfficherPersonne();
                        break;

                    case 3:
                        gestionPrs.AfficherEnseignant();
                        break;

                    case 4:
                        gestionPrs.AfficherEtudiant();
                        break;

                    case 5:
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }      while (choix != 5);
        }
    }
}
