public class Character
{
    protected int health = 1500;
    protected static Random rnd = new Random();
    protected static List<string> names = new List<string>() {"Bengt", "Björn", "Chris P Rat", "Pelle", "Sten"};
    protected static int index = rnd.Next(names.Count);
    protected string name = names[index];
}
