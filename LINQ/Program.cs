namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>() {"Age of Empires", "Counter-Strike", "Command & Conquer", "SimCity", "Unreal Tournament"};

            var orderedGameNames = gameNames.OrderBy(x => x.Length).ToList();

            orderedGameNames.ForEach(x => Console.WriteLine(x));

        }
    }
}
