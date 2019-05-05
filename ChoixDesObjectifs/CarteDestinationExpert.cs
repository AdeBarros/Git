using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class CarteDestinationExpert : CarteDestination
    {
        public readonly TypeTrajet _typeTrajet;
        public readonly int _noteExpert;

        public CarteDestinationExpert(Ville villeA, Ville villeB, int valeurPoints, TypeTrajet typeTrajet, int noteExpert) : base(villeA, villeB, valeurPoints)
        {
            _typeTrajet = typeTrajet;
            _noteExpert = noteExpert;
        }

        public override string ToString()
        {
            string chres = "";

            foreach (Ville v in this._villes)
            {
                chres += " - " + v;
            }
            chres += " : " + _valeurPoints + " points";
            return chres;
        }
    }
}
