// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string prenom = "johnny";
string autrePrenom = new String("Gérard");

string[] noms = new string[4];

noms[3] = "Raph";

string dernierElement = noms[3];

Console.WriteLine(dernierElement);


string[] autreNoms = new string[]
{
    "toto", prenom , "tata", "titi", "tutu"
};

int i;
int longueurTableau = autreNoms.Length;

for(i = 0; i < longueurTableau; i++)
{
    
    Console.WriteLine("La valeur à l'index {0} est {1}", i, autreNoms[i]);
}

for(i = longueurTableau-1; i >= 0; i--)
{
    Console.WriteLine("La valeur à l'index {0} est {1}", i, autreNoms[i]);
}

Console.WriteLine("end");

