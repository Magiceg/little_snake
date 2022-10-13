using little_snake;
//box
//drawing the frame 
HorizontalLine upLine = new HorizontalLine(0, 98, 0, '#');
HorizontalLine downLine = new HorizontalLine(0, 98, 29, '#');
VerticalLine leftLine = new VerticalLine(0, 29, 0, '#');
VerticalLine rightLine = new VerticalLine(0, 29, 98, '#');
upLine.Drow();
downLine.Drow();
leftLine.Drow();
rightLine.Drow();



//HorizontalLine line1 = new HorizontalLine(15, 30, 1, '$');
//line1.Drow();
//Point p = new Point(4, 5, '&');
//.Draw();
//VerticalLine line2 = new VerticalLine(6, 14, 20, '+');
//line2.Drow();

//remove cursor
Console.CursorVisible = false; //remove cursor

//drawing the point 
Point p = new Point(7, 10, '*');
Snake snake = new Snake(p, 7, Direction.Right);
snake.Drow();

FoodCreator foodCreator = new FoodCreator(100, 30, '*'); // passing the data necessary for work the method 
Point food = foodCreator.CreatorFood(); //creating a point within coordinates 
food.Draw();



while (true)
{
    if (snake.Eat(food)) //true or false 
    {
        food = foodCreator.CreatorFood();
        food.Draw();
    }
    else
    {
        snake.Move();
    }
    Thread.Sleep(40);
    //to control the snake, creating infinity loop
    if (Console.KeyAvailable) //checking for keystrokesfrom the cycle
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        snake.Control(key.Key);
    }
    
}






