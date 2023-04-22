public class Enemy : Character
{
    public Enemy()
    {
        names = new List<string>(){"Babu","Frikk","Gargamell","Limpa","Åsna","Donkey","Sven"};
        rect = new Rectangle(800, 400, 50, 100);
        color = Color.RED;
        index = rnd.Next(names.Count);
        name = names[index];
    }

    public override void Draw()
    {
        base.Draw();
    }

}
