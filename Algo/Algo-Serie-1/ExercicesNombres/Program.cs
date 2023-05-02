namespace ExercicesNombres
{
    /*Recherche de diviseurs d'un nombre 
             * Pour trouver tous les diviseurs d'un nombre, on parcourt tous les nombres inferieurs 
             * a sa moitiee et on teste si le reste est egal a zero. 
             * DECLARATION DES VARIABLES
             * string input
             * entier inputConvert
             * entier i
             * liste entiers[] diviseurs
             * TRAITEMENT
             * Ecrire ("Programme de listage des diviseurs d'un nombre entier")
             * Ecrire ("Veuillez saisir un nombre entier")
             * Faire
             *      Lire(input)
             * Tant que convertirEnEntier(input) impossible
             * inputConvert=convertirEnEntier(input)
             * Pour i de 1 à inputConvert//2, i++:
             *      Si inputConvert%i==0:
             *          Ajouter i à diviseurs
             * AFFICHAGE
             * Ecrire("Les diviseurs de input sont ", diviseurs)
            */
    public class Program
    {
        static void Main(string[] args)
        {
            
            int inputConvert;
            List<int> diviseurs = new List<int>();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Recherche de diviseurs d'un nombre");
            
            inputConvert = GetUserInput();
            
            diviseurs = TrouveDiviseur(inputConvert);

            TrouveDiviseur("23"); // utilisation de la surcharge (paramètre de type string)

            Console.WriteLine("Les diviseurs sont : ");
            
            foreach(int i in diviseurs)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Retourne la saisie utilisateur convertie de string en int
        /// </summary>
        /// <returns>La saisie utilisateur sous forme d'entier</returns>
        public static int GetUserInput()
        {
            string input;
            int inputConvert;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Saisir un nombre entier : ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputConvert));
            return inputConvert;
        }

        public static int GetUserInputV1_5()
        {
            Console.WriteLine("Saisir un nombre entier : ");
            string input = Console.ReadLine();
            int inputConvert;

            if (int.TryParse(input, out inputConvert))
            {
                return inputConvert;
            }

            return GetUserInputV1_5();
            
        }

        public static int GetUserInputV2()
        {
            Console.WriteLine("Saisir un nombre entier : ");
            return (int.TryParse(Console.ReadLine(),out int input)  ? input : GetUserInputV2());
        }

        /// <summary>
        /// Retourne les diviseurs d'un nombre donné
        /// </summary>
        /// <param name="input">Le nombre à convertir et à évaluer</param>
        /// <returns>La liste des diviseurs du nombre donné</returns>
        private static List<int> TrouveDiviseur(string input)
        {
            return TrouveDiviseur(Convert.ToInt32(input));
        }


        /// <summary>
        /// Retourne les diviseurs d'un nombre donné
        /// </summary>
        /// <param name="input">Le nombre à évaluer</param>
        /// <returns>La liste des diviseurs du nombre donné</returns>
        public static List<int> TrouveDiviseur(int input)
        {
            input = Math.Abs(input);
            List<int> diviseurs = new List<int>();
            int i;
            int limit = input / 2; //Max du parcours des possibles diviseurs
            for (i = 2; i <= limit; i++)
            {
                if (input % i == 0)
                {
                    diviseurs.Add(i);
                }
            }
            return diviseurs;
        }
    }
}