public class Enemy : Character
{

    private Menu menu;

    public Enemy()
    {
        names = new List<string>(){"Babu","Frikk","Gargamell","Limpa","Åsna","Donkey","Sven"};
        rect = new Rectangle(800, 400, 50, 100);
        color = Color.RED;
        index = rnd.Next(names.Count);
        name = names[index];
        menu = new Menu((int)rect.x - 50, (int)rect.y, new List<Color>() {Color.BLACK, Color.RED, Color.ORANGE}, this);
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
