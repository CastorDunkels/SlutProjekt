using System.Numerics;
public class Player : Character
{


    public Player()
    {
        rect = new Rectangle(200, 400, 50, 100);
        color = Color.GREEN;
        index = rnd.Next(names.Count);
        name = names[index];
        
    }

    public override void Draw()
    {
        base.Draw();


    }


}
