using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clustering
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ClusteringView view = new ClusteringView();
            IList dots = new ArrayList();
            ClusteringController controller = new ClusteringController(view, dots);
            
            Application.Run(view);
        }
    }
}
