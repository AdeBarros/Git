using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixDesObjectifs
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPES DE TRAJET           
            TypeTrajet Horizontale = new TypeTrajet("Horizontale");
            TypeTrajet Horizontale_Nord = new TypeTrajet("Horizontale Nord");
            TypeTrajet Horizontale_Sud = new TypeTrajet("Horizontale Sud");
            TypeTrajet Verticale = new TypeTrajet("Verticale");
            TypeTrajet Verticale_Ouest = new TypeTrajet("Verticale Ouest");
            TypeTrajet Verticale_Est = new TypeTrajet("Verticale Est");


            //COMBINAISONS

            //COMBINSAISONS TRES BIEN
            CombinaisonTrajets Verticale_Ouest_Verticale_Ouest = new CombinaisonTrajets(Verticale_Ouest, Verticale_Ouest, 5);
            CombinaisonTrajets Verticale_Ouest_Verticale = new CombinaisonTrajets(Verticale_Ouest, Verticale, 5);
            CombinaisonTrajets Verticale_Verticale = new CombinaisonTrajets(Verticale, Verticale, 5);
            CombinaisonTrajets Verticale_Horizontale_Nord = new CombinaisonTrajets(Verticale, Horizontale_Nord, 5);
            CombinaisonTrajets Horizontale_Nord_Horizontale_Nord = new CombinaisonTrajets(Horizontale_Nord, Horizontale_Nord, 5);

            //COMBINAISONS BIEN
            CombinaisonTrajets Verticale_Ouest_Horizontale_Nord = new CombinaisonTrajets(Verticale_Ouest, Horizontale_Nord, 4);
            CombinaisonTrajets Verticale_Ouest_Horizontale = new CombinaisonTrajets(Verticale_Ouest, Horizontale, 4);
            CombinaisonTrajets Verticale_Ouest_Horizontale_Sud = new CombinaisonTrajets(Verticale_Ouest, Horizontale_Sud, 4);
            CombinaisonTrajets Horizontale_Horizontale_Sud = new CombinaisonTrajets(Horizontale, Horizontale_Sud, 4);
            CombinaisonTrajets Horizontale_Sud_Horizontale_Sud = new CombinaisonTrajets(Horizontale_Sud, Horizontale_Sud, 4);

            //COMBINAISONS MOYEN
            CombinaisonTrajets Verticale_Est_Horizontale_Nord = new CombinaisonTrajets(Verticale_Est, Horizontale_Nord, 3);
            CombinaisonTrajets Horizontale_Horizontale = new CombinaisonTrajets(Horizontale, Horizontale, 3);
            CombinaisonTrajets Triple_Verticale_Est = new CombinaisonTrajets(Verticale_Est, Verticale_Est, Verticale_Est, 3);

            //COMBINAISONS NUL
            CombinaisonTrajets Verticale_Verticale_Est = new CombinaisonTrajets(Verticale, Verticale_Est, 2);
            CombinaisonTrajets Verticale_Horizontale = new CombinaisonTrajets(Verticale, Horizontale, 2);
            CombinaisonTrajets Verticale_Horizontale_Sud = new CombinaisonTrajets(Verticale, Horizontale_Sud, 2);

            //COMBINAISONS TRES NUL
            CombinaisonTrajets Verticale_Ouest_Verticale_Est = new CombinaisonTrajets(Verticale_Ouest, Verticale_Est, 1);
            CombinaisonTrajets Verticale_Est_Verticale_Est = new CombinaisonTrajets(Verticale_Est, Verticale_Est, 1);
            CombinaisonTrajets Verticale_Est_Horizontale = new CombinaisonTrajets(Verticale_Est, Horizontale, 1);
            CombinaisonTrajets Verticale_Est_Horizontale_Sud = new CombinaisonTrajets(Verticale_Est, Horizontale_Sud, 1);
            CombinaisonTrajets Horizontale_Nord_Horizontale = new CombinaisonTrajets(Horizontale, Horizontale_Nord, 1);
            CombinaisonTrajets Horizontale_Nord_Horizontale_Sud = new CombinaisonTrajets(Horizontale, Horizontale_Sud, 1);


            //LISTE DES COMBINAISONS
            List<CombinaisonTrajets> listeCombinaisonsTrajets = new List<CombinaisonTrajets>
            {
            Verticale_Ouest_Verticale_Ouest, Verticale_Ouest_Verticale, Verticale_Verticale, Verticale_Horizontale_Nord, Horizontale_Nord_Horizontale_Nord,
            Verticale_Ouest_Horizontale_Nord, Verticale_Ouest_Horizontale, Verticale_Ouest_Horizontale_Sud, Horizontale_Horizontale_Sud, Horizontale_Sud_Horizontale_Sud,
            Verticale_Est_Horizontale_Nord, Horizontale_Horizontale, Triple_Verticale_Est,
            Verticale_Verticale_Est, Verticale_Horizontale, Verticale_Horizontale_Sud,
            Verticale_Ouest_Verticale_Est, Verticale_Est_Verticale_Est, Verticale_Est_Horizontale, Verticale_Est_Horizontale_Sud, Horizontale_Nord_Horizontale, Horizontale_Nord_Horizontale_Sud
            };
            

            //VILLES
            Ville Denver = new Ville("Denver");
            Ville El_Paso = new Ville("El Paso");
            Ville Duluth = new Ville("Duluth");
            Ville Pittsburgh = new Ville("Pittsburgh");
            Ville Winnipeg = new Ville("Winnipeg");
            Ville Houston = new Ville("Houston");
            Ville Calgary = new Ville("Calgary");
            Ville Los_Angeles = new Ville("Los Angeles");
            Ville Chicago = new Ville("Chicago");
            Ville Vancouver = new Ville("Vancouver");
            Ville Montreal = new Ville("Montréal");
            Ville Seattle = new Ville("Seattle");
            Ville New_York = new Ville("New York");
            Ville Helena = new Ville("Helena");
            Ville Salt_Lake_City = new Ville("Salt Lake City");
            Ville Santa_Fe = new Ville("Santa Fe");
            Ville Portland = new Ville("Portland");
            Ville Phoenix = new Ville("Phoenix");
            Ville Little_Rock = new Ville("Little Rock");
            Ville Miami = new Ville("Miami");
            Ville San_Francisco = new Ville("San Francisco");
            Ville Atlanta = new Ville("Atlanta");
            Ville Nashville = new Ville("Nashville");
            Ville Sault_Ste_Marie = new Ville("Sault Ste-Marie");
            Ville Oklahoma_City = new Ville("Oklahoma City");
            Ville Toronto = new Ville("Toronto");
            Ville Kansas_City = new Ville("Kansas City");
            Ville New_Orleans = new Ville("New Orleans");
            Ville Dallas = new Ville("Dallas");
            Ville Boston = new Ville("Boston");


            //CARTES DESTINATION

            //TRES BIEN
            CarteDestinationExpert Denver_El_Paso = new CarteDestinationExpert(Denver, El_Paso, 4, Verticale, 5); //+verticaleOuest !
            CarteDestinationExpert Helena_Los_Angeles = new CarteDestinationExpert(Helena, Los_Angeles, 8, Verticale_Ouest, 5);
            CarteDestinationExpert Duluth_El_Paso = new CarteDestinationExpert(Duluth, El_Paso, 10, Verticale, 5); //+verticaleOuest !
            CarteDestinationExpert Denver_Pittsburgh = new CarteDestinationExpert(Denver, Pittsburgh, 11, Horizontale, 5);
            CarteDestinationExpert Winnipeg_Houston = new CarteDestinationExpert(Winnipeg, Houston, 12, Verticale, 5);
            CarteDestinationExpert Calgary_Phoenix = new CarteDestinationExpert(Calgary, Phoenix, 13, Verticale_Ouest, 5);
            CarteDestinationExpert Los_Angeles_Chicago = new CarteDestinationExpert(Los_Angeles, Chicago, 16, Horizontale, 5);
            CarteDestinationExpert Vancouver_Montreal = new CarteDestinationExpert(Vancouver, Montreal, 20, Horizontale_Nord, 5);
            CarteDestinationExpert Seattle_New_York = new CarteDestinationExpert(Seattle, New_York, 22, Horizontale_Nord, 5);

            //BIEN
            CarteDestinationExpert Calgary_Salt_Lake_City = new CarteDestinationExpert(Calgary, Salt_Lake_City, 7, Verticale_Ouest, 4);
            CarteDestinationExpert Duluth_Houston = new CarteDestinationExpert(Duluth, Houston, 8, Verticale, 4);
            CarteDestinationExpert Chicago_Santa_Fe = new CarteDestinationExpert(Chicago, Santa_Fe, 9, Horizontale, 4);
            CarteDestinationExpert Portland_Phoenix = new CarteDestinationExpert(Portland, Phoenix, 11, Verticale_Ouest, 4);
            CarteDestinationExpert Winnipeg_Little_Rock = new CarteDestinationExpert(Winnipeg, Little_Rock, 11, Verticale, 4);
            CarteDestinationExpert Vancouver_Santa_Fe = new CarteDestinationExpert(Vancouver, Santa_Fe, 13, Verticale_Ouest, 4);
            CarteDestinationExpert Los_Angeles_Miami = new CarteDestinationExpert(Los_Angeles, Miami, 20, Horizontale_Sud, 4);
            CarteDestinationExpert Los_Angeles_New_York = new CarteDestinationExpert(Los_Angeles, New_York, 21, Horizontale, 4);

            //MOYEN
            CarteDestinationExpert Seattle_Los_Angeles = new CarteDestinationExpert(Seattle, Los_Angeles, 9, Verticale_Ouest, 3);
            CarteDestinationExpert San_Francisco_Atlanta = new CarteDestinationExpert(San_Francisco, Atlanta, 17, Horizontale_Sud, 3);
            CarteDestinationExpert Portland_Nashville = new CarteDestinationExpert(Portland, Nashville, 17, Horizontale, 3);

            //NUL
            CarteDestinationExpert Sault_Ste_Marie_Nashville = new CarteDestinationExpert(Sault_Ste_Marie, Nashville, 8, Verticale_Est, 2);
            CarteDestinationExpert Sault_Ste_Marie_Oklahoma_City = new CarteDestinationExpert(Sault_Ste_Marie, Oklahoma_City, 9, Verticale, 2);
            CarteDestinationExpert Toronto_Miami = new CarteDestinationExpert(Toronto, Miami, 10, Verticale_Est, 2);

            //TRES NUL
            CarteDestinationExpert Kansas_City_Houston = new CarteDestinationExpert(Kansas_City, Houston, 5, Verticale, 1);
            CarteDestinationExpert New_York_Atlanta = new CarteDestinationExpert(New_York, Atlanta, 6, Verticale_Est, 1);
            CarteDestinationExpert Chicago_New_Orleans = new CarteDestinationExpert(Chicago, New_Orleans, 7, Verticale_Est, 1);
            CarteDestinationExpert Montreal_Atlanta = new CarteDestinationExpert(Montreal, Atlanta, 9, Verticale_Est, 1);
            CarteDestinationExpert Dallas_New_York = new CarteDestinationExpert(Dallas, New_York, 11, Verticale_Est, 1);
            CarteDestinationExpert Boston_Miami = new CarteDestinationExpert(Boston, Miami, 12, Verticale_Est, 1);
            CarteDestinationExpert Montreal_New_Orleans = new CarteDestinationExpert(Montreal, New_Orleans, 13, Verticale_Est, 1);

            List<CarteDestinationExpert> PileDesDestinations = new List<CarteDestinationExpert>
            {
                //Itinéraires TB
                Denver_El_Paso,         //Itinéraire 0
                Helena_Los_Angeles,     //Itinéraire 1
                Duluth_El_Paso,         //Itinéraire 2
                Denver_Pittsburgh,      //Itinéraire 3
                Winnipeg_Houston,       //Itinéraire 4
                Calgary_Phoenix,        //Itinéraire 5
                Los_Angeles_Chicago,    //Itinéraire 6
                Vancouver_Montreal,     //Itinéraire 7
                Seattle_New_York,       //Itinéraire 8

                //Itinéraires B
                Calgary_Salt_Lake_City, //Itinéraire 9
                Duluth_Houston,         //Itinéraire 10
                Chicago_Santa_Fe,       //Itinéraire 11
                Portland_Phoenix,       //Itinéraire 12
                Winnipeg_Little_Rock,   //Itinéraire 13
                Vancouver_Santa_Fe,     //Itinéraire 14
                Los_Angeles_Miami,      //Itinéraire 15
                Los_Angeles_New_York,   //Itinéraire 16

                //Itinéraires M
                Seattle_Los_Angeles,    //Itinéraire 17
                San_Francisco_Atlanta,  //Itinéraire 18
                Portland_Nashville,     //Itinéraire 19

                //Itinéraires N
                Sault_Ste_Marie_Nashville,      //Itinéraire 20
                Sault_Ste_Marie_Oklahoma_City,  //Itinéraire 21
                Toronto_Miami,                  //Itinéraire 22
                            
                //Itinéraires TN
                Kansas_City_Houston,    //Itinéraire 23
                New_York_Atlanta,       //Itinéraire 24
                Chicago_New_Orleans,    //Itinéraire 25
                Montreal_Atlanta,       //Itinéraire 26
                Dallas_New_York,        //Itinéraire 27
                Boston_Miami,           //Itinéraire 28
                Montreal_New_Orleans    //Itinéraire 29
            };

            //=====================
            //SIMULATION D'UN CHOIX
            //=====================


            //SIMULATION DE PIOCHE ALEATOIRE            
            Console.WriteLine("\nPIOCHE ALEATOIRE");
            List<int> piocheAleatoire = Generer3int();
            SimuleChoixExpert(PileDesDestinations, listeCombinaisonsTrajets, piocheAleatoire);

            //SIMULATION DE PIOCHE DETERMINEE : ENTRER 3 NOMBRES DISTINCTS DANS [|0,29|]
            Console.WriteLine("\nPIOCHE DETERMINEE");
            List<int> choixCartesPiochees = new List<int> { 3, 5, 7 };
            SimuleChoixExpert(PileDesDestinations, listeCombinaisonsTrajets, choixCartesPiochees);

            //SIMULATION DE PIOCHE ALEATOIRE *n
            /*
            List<int> piocheAleatoire;
            for (int i = 0; i<n; i++)
            {
                piocheAleatoire = Generer3int();
                SimuleChoixExpert(PileDesDestinations, listeCombinaisonsTrajets, piocheAleatoire);
            }
            */

            ///TESTS
            ///
            /// TEST 1 AVEC 100 PIOCHES ALEATOIRES : 15% DE CHOIX ARBITRAIRE AVEC POINTS
            /// TEST 2 AVEC 100 PIOCHES ALEATOIRES : 11% DE CHOIX ARBITRAIRE AVEC POINTS
            /// TEST 3 AVEC 100 PIOCHES ALEATOIRES : 10% DE CHOIX ARBITRAIRE AVEC POINTS
            /// TEST 4 AVEC 100 PIOCHES ALEATOIRES : 21% DE CHOIX ARBITRAIRE AVEC POINTS
            /// TEST 5 AVEC 100 PIOCHES ALEATOIRES : 10% DE CHOIX ARBITRAIRE AVEC POINTS
            /// 
            /// MOYENNE EMPIRIQUE : 13.4% DE CHOIX ARBITRAIRE PAR LES POINTS
            /// SOIT 86.6% DE CAS POUR LESQUELS UN MAXIMUM EST DISTINGUE SUR 500 CARTES PIOCHEES

        }

        //GERE L'AFFICHAGE DU CHOIX DU SYSTEME EXPERT
        public static void SimuleChoixExpert(List<CarteDestinationExpert> PileDesDestinations, List<CombinaisonTrajets> listeCombinaisonsTrajets, List<int> numCartesPiochees)
        {            
            List<CarteDestinationExpert> cartesPiochees = new List<CarteDestinationExpert> { };
            foreach (int n in numCartesPiochees) { cartesPiochees.Add(PileDesDestinations[n]); }

            CarteDestinationExpert c1 = cartesPiochees[0];
            CarteDestinationExpert c2 = cartesPiochees[1];
            CarteDestinationExpert c3 = cartesPiochees[2];

            //SIMULATION DU CHOIX
            List<CarteDestinationExpert> choix1 = new List<CarteDestinationExpert> { };
            choix1 = ChoixObjectif(c1, c2, c3, listeCombinaisonsTrajets);

            Console.WriteLine("Itinéraires choisis : ");
            foreach (CarteDestinationExpert carte in choix1)
            {
                Console.WriteLine(carte);
            }

            Console.WriteLine("================================================");
        }

        //RENVOIT UNE LISTE DE DEUX ITINERAIRES A PARTIR D'UNE LISTE DE 3
        public static List<CarteDestinationExpert> ChoixObjectif(CarteDestinationExpert itineraire1, CarteDestinationExpert itineraire2, CarteDestinationExpert itineraire3, List<CombinaisonTrajets> listeCombinaison)
        {
            //ON EVALUE LA NOTE DE CHAQUE COMBINAISON
            int valcomb1 = NoterCombinaison(itineraire1, itineraire2, listeCombinaison);
            int valcomb2 = NoterCombinaison(itineraire1, itineraire3, listeCombinaison);
            int valcomb3 = NoterCombinaison(itineraire2, itineraire3, listeCombinaison);

            //ON AFFICHE LES POSSIBILITES D'ITINERAIRES
            Console.WriteLine("\nItinéraires possibles : \n" + itineraire1 + "\n" + itineraire2 + "\n" + itineraire3 + "\n");
            List<CarteDestinationExpert> Choix = new List<CarteDestinationExpert> { itineraire1, itineraire2, itineraire3 };

            //CAS EXCEPTIONNEL TRIPLE VERTICAL EST : TRANSPOSABLE A TOUTES LES CATEGORIES ?
            if (itineraire1._typeTrajet.ToString() == "Verticale Est" && itineraire2._typeTrajet.ToString() == "Verticale Est" && itineraire3._typeTrajet.ToString() == "Verticale Est")
                return Choix;

            //ON CALCULE LA NOTE DE CHAQUE PAIRE
            int n1 = itineraire1._noteExpert + itineraire2._noteExpert + valcomb1;
            int n2 = itineraire1._noteExpert + itineraire3._noteExpert + valcomb2;
            int n3 = itineraire2._noteExpert + itineraire3._noteExpert + valcomb3;


            //ON COMPARE LES PAIRES
            //1/ on peut distinguer un max
            if (max(n1, n2, n3) != -100)
            {
                if (max(n1, n2, n3) == n1)                
                    Choix.Remove(itineraire3);
                

                if (max(n1, n2, n3) == n2)                
                    Choix.Remove(itineraire2);
                

                if (max(n1, n2, n3) == n3)                
                    Choix.Remove(itineraire1);

                Console.WriteLine("\nMAXIMUM DETERMINE\n");
                return Choix;
            }

            //s'il n'y a pas de max, c'est qu'on a 2 max ou bien que les 3 se valent

            //2/ on peut discriminer un min
            if (min(n1, n2, n3) != -100)
            {
                //on privilégie les points
                Console.WriteLine("\nMINIMUM DETERMINE - UTILISATION DU CRITERE ARBITRAIRE DU MAXIMUM DE POINTS\n");

                if (min(n1, n2, n3) == n1)
                {
                    if (itineraire1._valeurPoints > itineraire2._valeurPoints)                    
                        Choix.Remove(itineraire2);
                    
                    else                    
                        Choix.Remove(itineraire1);
                    
                    return Choix;
                }

                if (min(n1, n2, n3) == n2)
                {
                    if (itineraire1._valeurPoints > itineraire3._valeurPoints)                    
                        Choix.Remove(itineraire3);
                    
                    else                    
                        Choix.Remove(itineraire1);
                    
                    return Choix;
                }

                if (min(n1, n2, n3) == n3)
                {
                    if (itineraire2._valeurPoints > itineraire3._valeurPoints)                    
                        Choix.Remove(itineraire3);
                    
                    else                    
                        Choix.Remove(itineraire2);
                    
                    return Choix;

                }
            }

            //3/ ni max, ni min : toutes les combinaisons se valent : on choisit celle qui vaut le plus de points

            Console.WriteLine("\nTOUTES LES COMBINAISONS SE VALENT, UTILISATION DU CRITERE ARBITRAIRE DU MAXIMUM DE POINTS\n");

            int v1 = itineraire1._valeurPoints + itineraire2._valeurPoints;
            int v2 = itineraire1._valeurPoints + itineraire3._valeurPoints;
            int v3 = itineraire2._valeurPoints + itineraire3._valeurPoints;

            if (max(v1, v2, v3) == v1)            
                Choix.Remove(itineraire3);
            
            else if (max(v1, v2, v3) == v2)
                Choix.Remove(itineraire2);
            
            else            
                Choix.Remove(itineraire1);
            
            return Choix;

        }


        //===============
        //FONCTIONS OUTIL
        //===============

        //DONNE LA NOTE DE LA COMBINAISON ENTRE DEUX CARTES DESTINATION
        public static int NoterCombinaison(CarteDestinationExpert c1, CarteDestinationExpert c2, List<CombinaisonTrajets> listeCombinaison)
        {
            foreach (CombinaisonTrajets combinaison in listeCombinaison)
            {
                if (combinaison._trajet1 == c1._typeTrajet && combinaison._trajet2 == c2._typeTrajet || combinaison._trajet2 == c2._typeTrajet && combinaison._trajet1 == c1._typeTrajet)
                    return combinaison._noteExpert;
            }
            return -1;
        }
        
        //GENERE 3 INT ALEATOIRES
        public static List<int> Generer3int()
        {
            List<int> entiers = new List<int> { };
            Random random = new Random();
            int valeur;

            while (entiers.Count() != 3)
            {
                valeur = random.Next(30);
                if (!entiers.Contains(valeur))
                {
                    entiers.Add(valeur);
                }
            }

            return entiers;
        }

        //DEFINITION D'UNE FONCTION MIN A 3 PARAMETRES
        public static int min(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 > n3) return n1;
            else
            if (n2 > n1 && n2 > n3) return n2;
            else
            if (n3 > n1 && n3 > n2) return n3;
            else return -100; //renvoit -100 s'il n'y a pas de MIN ABSOLU
        }

        //DEFINITION D'UNE FONCTION MAX A 3 PARAMETRES
        public static int max(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3) return n1;
            else
            if (n2 > n1 && n2 > n3) return n2;
            else
            if (n3 > n1 && n3 > n2) return n3;
            else return -100; //renvoit -100 s'il n'y a pas de MAX ABSOLU
        }        
    }
}
