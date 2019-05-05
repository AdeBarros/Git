using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajet
{
    class Chemin
    {
        public int _idVille1;
        public int _idVille2;
        public int _taille;
        public int _points;
        public Chemin(int idVille1, int idVille2, int taille)
        {
            _idVille1 = idVille1;
            _idVille2 = idVille2;
            _taille = taille;
            _points = taille;
        }
        public Chemin(int idVille1, int idVille2, int taille, int points)
        {
            _idVille1 = idVille1;
            _idVille2 = idVille2;
            _taille = taille;
            _points = points;
        }
    }
}
