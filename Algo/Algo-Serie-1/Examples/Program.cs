// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// RECHERCHER UN CARACTERE DANS UNE CHAINE
string subject = "mon super string";
char pattern = 'u';

if(subject.Contains(pattern))
{
    // trouvé !
}



// TESTER ET CONVERTIR UN STRING VERS UN NUMERIQUE

string userInput = "toto";
double result;

result = double.Parse(userInput); // lève une exception si la conversion échoue
result = Convert.ToDouble(userInput); // lève une exception si la conversion échoue

// ne lève pas d'exception et renvoie "false" en cas d'échec
bool isNumeric = double.TryParse(userInput, out result); 

if(double.TryParse(userInput, out result))
{

}

do
{
    isNumeric = double.TryParse(userInput, out result);
}
while (!isNumeric);


