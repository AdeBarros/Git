using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajet
{
    class Trajet
    {
        public List<Chemin> _chemins;
        public Trajet()
        {
            _chemins = new List<Chemin>() { };
        }
        public void Add(Chemin chemin)
        {
            _chemins.Add(chemin);
        }
        public int NbChemins()
        {
            int nbChemins = 0;
            foreach(Chemin chemin in this._chemins)
            {
                nbChemins++;
            }
            return nbChemins;
        }
        public int NbPoints()
        {
            int nbPoints = 0;
            foreach(Chemin chemin in this._chemins)
            {
                nbPoints += chemin._points;
            }
            return nbPoints;
        }
        public int Taille()
        {
            int taille = 0;
            foreach (Chemin chemin in this._chemins)
            {
                taille += chemin._taille;
            }
            return taille;
        }
    }
}
