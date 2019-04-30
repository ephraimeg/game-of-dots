using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering
{
    public interface IClusteringView
    {
        void SetController(ClusteringController controller);
        void ClearMap();
        void AddDot(Dot dot);
        void RemoveDot(Dot dot);
                
    }
}
