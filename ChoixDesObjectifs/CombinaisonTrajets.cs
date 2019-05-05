using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class CombinaisonTrajets
    {
        public readonly TypeTrajet _trajet1;
        public readonly TypeTrajet _trajet2;
        public readonly TypeTrajet _trajet3;
        public readonly int _noteExpert;

        public CombinaisonTrajets(TypeTrajet trajet1, TypeTrajet trajet2, int noteExpert)
        {
            _trajet1 = trajet1;
            _trajet2 = trajet2;
            _noteExpert = noteExpert;
        }

        public CombinaisonTrajets(TypeTrajet trajet1, TypeTrajet trajet2, TypeTrajet trajet3, int noteExpert)
        {
            _trajet1 = trajet1;
            _trajet2 = trajet2;
            _trajet3 = trajet3;
            _noteExpert = noteExpert;
        }

        public override string ToString()
        {
            if (_trajet3 != null)
                return _trajet1.ToString() + _trajet2 + _trajet3;
            else return _trajet1.ToString() + _trajet2;
        }
    }
}
