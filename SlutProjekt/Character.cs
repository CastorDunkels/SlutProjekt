public class Character
{

    protected int health = 1500;

    protected Random rnd = new Random();

    protected List<string> names = new List<string>() { "Bengt", "Björn", "Chris P Rat", "Pelle", "Sten", "Shrek" };

    protected int index;

    public Rectangle rect;

    protected string name = "";

    protected Color color;

    public void TakeDamage()//denna metod ska ta information från både Dodge och Attack klasserna och räkna ut om attacken träffar eller inte 
    {

    }
    public virtual void Update()
    {
       

    }

    public virtual void Draw()
    {
        Raylib.DrawText(name, (int)rect.x, (int)rect.y - 50, 30, color);
        Raylib.DrawRectangleRec(rect, color);
    }

    public virtual void MenuClicked(int x)
    {
    }



}
