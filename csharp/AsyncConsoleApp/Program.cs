namespace AsyncConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Task.Run(Tache1);
            Task.Run(Tache2);
            Tache0();
            Task.Run(Tache3);
            Console.WriteLine("Programme terminé !");
            Console.ReadLine();
        }

        static void Tache0()
        {
            Console.WriteLine("Tâche 00 terminée !");
        }

        static async Task Tache1()
        {
            await Task.Delay(5000);
            Console.WriteLine("Tâche 1 terminée !");
        }

        static async Task Tache2()
        {
            await Task.Delay(4000);
            Console.WriteLine("Tâche 2 terminée !");
        }

        static async Task Tache3()
        {
            await Task.Delay(2000);
            Console.WriteLine("Tâche 3 terminée !");
        }
    }
}