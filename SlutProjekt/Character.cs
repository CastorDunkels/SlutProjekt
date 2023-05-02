public class Character
{

    protected int health = 1500;

    protected Random rnd = new Random();

    protected List<string> names;

    protected int index;

    public Rectangle rect;

    protected string name = "";

    protected Color color;

    /*public void TakeDamage()//denna metod ska ta information från både Dodge och Attack klasserna och räkna ut om attacken träffar eller inte 
    {

    }*/
    public virtual void Update() //skapar en metod som inte gör något men kan bli överskriven med mer information i klasser som ärver från denna
    {
       

    }

    public virtual void Draw() //skapar en metod som har information men kan bli överskriven av andra klasser som ärver från denna
    {
        Raylib.DrawText(name, (int)rect.x, (int)rect.y - 50, 30, color);
        Raylib.DrawRectangleRec(rect, color);
    }

    public virtual void MenuClicked(int x) //metod som kan överskrivas
    {
    }



}
