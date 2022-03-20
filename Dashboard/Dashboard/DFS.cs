using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class DFS
    {
        public static List<string> DFSsearching(bool type, string root, string filename)
        {
            if (type == true)
            { 
                // find all occurences
                List<string> result = new List<string>();
                string[] entryFiles = Directory.GetFiles(root);
                foreach (string entryFile in entryFiles)
                {
                    result.Add(entryFile);
                    if (entryFile.Contains(filename))
                    {
                        Console.WriteLine("Found {0} in {1}!", filename, entryFile);
                    }
                }

                // cari ke sub directory dalemnya
                string[] subEntryDirectories = Directory.GetDirectories(root);
                List<string> subResult = new List<string>();
                foreach (string subEntryDirectory in subEntryDirectories)
                {
                    result.Add(subEntryDirectory);
                    subResult = DFSsearch(type, subEntryDirectory, filename);
                    result.AddRange(subResult);
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

            // SAMPLE SKEMA DFS <node-asal , node-tujuan, tipe (0 = netral, 1= ketemu, -1 = gketemu)>
            nodes.Add(new List<int> { 1, 2, 1 });
            nodes.Add(new List<int> { 2, 4, 1 });
            nodes.Add(new List<int> { 4, 5, 1 });
            nodes.Add(new List<int> { 2, 8, -1 });
            nodes.Add(new List<int> { 8, 9, -1 });
            nodes.Add(new List<int> { 9, 10, -1 });
            nodes.Add(new List<int> { 1, 3, 0 });
            nodes.Add(new List<int> { 3, 6, 0 });
            nodes.Add(new List<int> { 1, 7, 0 });

            return nodes;
        }
    }
}
