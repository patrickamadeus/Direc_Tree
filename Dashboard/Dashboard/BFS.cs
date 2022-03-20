using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dashboard
{
    public class BFS
    {
        public static List<string> BFSsearch(bool type, string root, string filename)
        {
            if (type == True)
            {
                // find all occurences
                Queue<string> queue = new Queue<string>();
                List<string> result = new List<string>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    string current = queue.Dequeue();
                    string[] entryFiles = Directory.GetFiles(current);
                    foreach (string entryFile in entryFiles)
                    {
                        result.Add(entryFile);
                        if (entryFile.Contains(filename))
                        {
                            Console.WriteLine("Found {0} in {1}!", filename, entryFile);
                        }
                    }

                    string[] subEntryDirectories = Directory.GetDirectories(current);
                    foreach (string subEntryDirectory in subEntryDirectories)
                    {
                        result.Add(subEntryDirectory);
                        queue.Enqueue(subEntryDirectory);
                    }
                }
                return result;
            }
            else
            {
                // TODO FIND THE FIRST OCCURENCE
                return new List<string>();
            }
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
