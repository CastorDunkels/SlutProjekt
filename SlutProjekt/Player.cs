public class Player : Character
{

    private Menu menu;

    public Player()
    {
        names = new List<string>() { "Bengt", "Björn", "Chris P Rat", "Pelle", "Sten", "Shrek" };
        rect = new Rectangle(200, 400, 50, 100);
        color = Color.GREEN;
        index = rnd.Next(names.Count);
        name = names[index]; //ändrar name till ett slumpvist valt värde på names
        menu = new Menu((int)rect.x + 100, (int)rect.y, new List<Color>() {Color.BLUE}, this); //skapar menyn för spelaren
    }
    public override void Update() //metod som körs varje frame och har fått ny information i denna klass
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

    public override void Draw() //ändrar metodens information om vad som ska ritas ut
    {
        base.Draw();
        menu.Draw();
    }

    public override void MenuClicked(int x) //metod som kollar om menyn har blivit klickad eller inte
    {
        menu.SetVisible(false);
    }

}
