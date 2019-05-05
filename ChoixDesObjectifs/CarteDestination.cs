using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class CarteDestination
    {
        public readonly List<Ville> _villes;
        public readonly int _valeurPoints;

        public CarteDestination(Ville villeA, Ville villeB, int valeurPoints)
        {
            _villes = new List<Ville> { villeA, villeB };
            _valeurPoints = valeurPoints;
        }

        public override string ToString()
        {
            string chres = "";
            foreach(Ville v in _villes)
            {
                chres += " - " + v;
            }
            chres += "\t\tValeur en points : " + _valeurPoints;
            return base.ToString();
        }
    }
}
