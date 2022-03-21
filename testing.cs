using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> res = DFSsearching(true, "./testing", "z.txt");
            visualizeMap(res);
            Console.WriteLine();
            Console.WriteLine();
            Dictionary<string, int> resItem = BFSsearching(true, "./testing", "b.txt");
            visualizeMap(resItem);
            Console.WriteLine();
            Console.WriteLine();
            Dictionary<string, int> resIjo = BFSsearching(true, "./testing", "b.txt");
            visualizeMap(resIjo);
            Console.WriteLine();

        }

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

        public static Dictionary<string, int> BFSsearching(bool type, string root, string filename)
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
                    if (entryFile.Contains(filename))
                    {
                        result.Add(entryFile, 1);
                        found = true;
                        MakeColorParent(entryFile, ref result, true);
                    } 
                    else 
                    {
                        result.Add(entryFile, -1);
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

        public static void visualizeList(List<string> list)
        {
            Console.Write("[");
            foreach (string i in list)
            {
                Console.Write("'" + i + "'" + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static void visualizeMap(Dictionary<string, int> map)
        {
            foreach (KeyValuePair<string, int> i in map)
            {
                Console.Write(i.Key + ": " + i.Value + " ");
            }
        }

        public static void MakeColorParent(string foundPath, ref Dictionary<string, int> map, bool green)
        {
            List<string> pathParsed = foundPath.Split("/").ToList();
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

        // TODO : PARSING BFS KALO AKHIRNYA .TXT DIILANGIN
    }
}
