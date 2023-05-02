using ExercicesNombres;

namespace ExerciceNombrePremier
{
    internal class App
    {
        static void Main(string[] args)
        {
            int entierATester = Program.GetUserInput();

            List<int> diviseurs = Program.TrouveDiviseur(entierATester);

            if(diviseurs.Count == 0) 
            {
                Console.WriteLine("Premier");
            } 
            else
            {
                Console.WriteLine("Pas premier");
            }
            
            //Console.WriteLine(Program.TrouveDiviseur(Program.GetUserInput()).Count == 0 ? "Premier" : "Pas premier");
        }
    }
}