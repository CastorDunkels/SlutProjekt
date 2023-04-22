public class Menu
{
   private List<Button> buttons;
   private List<Color> colors;
   private Character owner;

    public Menu(List<Color> colors, Character owner)
    {
        this.colors = colors;
        this.owner = owner;
        buttons = new List<Button>();
        for (int i = 0; i < colors.Count(); i++)
        {
            buttons.Add(new Button(50, 50 + 20 * i, colors[i], this));
        } 
    }
    public void Update()
    {
        for (int i = 0; i < buttons.Count(); i++)
        {
           buttons[i].Update();
        }
    }

    public void Draw()
    {
        for (int i = 0; i < buttons.Count(); i++)
        {
            buttons[i].Draw();
        }        
    }
    public void ButtonClicked(Button b)
    {
        for(int i = 0; i < buttons.Count(); i++)
        {
            if(b == buttons [i])
            {
                owner.MenuClicked(i);
                
            }
        }
    }
}
