using System;
using System.Collections.Generic;
namespace Graphe_Transdi
{
    public class Chemin // Classe chemin
    {
        public Noeud Debut { get; set; } // Début du chemin, un Noeud car une ville
        public Noeud Fin { get; set; } // Fin du chemin, un noeud
        public List<Arete> Path { get; set; } // Liste des arêtes empruntées pour relier les 2 villes


        public Chemin(Noeud n1, Noeud n2, List<Arete> path) // Constructeur
        {
            Debut = n1;
            Fin = n2;
            Path = path;
        }
    }
}
