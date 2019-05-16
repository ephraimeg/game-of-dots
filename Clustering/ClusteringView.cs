using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clustering
{
    public partial class ClusteringView : Form, IClusteringView
    {
        ClusteringController _controller;

        // TODO: Enumerated type for brushes ??
        SolidBrush _defaultBrush;

        public ClusteringView()
        {
            InitializeComponent();
            _defaultBrush = new SolidBrush(Color.LimeGreen);
        }

        public void AddDot(Dot dot)
        {
            Graphics g = this.pnlMap.CreateGraphics();
            g.FillEllipse(_defaultBrush, dot.X, dot.Y, dot.radius, dot.radius);
            g.Dispose();
        }

        public void ClearMap()
        {
            Graphics g = this.pnlMap.CreateGraphics();
            g.Clear(SystemColors.ActiveCaptionText);
            g.Dispose();
        }

        public void RemoveDot(Dot dot)
        {
            throw new NotImplementedException();
        }

        public void SetController(ClusteringController controller)
        {
            _controller = controller;
        }

        private void btnSpawn_Click(object sender, EventArgs e)
        {
            int count = 5;
                
            if (!Int32.TryParse(tbxDots.Text, out count))
            {
                MessageBox.Show("Please input a valid number");
                return;
            }

            _controller.SpawnDots(this.pnlMap.Width, this.pnlMap.Height, count);
            
            foreach(Dot d in _controller.Dots)
            {
                AddDot(d);
            }
        }
    }
}
