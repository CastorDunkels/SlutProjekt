public class Attack : Moves
{


    public void MediumAttack()
    {
        name = "Medium Attack";
        dmg = generator.Next(66,140);
        attack = generator.Next(0,4);
    }

    public void LightAttack()
    {
        name = "Light Attack";
        dmg = generator.Next(22,66);
        attack = generator.Next(0,7);
    }

    public void StrongAttack()
    {
        name = "Strong Attack";
        dmg = generator.Next(140,350);
        attack = generator.Next(0,2);        
    }


}
