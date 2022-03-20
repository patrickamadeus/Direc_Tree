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
            System.Console.WriteLine("Hello World!");
            List<string> res = DFSsearch(true, "./testing", "a.txt");
            visualizeList(res);
            List<string> res2 = BFSsearch(true, "./testing", "a.txt");
            visualizeList(res2);
        }

        public static List<string> DFSsearch(bool type, string root, string filename)
        {
            if (type == true)
            { // find all occurences
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

        public static List<string> BFSsearch(bool type, string root, string filename) 
        {
            // BFS
            if (type == True) 
            { // find all occurences
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

        public static void parser(List<string> test)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string i in test)
            {
                string[] parsed = i.Split("/");
                foreach (string j in parsed)
                {
                    if (map.ContainsKey(j))
                    {
                        map[j]++;
                    }
                    else
                    {
                        map.Add(j, 1);
                    }
                }
            }

            visualizeMap(map);
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
            Console.Write("[");
            foreach (KeyValuePair<string, int> i in map)
            {
                Console.Write(i.Key + ": " + i.Value + " , ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

    }
}