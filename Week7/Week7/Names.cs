using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6
{
    public class Names
    {
        //class Names to hold your list of names and various methods
        private List<string> names;
        private List<string> done;

        public Names(string filename)
        {
            names = new List<string>();
            done = new List<string>();
            LoadFromFile(filename);
        }
        public int Count()
        {
            return names.Count;
        }

        public string GetNameAtIndex(int index)
        {
            if (index >= 0 && index < names.Count)
            {
                return names[index];
            }
            else
            {
                return null; // Or throw an exception, depending on your requirements
            }
        }

        private void LoadFromFile(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    AddName(line.Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading names from file: " + ex.Message);
            }
            
        }

        public void AddName(string name)
        {
            if (!names.Contains(name))
            {
                int index = names.BinarySearch(name);
                if (index<0)
                    index = ~index;
                names.Insert(index, name);
            }
        }

        public void OutputNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        public bool RemoveName(string name)
        {
            if (names.Contains(name))
            {
                names.Remove(name);
                return true;
            }
            return false;
        }
        public void AddToDone(string name) 
        {
            done.Add(name);
        }
    }
}
