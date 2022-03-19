using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Graph
    {
        public Microsoft.Msagl.GraphViewerGdi.GViewer ShowGraph(List<List<int>> nodes)
        {
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            for (int i = nodes.Count - 1; i >=0; i--)
            {   
                if (nodes[i][2] == 0)
                {
                    graph.AddEdge(nodes[i][0].ToString(), nodes[i][1].ToString());
                }
                else if(nodes[i][2] == 1)
                {
                    graph.AddEdge(nodes[i][0].ToString(), nodes[i][1].ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                }
                else
                {
                    graph.AddEdge(nodes[i][0].ToString(), nodes[i][1].ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
            }
        
            //bind the graph to the viewer
            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewer.OutsideAreaBrush = Brushes.White;
            return viewer;
        }
    }
}
