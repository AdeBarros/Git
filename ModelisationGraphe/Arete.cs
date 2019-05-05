using System;
using System.Collections.Generic;
namespace Graphe_Transdi
{
    public class Arete // classe arête donc qui modélise la route entre deux villes reliées
    {
        public Noeud N1 { get; set; } // Première ville ou extrémité, c'est un noeud du graphe
        public Noeud N2 { get; set; } // Deuxième ville, aussi un noeud
        public int Poids { get; set; } // Poids de l'arête, à déterminer (unité créée ? nombre de tronçons ? etc)
        public string Couleur1 { get; set; } // Première couleur de l'arête
        public string Couleur2 { get; set; } // Deuxième couleur SI ELLE EXISTE de l'arête
        public int Troncons { get; set; } // Nombre de tronçons (entre 1 et 6 du coup)

        public Arete(Noeud n1, Noeud n2, int pds, int troncons) // Premier constructeur, prend les deux extrémités, un poids et un nombre de tronçons. Si la couleur n'est pas spécifiée, l'arête est automatisuement "Grise (donc sans couleur)
        {
            N1 = n1;
            N2 = n2;
            Poids = pds;
            Couleur1 = "Gris";
            Couleur2 = null;
            Troncons = troncons;
        }

        // Surcharge du constructeur où on précise une couleur
        public Arete(Noeud n1, Noeud n2, int pds, int troncons, string c1) : this(n1, n2, pds, troncons)
        { Couleur1 = c1; }

        // Deuxième surcharge où on précise les 2 couleurs de l'arête s'il y a lieu
        public Arete(Noeud n1, Noeud n2, int pds, int troncons, string c1, string c2) : this(n1, n2, pds, troncons, c1)
        { Couleur2 = c2; }
    }
}
