using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace little_snake
{
    class Figure
    {
        protected internal List<Point> points;
        public void Drow()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
