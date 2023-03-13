using System.Reflection.Metadata;
using System.CodeDom.Compiler;
public class LightAttack : Attack
{
    public LightAttack()
    {
        dmg = generator.Next(24, 66);
        
        attack = generator.Next(0, 10);
        
        name = "Light Attack";
    }
}
