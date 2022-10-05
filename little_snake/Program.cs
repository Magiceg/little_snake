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
Point p = new Point(4, 5, '&');
p.Draw();


VerticalLine line2 = new VerticalLine(6, 14, 20, '+');
line2.Drow();


Console.ReadLine();




