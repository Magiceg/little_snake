using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_snake
{
    class HorizontalLine : Figure
    {
        //creating a horizontal line symbols using a list and loop,
        //than enter the data int the main program 
        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            points = new List<Point>();
            for (int x = xleft; x <= xright; x++)
            {
                Point poin = new Point(x, y, sym);
                points.Add(poin);
            }

        }

        
    }
}
