global using Raylib_cs;
// Turn-based spel, swords and sandals/sonny likt 
// Alla gubbar har en "health" variabel och om den blir 0 så dör den gubben
// Alla gubbar har en "attack", "damage" och "speed" variabel
// Om "attack" variabeln av en gubbe som utför en attack är större än "speed" variabeln av gubben som blir attackerad så går den igenom 
// Om "speed" variabeln var högre så kommer attacken att missa vilket gör att gubben 
// Om attacken går igenom så förlorar den attackerade gubben lika mycket av sin "health" variabel som fiendens "damage" variabel
// Alla dessa variablar förutom "health" kommer att bli slumpade mellan rundor 
// Det kommer bli slumpade mellan olika stora tal beroende på val av drag

int screenWidth = Raylib.GetScreenWidth();
int screenHeight = Raylib.GetScreenHeight();

Character character = new();

Raylib.InitWindow(screenWidth, screenHeight, "Game");
Raylib.SetTargetFPS(30);




while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GRAY);
    character.gudhs();


    Raylib.EndDrawing();
}