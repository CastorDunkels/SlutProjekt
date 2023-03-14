public class Attack : Moves
{


    public void MediumAttack()
    {
        dmg = generator.Next(66,140);
        attack = generator.Next(0,5);
    }

    public void LightAttack()
    {
        dmg = generator.Next(22,66);
        attack = generator.Next(0,8);
    }

    public void StrongAttack()
    {
        dmg = generator.Next(140,350);
        attack = generator.Next(0,3);        
    }


}
