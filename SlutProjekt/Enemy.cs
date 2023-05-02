public class Enemy : Character
{

    private Menu menu;

    public Enemy()
    {
        names = new List<string>(){"Babu","Frikk","Gargamell","Limpa","Åsna","Donkey","Sven"};
        rect = new Rectangle(800, 400, 50, 100);
        color = Color.RED;
        index = rnd.Next(names.Count); 
        name = names[index]; //ändrar name till ett slumpvist värde för names 
        menu = new Menu((int)rect.x - 50, (int)rect.y, new List<Color>() {Color.BLACK, Color.RED, Color.ORANGE}, this); //skapar menyn för enemy
    }
    public override void Update() //en metod som körs varje frame och har blivit överskriven med ny information om vad den ska göra 
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

    public override void Draw() //metod med ny information om vad som ska ritas ut
    {
        base.Draw();
        menu.Draw();
    }

    public override void MenuClicked(int x) //metod med ny information som kollar om menyn har blivit klickad
    {
        menu.SetVisible(false);
    }

}
