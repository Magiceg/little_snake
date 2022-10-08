using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_snake      //
{       
     class Snake : Figure 
    {
        // the starting point for the snake
        public Snake(Point tail, int lenght, Direction direction )
        {
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
    }
}
