public class Dodge : Moves
{
    public Dodge()
    {
        name = "Dodge";

    }
    public void Avoid()
    {
        speed = generator.Next(7,12);
    }

}
