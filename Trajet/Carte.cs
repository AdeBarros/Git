using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajet
{
    class Carte
    {
        public Chemin[,] _map;
        public Carte()
        {
            _map = new Chemin[36, 36];
        }
        public Trajet MeilleurTrajet(Ville villeDepart, Ville villeArrivee)
        {
            Trajet meilleurTrajet = new Trajet();
            List<Chemin> departs = new List<Chemin>() { };
            int nbCheminsDepart = 0;
            for (int i = 0; i < 36; i++)
            {
                departs.Add(_map[villeDepart._id, i]);
                nbCheminsDepart++;
            }
            List<Chemin> arrivee = new List<Chemin>() { };
            int nbCheminsArrivee = 0;
            for (int i = 0; i < 36; i++)
            {
                arrivee.Add(_map[i, villeArrivee._id]);
                nbCheminsArrivee++;
            }
            Random r = new Random();
            for(int nbessais = 0; nbessais<300; nbessais++)
            {
                Trajet trajetActuel = new Trajet();
                int ind = r.Next(0, nbCheminsDepart);
                trajetActuel.Add(departs[ind]);
                int idVilleActuelle = villeDepart._id;
                do
                {
                    ind = r.Next(0, 36);
                    if (_map[idVilleActuelle, ind] != null)
                    {
                        trajetActuel.Add(_map[idVilleActuelle, ind]);
                        if (_map[idVilleActuelle, ind]._idVille1 == idVilleActuelle)
                        {
                            idVilleActuelle = _map[idVilleActuelle, ind]._idVille1;
                        }
                        else
                        {
                            idVilleActuelle = _map[idVilleActuelle, ind]._idVille1;
                        }
                    }
                } while (trajetActuel.Taille() < 40);
                if((trajetActuel._chemins[-1]._idVille1 == villeArrivee._id || trajetActuel._chemins[-1]._idVille2 == villeArrivee._id)&&trajetActuel.NbPoints() >= meilleurTrajet.NbPoints())
                {
                    meilleurTrajet = trajetActuel;
                }
            }
            return meilleurTrajet;
        }
    }
}
