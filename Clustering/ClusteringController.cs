using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public class ClusteringController
    {
        IClusteringView _view;
        IList _dots;
        Random rnd;

        public ClusteringController(IClusteringView view, IList dots)
        {
            _view = view;
            _view.SetController(this);

            _dots = dots;

            rnd = new Random();
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
        
        public Dot SpawnDot(int x, int y)
        {
            int _x = rnd.Next((x - 20));
            int _y = rnd.Next((y - 20));
            Dot me = new Dot(_x, _y);
            if (!dotCollides(me))
            {
                updateDotList(me);
                return me;
            }
            return null;
        }

        public void SpawnDots(int x, int y, int count)
        {
            int createdDots = 0;
            int _x;
            int _y;
            int fail_count = 0;

            while(createdDots < count && fail_count < 10)
            {
                _x = rnd.Next((x - 20));
                _y = rnd.Next((y - 20));
                Dot me = new Dot(_x, _y);
                if (!dotCollides(me))
                {
                    updateDotList(me);
                    fail_count = 0;
                    createdDots++;
                }
                else
                {
                    fail_count++;
                }
            }
        }
        
        public void RemoveDot(Dot dot)
        {
        }

        public void ClearDots()
        {
            _dots.Clear();
        }
    }
}
