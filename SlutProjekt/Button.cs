using System.Numerics;
public class Button
{
    private int x;
    private int y;
    private Color color;
    private Menu owner;
    private float radius = 15;



    public Button(int x, int y, Color color, Menu owner)
    {

        this.x = x;
        this.y = y;
        this.color = color;
        this.owner = owner;
    }

    public void Update()
    {
        if (Raylib.CheckCollisionPointCircle(Raylib.GetMousePosition(), new Vector2(x, y), radius) && Raylib.IsMouseButtonPressed(0))
        {
            owner.ButtonClicked(this);
        }
    }
    public void Draw()
    {
            Raylib.DrawCircle(x, y, radius, color);
        
    }

}
