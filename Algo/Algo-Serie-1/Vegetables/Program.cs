using System.Globalization;

namespace Vegetables
{
    internal class Program
    {
        /**
         * VARIABLES
         * 
         * Declarer list<chaine> grocery
         * Declarer list<float> prices
         * Declarer chaine userInput
         * Declarer chaine[] splitUserInput
         * Declarer float tempPrice
         * FAIRE
         *  Ecrire "Veuillez entrer un nom de légumes suivi par son prix au kilo \n
         *      le tout séparé par un espace (ex: \"carottes 2.99\")"
         *  Ecrire "Lorsque vous avez fini vous pouvez taper \"go\" pour afficher la liste et
         *      connaitre le moins cher"
         *  */
        /*
         *  Lire userInput
         *  userInput <-- userInput.ToLowerCase()
         *  Si (userInput != "go") ALORS
         *      splitUserInput <-- userInput.Split(" ")
         *      Si (splitUser.Length == 2) ALORS
         *          ESSAYER
         *              tempPrice <-- Convertir(splitUser[1])
         *              grocery[]<-- splitUser[0]
         *              prices[]<-- tempPrice
         *          ATTRAPER
         *              Ecrire "Le prix de ", userInput[0], " est incorrect."
         *          FINESSAYER
         *      Sinon
         *          Ecrire "saisie incorrecte, veuillez entrez deux valeurs séparées par un espace")
         *      FinSI
         *  FinSi 
         * TANT_QUE(userInput != "go")
         * 
         * TRAITEMENT
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Les légumes");

            List<string> grocery = new List<string>();
            List<float> prices = new List<float>();
            string userInput;
            string[] splitUserInput;
            float tempPrice;

            do
            {
                Console.WriteLine("Veuillez entrer un nom de légumes suivi par son prix au kilo " + Environment.NewLine + " le tout séparé par un espace(ex: \"carottes 2.99\")");
                Console.WriteLine("Lorsque vous avez fini vous pouvez taper \"go\" pour afficher la liste et connaitre le moins cher");

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();


                if (userInput != "go")
                {
                    splitUserInput = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if(splitUserInput.Length == 2)
                    {
                        try
                        {
                            // System.Globalization.CultureInfo.InvariantCulture = accepter point et virgule pour les nb décimaux
                            tempPrice = Math.Abs(float.Parse(splitUserInput[1], NumberStyles.Any, CultureInfo.InvariantCulture));
                            grocery.Add(splitUserInput[0]);
                            prices.Add(tempPrice);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Le prix de " + splitUserInput[0] + " est incorrect.");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saisie incorrecte, veuillez entrer deux valeurs séparées par un espace");
                    }
                } // fin if (userInput != "go")

            } while (userInput != "go");
            // } while (!userInput.Equals("go"));

            Affichage(grocery, prices);

        } // fin Main

        static void Affichage(List<string> _grocery, List<float> _prices)
        {
            if(_grocery.Count != _prices.Count)
            {
                return;
            }

            for(int i = 0; i < _grocery.Count; i++)
            {
                Console.WriteLine(_grocery[i] + " coute " + _prices[i] + " Euros.");
            }
        }
    } // fin Classe
} // fin namespace