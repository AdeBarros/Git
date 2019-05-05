using System;
using System.Collections.Generic;

namespace Graphe_Transdi
{

    class MainClass
    {
        public static Noeud ListtoNoeud(string[] V, int indice) // Prend en arg une liste de string et un indice i et convertit le i ème élément de la liste en Noeud
        {
            string nom = V[indice];
            Noeud N = new Noeud(indice, nom);
            return N;
        }

        public static List<Noeud> ListeNoeud(string[] V) // Convertit une liste de string en liste de noeuds
        {
            int taille = V.Length;
            List<Noeud> Liste = new List<Noeud>();
            for (int i = 0; i < taille; i++)
            {
                Liste.Add(ListtoNoeud(V, i));
                i += i;
            }
            return Liste;
        }

        public static void Main(string[] args)
        {
            // Liste des villes
            string[] V = {"Vancouver", "Seattle","Calgary", "Portland","Helena","Winnipeg", "San Francisco","Salt Lake City","Denver", "Omaha",
            "Duluth", "Sault St Marie","Los Angeles", "Las Vegas","Phoenix","Santa Fe","Oklahoma City","Kansas City","Chicago","Toronto","Montreal","El Paso",
            "Dallas","Little Rock", "Saint Louis","Pittsburgh", "New York","Boston","Houston", "New Orleans","Nashville","Raleigh","Washington","Atlanta","Miami","Charleston"};

            // Liste des villes convertie en liste de noeuds
            List<Noeud> Villes = ListeNoeud(V);

            // J'ai tenté de faire la liste des arêtes du graphe mais ca avit planté il faut que je retente
            List<Arete> Liens = new List<Arete>();
            bool i = true;
            while (i)
            {
                Console.WriteLine("Extremité 1");
                int e1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Extremité 2");
                int e2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Couleur 1");
                string c1 = Console.ReadLine();
                Console.WriteLine("Couleur 2");
                string c2 = Console.ReadLine();
                Console.WriteLine("Troncons");
                int tr = int.Parse(Console.ReadLine());

                Noeud n1 = ListtoNoeud(V, e1);
                Noeud n2 = ListtoNoeud(V, e2);

                if (c1 == "")
                {
                    Arete A = new Arete(n1, n2, 0, tr);
                    Liens.Add(A);
                }

                else
                {
                    if (c2 != "")
                    {
                        Arete A = new Arete(n1, n2, 0, tr, c1, c2);
                        Liens.Add(A);
                    }

                    else
                    {
                        Arete A = new Arete(n1, n2, 0, tr, c1);
                        Liens.Add(A);
                    }
                }

                Console.WriteLine("Une autre ? 1-> oui 0 -> non ");
                int b = int.Parse(Console.ReadLine());

                if (b == 0) { i = false; }
            }

            // Le plateau qui prend en argument la liste des villes en Noeuds et la liste de toutes les arêtes du plateau.
            Graphe Plateau = new Graphe(Villes, Liens);

            //Mdr j'étais desespérée ok
            Console.WriteLine("ok");
            Console.ReadLine();
        }
    }
}
