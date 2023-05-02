/*   
 *   
 *              JEU DU PENDU
 *              
 *  ENONCE :    L'algorithme lit un mot proposé par le JOUEUR( 5 lettres MINIMUM)
 *          l'algorithme affiche ensuite le mot où toutes les lettres SAUF la PREMIERE et la DERNIERE sont remplacées par un tiret.
 *          un DEUXIEME JOUEUR propose des lettre une par une.
 *          
 *          chaque fois que la lettre proposée se trouve dans le mot, l'algorithme remplace les tirets par la lettres trouvées.
 *          Le SECOND JOUEUR dispose d'un maximum de 6 essais pour trouver le mot.
 *          
 *          
 *        
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // DECLARATION DE VARIABLES
        string userInput;
        char user2Input;
        char[] tabMot;
        int test = 6;

        // DEMANDE ET RECUPERATION DE LA SAISIE UTILISATEUR.
        Console.WriteLine("Saisir un mot de 5 lettres Minimum svp.");
        userInput = Console.ReadLine();

        // CONVERSION DE LA VARIABLE STRING EN TABLEAU DE CHAR
        tabMot = userInput.ToCharArray();

        //AFFICHAGE DU tabMot (facultatif)
        AffichageDuTableau(tabMot);

        // ici je crée un tableau (tabMotCacher) qui sera modifié, pour conserver (tabMot) pour comparaison.
        char[] tabMotCacher = tabMot;

        // DANS LE TABLEAU DE CHAR, JE REMPLACE LES CARACTERES PAR DES UNDERSCORE '_' SAUF LA PREMIERE ET LA DERNIERE.
        for (int i = 1; i < tabMotCacher.Length - 1; i++)
        {
            tabMotCacher[i] = '_';
        }
        //AFFICHAGE DU tabMotCacher (facultatif) pour voir la modif.
        AffichageDuTableau(tabMotCacher);

        Console.WriteLine("Pressez une touche et appelez le joueur 2 svp.");
        Console.ReadKey(); // attendre que le joueur 1 presse une touche pour lancer le jeu
        Console.Clear(); // vide la console donc efface de l'écran l'entrée du joueur 1

        // debut de partie joueur 2.

        // opération effectuée pour 1 tour de jeu.
        do
        {
            Console.WriteLine($"Joueur 2 entrez une lettre vous avez droit à {test} erreurs pour trouver le mot, bonne chance!");
            AffichageDuTableau(tabMotCacher);

            user2Input = Console.ReadLine()[0]; // recuperation de la première lettre donnee par le joueur 2 
            Console.WriteLine(user2Input);
            for (int i = 1; i < tabMotCacher.Length - 1; i++)
            {
                if ((char)tabMot[i] == user2Input)
                {
                    tabMotCacher[i] = (char)user2Input;
                }
                else 
                {
                   
                }
            }
            





        }
        while (test > 0 || tabMotCacher == tabMot);

















    }
    /// <summary>
    /// AFFICHAGE DU tabMot (facultatif)
    /// </summary>
    /// <param name="_tabMot"></param>
    static void AffichageDuTableau(char[] _tabMot)
    {
        foreach (int i in _tabMot)
        {
            Console.Write((char)i);
        }
        Console.WriteLine(); // Pour avoir un saut de ligne 
    }


}







/*
*          
*          
*          
*          
*          
*          
*          
*          
*          
*          
*          
*          
*          PHASE 1
*          
*          RECUPERER UN MOT saisie par le joueur UN
*          VERIFIER qu'il fasse bien 5 lettres au minimum.
*          REMPLACER les LETTRES du MOT sauf la PREMIERE et la DERNIERE par des "-"
*          
*          PHASE 2
*          
*          DEMANDER au joueur DEUX une Lettre.
*          VERIFIER que la LETTRE est cotenu dans le MOT
*          
*          SI LA LETTRE CORRESPOND
*          
*          REMPLACER le TIRET correspondant a la LETTRE par la lettre elle-même
*          
*              SI TOUTES LES LETTRES SONT TROUVEES
*              
*                  AFFICHER que le JOUEUR 2 a GAGNE
*                  FIN DE PARTIE
*              
*              SINON
*                  REPETER PHASE 2
*          
*          SINON
*          
*          AFFICHER que le JOUEUR DEUX c'est trompé et INCREMENTER un COMPTEUR
*              SI LE COMPTEUR EST EGAL A 6
*              AFFICHER que le joueur deux a perdu
*              FIN DE PARTIE
*              
*              SINON 
*              REPETER PHASE 2
*         */