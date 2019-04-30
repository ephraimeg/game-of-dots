using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public class Dot
    {
        static int count = 1;
        public int id { get; }
        public int x { get; set; }
        public int y { get; set; }

        public Dot(int x, int y)
        {
            this.id = count++;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return ($"P({this.x}, {this.y})");
        }
    }
}
