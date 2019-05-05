using System;
using System.Collections.Generic;
namespace Graphe_Transdi
{
    public class Noeud // Classe noeud
    {
        public int Indice { get; set; } // Prend un indice en argument ce qui témoigne de sa position dans la liste des ville + cf le graphe que j'ai modélisé sur ppt pour avoir la correspondance indice-ville
        public string Ville { get; set; } // nom de la ville

        public Noeud(int ind, string ville) // constructeur
        {
            Indice = ind;
            Ville = ville;
        }

    }
}
