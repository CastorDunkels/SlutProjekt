public class Character
{
    private Menu menu;

    private bool menuShown = false;

    protected int health = 1500;

    protected Random rnd = new Random();

    protected List<string> names = new List<string>() { "Bengt", "Björn", "Chris P Rat", "Pelle", "Sten", "Shrek" };

    protected int index;

    public Rectangle rect;

    protected string name = "";

    protected Color color;

    public Character()
    {
        menu = new Menu(new List<Color>() { Color.BLACK, Color.BROWN }, this);
    }

    public void TakeDamage()//denna metod ska ta information från både Dodge och Attack klasserna och räkna ut om attacken träffar eller inte 
    {

    }
    public void Update()
    {
        if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), rect) && Raylib.IsMouseButtonPressed(0))
        {
            menuShown = true;
        }
        if (menuShown == true)
        {
            menu.Update();
        }

    }

    public virtual void Draw()
    {
        Raylib.DrawText(name, (int)rect.x, (int)rect.y - 50, 30, color);
        Raylib.DrawRectangleRec(rect, color);
        if (menuShown == true)
        {
            menu.Draw();
        }
    }

    public void MenuClicked(int x)
    {
        menuShown = false;
        Raylib.DrawText("giusdhofs" + x, 100, 500, 40, Color.BLACK);

    }



}
