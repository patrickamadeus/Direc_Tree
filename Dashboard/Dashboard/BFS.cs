using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class BFS
    {
        public void BFSsearching(bool type) // type is find all occurence or not
        {
            // Algo placeholder, can change return type
        }

        public List<List<int>> GetNodes()
        {
            List<List<int>> nodes = new List<List<int>>() { };

            // SAMPLE SKEMA BFS <node-asal , node-tujuan, tipe (0 = netral, 1= ketemu, -1 = gketemu)>
            nodes.Add(new List<int> { 1, 2, 1 });
            nodes.Add(new List<int> { 1, 3, 0 });
            nodes.Add(new List<int> { 1, 7, 0 });
            nodes.Add(new List<int> { 2, 4, 1 });
            nodes.Add(new List<int> { 2, 8, -1 });
            nodes.Add(new List<int> { 3, 6, 0 });
            nodes.Add(new List<int> { 4, 5, 1 });
            nodes.Add(new List<int> { 8, 9, -1 });
            nodes.Add(new List<int> { 9, 10, -1 });

            return nodes;
        }
    }
}
