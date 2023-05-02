/* Jeu de la fourchette
 * Declaration des variables
 * entier mystere
 * entier donne
 * entier borneMin
 * entier borneMax
 * entier nombreEssai
 * Traitement
 * borneMin <--0
 * borneMax <--100
 * mystere <-- Random(borneMin,borneMax)
 * ecrire("Saisir un entier entre ",borneMin," et ",borneMax)
 * lire(donne)
 * nombreEssai<--1
 * tant que (donne!=mystere):
 *      si donne<mystere:
 *          borneMin<--donne
 *      sinon:
 *          borneMax<--donne
 *      fin si
 *       ecrire("Saisir un entier entre ",borneMin," et ",borneMax)
 *      lire(donne)
 *      nombreEssai++
 * fin tant que
 * Affichage
 * ecrire("Vous avez trouve apres ",nombreEssai," essai.s. ")
 */

int borneMin = 0;
int borneMax = 100;
int donne;
int nombreEssai = 0;
Random rand = new Random();//Creation objet aleatoire
int mystere = rand.Next(borneMin, borneMax+1);//Affectation du nombre mystere aleatoire


Console.WriteLine("Saisir un entier compris entre {0} et {1}",borneMin,borneMax);
donne=int.Parse(Console.ReadLine());
nombreEssai = 1;
while (donne != mystere)
{
    if (donne<mystere)
    {
        borneMin = donne;
    }
    else
    {
        borneMax = donne;
    }
    Console.WriteLine("Saisir un entier compris entre {0} et {1}", borneMin, borneMax);
    donne = int.Parse(Console.ReadLine());
    nombreEssai++;
}

/*
do
{
    Console.WriteLine("Saisir un entier compris entre {0} et {1}", borneMin, borneMax);
    donne = int.Parse(Console.ReadLine());
    if (donne < mystere)
    {
        borneMin = donne;
    }
    else
    {
        borneMax = donne;
    }
    nombreEssai++;
} while (donne != mystere);
*/
string sOuNon = (nombreEssai > 1) ? "s" : "";
/*string sOrNot = (nombreEssai > 1) ? "tries" : "try";
string sOrNot;
if (nombreEssai > 1){
    sOrNot = "tries";
}
else
{
    sOrNot = "try";
}*/
Console.WriteLine("Vous avez trouvé après {0} coup{1}. ",nombreEssai, sOuNon);