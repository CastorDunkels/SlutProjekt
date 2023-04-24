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
        for (int i = 0; i < colors.Count(); i++)
        {
            buttons.Add(new Button(x, y + 40 * i, colors[i]));
        } 
    }
    public void Update()
    {
        if(menuShown)
        {
            int counter = 0;

            for (int i = 0; i < buttons.Count(); i++)
            {
            buttons[i].Update();
            }
            for (int i = 0; i < buttons.Count(); i ++)
            {
                if(buttons[i].IsClicked())
                {
                    counter++;
                    owner.MenuClicked(i);
                }
            }
            if(counter == 0)
            {
                //SetVisible(false);
            }
        }
    }
    public bool IsVisible()
    {
        return menuShown;
    }

    public void Draw()
    {
        if (menuShown)
        {
            for (int i = 0; i < buttons.Count(); i++)
            {
                buttons[i].Draw();
            }        
        }
    }

    public void SetVisible(bool visible)
    {
        menuShown = visible;
    }
    
}
