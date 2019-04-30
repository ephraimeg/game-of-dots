using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public class DotsController
    {
        IClusteringView _view;
        IList _dots;

        public DotsController(IClusteringView view, IList dots)
        {
            _view = view;
            _dots = dots;
        }

        private bool dotCollides(Dot dot)
        {
            bool flag = false;
            foreach(Dot other_dot in _dots)
            {
                if (flag = (other_dot.X < dot.X + dot.radius &&
                            other_dot.X + other_dot.radius > dot.X &&
                            other_dot.Y < dot.Y + dot.radius &&
                            other_dot.Y + other_dot.radius > dot.Y))
                    break;
            }
            return flag;
        }

        private void updateDotList(Dot dot)
        {
            this._dots.Add(dot);
        }

        public IList Dots
        {
            get { return ArrayList.ReadOnly(_dots); }
        }
        
        public void SpawnDot(int x, int y)
        {
            Dot me = new Dot(x, y);
            if (!dotCollides(me))
            {
                updateDotList(me);
            }
        }
    }
}
