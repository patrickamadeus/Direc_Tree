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
        public static Dictionary<string, int> BFSsearching(bool type, string root, string filename, ref List<string> foundPath)
        {
            // BFS
            Queue<string> queue = new Queue<string>();
            Dictionary<string, int> result = new Dictionary<string, int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                string[] entryFiles = Directory.GetFiles(current);
                bool found = false;
                foreach (string entryFile in entryFiles)
                {
                    List<string> splitter = entryFile.Split('\\').ToList();
                    if (splitter[splitter.Count - 1].Equals(filename))
                    {
                        result.Add(entryFile, 1);
                        found = true;
                        foundPath.Add(entryFile);
                        MakeColorParent(entryFile, ref result, true);
                    } 
                    else 
                    {
                        //result.Add(entryFile, -1);
                        MakeColorParent(entryFile, ref result, false);
                    }
                    // check if first occurences
                    if (!type) { if (found) { return result; } }
                }

                string[] subEntryDirectories = Directory.GetDirectories(current);
                foreach (string subEntryDirectory in subEntryDirectories)
                {
                    result.Add(subEntryDirectory, 0);
                    queue.Enqueue(subEntryDirectory);
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

                string keyParent = String.Join("\\", pathParsed.ToArray());
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
    }
}
