using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;

        //using the encapsulation principle 
        //hiding all the details of the implementation of the point class from the user 
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)       //adding the constructor and creating points using other points  
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int shift, Direction direction)            //method for the shifting point 
        {
            if (direction == Direction.Right)
            {
                x = x + shift;
            }
            else if (direction == Direction.Left)
            {
                x = x  - shift;
            }
            else if (direction == Direction.Up)
            {
                y = y - shift;
            }
            else if (direction == Direction.Down)
            {
                y = y + shift;
            }
        }

        public bool IsHit(Point p)  //intersection of the coordinats of the current
        {                             //point with the point for food
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()  // deleting the previous point
        {
            sym = ' ';
            Draw();
        }

        //hiding the method inside the class
        public void Draw()
        {
            
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}   

