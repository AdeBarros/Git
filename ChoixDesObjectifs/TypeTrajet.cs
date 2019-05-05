using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class TypeTrajet
    {
        public readonly string _typeTrajet;

        public TypeTrajet(string typeTrajet)
        {
            _typeTrajet = typeTrajet;
        }

        public override string ToString()
        {
            return _typeTrajet;
        }
    }
}
