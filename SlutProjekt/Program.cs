global using Raylib_cs;
// Turn-based spel, swords and sandals/sonny likt 
// Alla gubbar har en "health", "attack", "damage" och "speed" variabel
// Om "attack" variabeln av en gubbe som utför en attack är större än "speed" variabeln av gubben som blir attackerad  vilket sänker "health" med "damage"
// Om "speed" variabeln var högre så kommer attacken att missa 
// Alla dessa variablar förutom "health" kommer att bli slumpade beroende på vilken attack de utför

int screenWidth = 1000;
int screenHeight = 1000;

Player p1 = new();
Enemy e1 = new();

Raylib.InitWindow(screenWidth, screenHeight, "Game");
Raylib.SetTargetFPS(30);




while (!Raylib.WindowShouldClose())
{
    p1.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    p1.Draw();
    e1.Draw();

    Raylib.EndDrawing();
}