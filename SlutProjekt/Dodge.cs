public class Dodge : Moves
{
    public void Avoid()
    {
        name = "dodge";
        speed = generator.Next(6,12);
        
    }

}
