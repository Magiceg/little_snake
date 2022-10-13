using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_snake
{
    internal class FoodCreator
    {
        int mapWidht;        //variables that the class object stores
        int mapHeight;
        char sym;

        Random random = new Random();
        public FoodCreator(int mapWidht, int mapHeight, char sym)   //variables as arguments 
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        public Point CreatorFood()              
        {
            int x = random.Next(2, mapWidht - 2);   //generating arbitary coordinates within the map 
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);    //new Point with whis coordinats 
        }
    }
}
