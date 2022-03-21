using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dashboard
{
    public class DFS
    {
        public static Dictionary<string, int> DFSsearching(bool type, string root, string filename)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] entryFiles = Directory.GetFiles(root);
            bool found = false;
            foreach (string entryFile in entryFiles)
            {
                if (entryFile.Contains(filename))
                {
                    result.Add(entryFile, 1);
                    found = true;
                } 
                // check if first occurences
                if (!type) { if (found) { return result; } }
            }


            // cari ke sub directory dalemnya
            string[] subEntryDirectories = Directory.GetDirectories(root);
            Dictionary<string, int> subResult = new Dictionary<string, int>();
            foreach (string subEntryDirectory in subEntryDirectories)
            {
                result.Add(subEntryDirectory, 0);
                subResult = DFSsearching(type, subEntryDirectory, filename);

                foreach (KeyValuePair<string, int> i in subResult)
                {
                    result.Add(i.Key, i.Value);
                }

                foreach(KeyValuePair<string,int> i in result.ToList()) 
                {
                    if (result[i.Key] == 1) {
                        MakeColorParent(i.Key, ref result, true);
                    }
                }
             
                // check if first occurences
                if (!type)
                {
                    foreach (KeyValuePair<string, int> i in subResult)
                    {
                        if (result[i.Key] == 1)
                        {
                            return result;
                        }
                    }
                }
            }
            return result;
        }

        public static void MakeColorParent(string foundPath, ref Dictionary<string, int> map, bool green)
        {
            List<string> pathParsed = foundPath.Split('\\').ToList();
            if (pathParsed.Count != 1)
            {
                pathParsed.RemoveAt(pathParsed.Count - 1);

                string keyParent = String.Join("/", pathParsed.ToArray());
                if (map.ContainsKey(keyParent))
                {
                    if(green){
                        map[keyParent] = 1;
                    }else{
                        if (map[keyParent] != 1){
                            map[keyParent] = -1;
                        }
                    }
                }
                MakeColorParent(keyParent,ref map, green);
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
