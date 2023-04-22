public class Attack : Moves
{


    public void Offensive() //Den här metoden ska kolla vilken strength det är och välja vilken attack det ska utföras, sen slumpar den några variablers värden
    {
        if(strength == 1)
        {
            name = "Light Attack";
            dmg = generator.Next(25,100);
            attack = generator.Next(0,9);
        }
        else if(strength == 2)
        {
            name = "Medium Attack";
            dmg = generator.Next(120,280);
            attack = generator.Next(0,5);
        }
        else{
            name = "Heavy Attack";
            dmg = generator.Next(500,1000);
            attack = generator.Next(0,2);

        }

    }


}
