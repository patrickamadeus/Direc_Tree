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
        public Microsoft.Msagl.GraphViewerGdi.GViewer ShowGraph(Dictionary<string,int> nodes)
        {
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            bool form = false;
            string prevNode = "";
            foreach(KeyValuePair<string,int> node in nodes)
            {
                if (!form)
                {
                    form = true;
                }
                else
                {
                    form = false;
                    if(node.Value == -1)
                    {
                        graph.AddEdge(prevNode , node.Key).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }else if(node.Value == 0)
                    {
                        graph.AddEdge(prevNode , node.Key);
                    }
                    else
                    {
                        graph.AddEdge(prevNode,node.Key).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    }
                }
                prevNode = node.Key;
            }

        
            //bind the graph to the viewer
            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewer.OutsideAreaBrush = Brushes.White;
            return viewer;
        }
    }
}
