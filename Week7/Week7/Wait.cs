using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Wait
    {
        private Queue<string> queue;
        private Names names;

        public Wait(Names names)
        {
            queue = new Queue<string>();
            this.names = names;
        }

        public void AddName(string name)
        {
            queue.Enqueue(name);
            names.RemoveName(name);
        }

        public string Remove()
        {
            if (queue.Count > 0)
            {
                string removedName = queue.Dequeue();
                names.AddToDone(removedName);
                return removedName;
            }
            else
            {
                return null; // Or throw an exception, depending on your requirements
            }
        }
        public void Status()
        {
            Console.WriteLine("Number of names waiting: "+queue.Count);
            Console.WriteLine("Names waiting:");
            foreach (var name in queue)
            {
                Console.WriteLine(name);
            }
        }
    }
}
