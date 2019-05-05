using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class Ville
    {
        public readonly string _nom;

        public Ville(string nom)
        {
            _nom = nom;
        }

        public override string ToString()
        {
            return _nom;
        }
    }
}
