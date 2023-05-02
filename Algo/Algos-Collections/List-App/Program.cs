// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> noms = new List<string>();

List<string> autreNoms = new List<string>()
{
    "toto", 
    "prenom" , 
    "tata", 
    "titi", 
    "tutu"
};

Console.WriteLine(autreNoms[2]);

autreNoms[2] = "le nom qu'on veut changer";

Console.WriteLine(autreNoms[2]);

autreNoms.Add("Nicolas");
autreNoms.RemoveAt(1);
autreNoms.AddRange(new string[] { "aaa", "bbb" });


int i;

for(i = 0; i < autreNoms.Count; i++)
{
    Console.WriteLine("La valeur à l'index {0} est {1}", i, autreNoms[i]);
}


List<string> resultat = autreNoms.FindAll(item => item.Contains('o'));

/*foreach(string item in autreNoms)
{
    if(item.Contains('o'))
    {
        resultat.Add(item);
    }
}*/

Console.WriteLine("end");