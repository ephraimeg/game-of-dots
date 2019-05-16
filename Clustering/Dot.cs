using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public class Dot
    {
        static int _dotId = 1;
        public int id { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int radius { get; set; }

        public Dot(int x, int y)
        {
            this.id = _dotId++;
            this.X = x;
            this.Y = y;
            this.radius = 20;
        }

        public override string ToString()
        {
            return ($"P({this.X}, {this.Y})");
        }
    }
}
