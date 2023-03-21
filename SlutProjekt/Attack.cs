public class Attack : Moves
{


    public void MediumAttack() //gör denna attack den enda attack metod om jag kan
    {
        name = "Medium Attack";
        dmg = generator.Next(66,140);
        attack = generator.Next(0,4);

        /*
        if(attack - speed > 0){

            e.health -= dmg;
            Raylib.DrawText($"You did {dmg} dmg.");

        }
        else{
            Console.WriteLine("Miss");
        }
        */
    }

    /*public void LightAttack()
    {
        name = "Light Attack";
        dmg = generator.Next(22,66);
        attack = generator.Next(0,7);

        //health -= dmg;
    }

    public void StrongAttack()
    {
        name = "Strong Attack";
        dmg = generator.Next(140,350);
        attack = generator.Next(0,2);     

        //health -= dmg;
    }*/


}
