public class Player : Character
{

    private Menu menu;

    public Player()
    {
        names = new List<string>() { "Bengt", "Björn", "Chris P Rat", "Pelle", "Sten", "Shrek" };
        rect = new Rectangle(200, 400, 50, 100);
        color = Color.GREEN;
        index = rnd.Next(names.Count);
        name = names[index];
        menu = new Menu((int)rect.x + 100, (int)rect.y, new List<Color>() {Color.BLUE}, this);
    }
    public override void Update()
    {
        menu.Update();
        if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), rect) && Raylib.IsMouseButtonPressed(0))
        {
            if (menu.IsVisible())
            {
                menu.SetVisible(false);
            }
            else
            {
                menu.SetVisible(true);
            }
        }
    }

    public override void Draw()
    {
        base.Draw();
        menu.Draw();
    }

    public override void MenuClicked(int x)
    {
        menu.SetVisible(false);
    }

}
