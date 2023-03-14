public class Dodge : Moves
{
    public void Avoid()
    {
        speed = generator.Next(7,12);
    }
}
