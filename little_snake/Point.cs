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

        //hiding the method inside the class
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
