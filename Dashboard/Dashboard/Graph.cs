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
        public Microsoft.Msagl.GraphViewerGdi.GViewer ShowGraph(Dictionary<string,int> nodes, bool type)
        {
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            foreach(KeyValuePair<string,int> node in nodes.Reverse())
            {
                List<string> pathParsed = node.Key.Split('\\').ToList();
                pathParsed.RemoveAt(pathParsed.Count - 1);

                string keyParent = String.Join("\\", pathParsed.ToArray());

                if(node.Value == 1)
                {
                    graph.AddEdge(keyParent, node.Key).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                }
                else if (node.Value == 0)
                {
                    if (!type)
                    {
                        graph.AddEdge(keyParent,node.Key).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                    else
                    {
                        graph.AddEdge(keyParent, node.Key);
                    }
                }
                else
                {
                    graph.AddEdge(keyParent, node.Key).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                List<string> splitter = keyParent.Split('\\').ToList();
                List<string> splitter2 = node.Key.Split('\\').ToList();
                graph.FindNode(keyParent).Label.Text = splitter[splitter.Count - 1];
                graph.FindNode(node.Key).Label.Text = splitter2[splitter2.Count - 1];
                graph.FindNode(keyParent).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                graph.FindNode(node.Key).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                graph.FindNode(keyParent).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Wheat;
                graph.FindNode(node.Key).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Wheat;



            }


            //bind the graph to the viewer
            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewer.OutsideAreaBrush = Brushes.White;
            return viewer;
        }
    }
}
