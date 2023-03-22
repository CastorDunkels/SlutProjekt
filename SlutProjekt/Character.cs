public class Character
{
    protected int health = 1500;
    protected Random rnd = new Random();
    protected List<string> names = new List<string>() { "Bengt", "Björn", "Chris P Rat", "Pelle", "Sten", "Shrek" };
    protected int index;
    protected string name;

    public Character()
    {
         index = rnd.Next(names.Count);
         name = names[index];
    }
    public void TakeDamage()//denna metod ska ta information från både Dodge och Attack klasserna och räkna ut om attacken träffar eller inte 
    {
        
    }

    public void gudhs()
    {
        Console.WriteLine(name);
    }

}
