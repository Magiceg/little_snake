// Create a 3 points the symbols and enter the screen 
int x1 = 5;
int y1 = 5;
char sym1 = '$';
Draw(x1, y1, sym1);

int x2 = 10;
int y2 = 5;
char sym2 = '*';
Draw(x2, y2, sym2);

int x3 = 15;
int y3 = 5;
char sym3 = '@';
Draw(x3, y3, sym3);

// Creating a method that will output characters 
static void Draw(int x, int y, char sym)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(sym);
}
