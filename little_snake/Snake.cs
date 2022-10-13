using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace little_snake      
{       
     class Snake : Figure 
     {  
        // the starting point for the snake
        public Direction direction;
        public Snake(Point tail, int lenght, Direction direction )
        {
            this.direction = direction;
            points = new List<Point>();
            for (int i = 0; i < lenght; i++) 
            {
                //creating points that are an exact copy of the tail point  
                Point p = new Point(tail);
                //the shift of the point in the direction 
                p.Move(i, direction);
                //add in the list 
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First(); // return the first item in the list
            points.Remove (tail);   // removing point that used to be a tail
            Point head = GetNextPoint();  //called method for the shift snake head 
            points.Add (head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint()
        {
            Point head = points.Last();     // current head position before moving 
            Point nextPoint = new Point(head);  //creating a copy of the previous head point
            nextPoint.Move(1, direction);   // shift a point by direction 
            return nextPoint;   //getting the new point 
        }

        public void Control (ConsoleKey key) //the body of the loop control
        {
            Direction last = direction;


            if (key == ConsoleKey.LeftArrow && last != Direction.Left)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow && last != Direction.Right)
                direction = Direction.Right;
            else if (key == ConsoleKey.UpArrow && last != Direction.Up)
                direction = Direction.Up;
            else if (key == ConsoleKey.DownArrow && last != Direction.Down)
                direction = Direction.Down;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();    //finding the snake in the next moment 
            if (head.IsHit(food))   //if the point matches, a loop is started
            {
                food.sym = head.sym;    //food = head and add in the body snake 
                points.Add(head);
                return true;
            }
            else
            {
                return false;
            }
                

        }
    }
}
