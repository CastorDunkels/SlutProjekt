using System.Numerics;
public class Button
{
    private int x;
    private int y;
    private Color color;
    private float radius = 15;



    public Button(int x, int y, Color color)
    {

        this.x = x;
        this.y = y;
        this.color = color;
    }

    public void Update()
    {
    }
    public void Draw()
    {
            Raylib.DrawCircle(x, y, radius, color);
        
    }
    public bool IsClicked()
    {
        if (Raylib.CheckCollisionPointCircle(Raylib.GetMousePosition(), new Vector2(x, y), radius) && Raylib.IsMouseButtonPressed(0))
        {
            
            return true;
        }
        else{
            return false;
        }
    }

}
