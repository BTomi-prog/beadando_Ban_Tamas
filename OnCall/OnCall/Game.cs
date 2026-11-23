using System.Text;

namespace OnCall
{
    internal class Game
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8; // hogy az ékezetes betűk jól jelenjenek meg
            Console.WriteLine(Texts.Title);
            Console.WriteLine();
            Console.WriteLine(Texts.Intro);
            Console.WriteLine();

            // TODO: a játék főciklusa (K1-K6)
            Console.WriteLine("Add meg a neved:");
            string name = Console.ReadLine();
            while (name == string.Empty)
            {
                Console.WriteLine("Add meg a neved:");
                name = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez.");
            Console.ReadKey(true);
        }
    }
}
