using System;
using System.Collections.Generic;
namespace Graphe_Transdi
{
    public class Graphe // classe graphe
    {
        public List<Noeud> Noeuds { get; set; } // Liste e tous les noeuds du graphe (ici les 36 villes du coup)

        public int[,] Poids
        {
            get;
            set;
        } // La matrice des poids : Matrice carrée et le coeff i,j donne le poids de l'arête liant les sommets i et j si elle existe, 0 sinon.

        public Graphe(List<Noeud> villes, List<Arete> liens) // Constructeur
        {
            Noeuds = villes; // prend la liste de ville en arg
            for (int i = 0; i < 36; i++) // Initialise la matrice des poids avec des 0
            {
                for (int j = 0; j < 36; j++)
                {
                    Poids[i, j] = 0;
                }
            }

            for (int k = 0; k < liens.Count; k++) // Remplace tous les coefficients existants dans la liste des arêtes par leur poids dans la matrice des poids
            {
                int i1 = liens[k].N1.Indice;
                int i2 = liens[k].N2.Indice;

                Poids[i1, i2] = liens[k].Poids;
            }

        }

    }

}

