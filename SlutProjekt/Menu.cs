public class Menu
{
    private List<Button> buttons;
    private List<Color> colors;
    private Character owner;
    private bool menuShown;
    public Menu(int x, int y, List<Color> colors, Character owner)
    {
        this.colors = colors;
        this.owner = owner;
        buttons = new List<Button>();
        for (int i = 0; i < colors.Count(); i++) //en for loop som skapar lika många buttons som det finns färger
        {
            buttons.Add(new Button(x, y + 40 * i, colors[i]));
        } 
    }
    public void Update() //en metod som säger vad som ska hända om menuShown är sant
    {
        if(menuShown)
        {
            for (int i = 0; i < buttons.Count(); i++)
            {
            buttons[i].Update();
            }
            for (int i = 0; i < buttons.Count(); i ++)
            {
                if(buttons[i].IsClicked())
                {
                    owner.MenuClicked(i);
                }
            }
        }
    }
    public bool IsVisible() //en metod som säger om menuShown är sant
    {
        return menuShown;
    }

    public void Draw() //en metod som ritar ut menyn om menuShown är sant
    {
        if (menuShown)
        {
            for (int i = 0; i < buttons.Count(); i++)
            {
                buttons[i].Draw();
            }        
        }
    }

    public void SetVisible(bool visible) //en metod som sätter menuShown till sant eller falskt 
    {
        menuShown = visible;
    }
    
}
