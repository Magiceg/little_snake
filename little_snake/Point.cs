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
        public Point (int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }



        //hiding the method inside the class
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
