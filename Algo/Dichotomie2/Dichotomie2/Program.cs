namespace Dichotomie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LA RECHERCHE PAR DICHOTOMIE
             * La recherche par dichotomie consiste à rechercher un élèment dans un tableau trié par ordre croissant, en le comparant
             * à l'élèment au milieu du tableau pour savoir si il se situe avant ou après l'élèment centrale.
             */

            /*
             * PSEUDO CODE
             * 
             * DECLARATION
             * déclarer tableau de string noms
             * déclarer string nomAChercher
             * déclarer int min
             * déclarer int max
             * déclarer int delta
             * déclarer int mediane
             * declarer booleen find
             * TRAITEMENT
             * noms <-- {agathe, berthe, chloé, cunégonde, olga, raymonde, sidonie}
             * min <-- 0
             * max <-- longueur de noms
             * nomAChercher <-- olga
             * delta <-- (max - min) / 2
             * médiane <-- min + delta
             * find <-- noms[mediane] egal nomAChercher
             * ECRIRE "Bonjour, vous êtes sur le programme de recherche par dichotomie"
             * TANT QUE (!find et delta different de 0)
             *  
             *  SI nomAChercher est alphabétiquement avant noms[mediane]
             *  max <-- mediane
             *  
             *  SINON
             *  min <-- mediane
             *  
             *  FIN SI
             *  delta <-- (max - min) / 2
             *  médiane <-- min + delta
             *  find <-- noms[mediane] egal nomAChercher
             *  
             *  SI !find et delta == 0
             *      SI nom[max] == nomAChercher
             *          mediane <-- max
             *          find <-- true
             *      FINSI
             *      
             *  FINSI
             * FIN TANT QUE 
             * 
             * AFFICHAGE
             * SI find est vrai
             * ECRIRE "Le nom a été trouvé à l'indice ", mediane
             * SINON
             * ECRIRE "Le nom n'est pas présent dans le tableau"
             * FINSI
             * 
             * FONCTION
             * 
             */
            string[] noms = new[] { "aaa","agathe", "berthe", "chloé", "cunégonde","olga", "raymonde", "sidonie" };
            string nomAChercher = "sidonie";
            int min = 0;
            int max = noms.Length-1;
            int delta = (max - min) / 2;
            int mediane = min + delta;
            bool find = noms[mediane] == nomAChercher;

            Console.WriteLine("Bonjour, vous êtes sur le programme de recherche par dichotomie.");

            while (!find && delta != 0)
            {
                if (nomAChercher.CompareTo(noms[mediane])<0)
                {
                    max = mediane;
                }
                else
                {
                    min = mediane;
                }

                delta = (max - min) / 2;
                mediane = min + delta;
                find = noms[mediane] == nomAChercher;

                if (!find && delta == 0)
                {
                    if (noms[max] == nomAChercher)
                    {
                        mediane = max;
                        find = true;
                    }
                }
            }
            if( find)
            {
                Console.WriteLine($"Le nom a été trouvé à l'indice {mediane}");
            }
            else 
            {
                Console.WriteLine($"Le nom n'existe pas dans la liste.");
            }


        }
    }
}