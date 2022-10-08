using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_snake
{
    class VerticalLine : Figure
    {      
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            points = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point poin = new Point(x, y, sym);
                points.Add(poin);
                
            }
        }
       
    }
}
