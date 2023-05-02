Console.Title = "Toto";

int floor = 1;
int nbCard = 0;
int remainingCards = 0;
int cardUsed = 0;
bool validInput = false;
Console.WriteLine("Combien de carte posséder vous ?");
while(!validInput)

try
{
    nbCard = int.Parse(Console.ReadLine());
        validInput = true;
}
catch
{
    Console.WriteLine("Veuillez rentrer un nombre svp");
}
remainingCards = nbCard;

// LE CHATEAU DE CARTE EST UNE SUITE ARITHMETIQUE DE RAISON R = 3
// SON U0  = 2 ET Un = U0 + 3n
if (nbCard > 2)
{
    remainingCards -= 2;
    while (remainingCards - (2 + 3*floor) >= 0)
    {
        remainingCards -= (2 + 3 * floor);
        floor++;
    }
}
Console.WriteLine("Vous pouvez faire " + (floor) + " étage avec vos "+nbCard + " cartes " + 
    (remainingCards > 0 ? "et il vous restera " + remainingCards + " carte(s). " : "tout rond!"));