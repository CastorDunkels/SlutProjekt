public class Dodge : Moves
{
    public void Defensive()//denna metod ska ge en variabel ett värde mellan 5 - 12 
    {
        name = "dodge";
        speed = generator.Next(6,12);
        
    }

}
