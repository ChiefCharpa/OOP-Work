using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6;

namespace Week7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Week 6
            //Task 1: Using a List object
            //List called 'names' to hold a list of names
            List<string> names = new List<string>();

            // Adding names to the list using the Add method
            names.Add("Olivia");
            names.Add("Oliver");
            names.Add("Amelia");
            names.Add("George");
            names.Add("Isla");
            names.Add("Harry");
            names.Add("Ava");
            names.Add("Noah");
            names.Add("Emily");
            names.Add("Jack");

            // Gathering information about the list
            Console.WriteLine("Number of names in the list: " + names.Count);

            // Checking whether the list contains 'Noah' and 'David'
            Console.WriteLine("Does the list contain 'Noah'? " + names.Contains("Noah"));
            Console.WriteLine("Does the list contain 'David'? " + names.Contains("David"));

            // Checking whether the list contains 'Amelia' and 'Christos' using SimpleSearch method
            Console.WriteLine("Does the list contain 'Amelia'? " + SimpleSearch(names, "Amelia"));
            Console.WriteLine("Does the list contain 'Christos'? " + SimpleSearch(names, "Christos"));

            //Task 2: Use a class to hold your List

             Names nameList1 = new Names("NamesList.txt");

             // Outputting the contents of the list
             Console.WriteLine("All names in the list:");
             nameList1.OutputNames();

             // Adding a name to the list
             Console.WriteLine("Adding a new name 'Zara' to the list...");
             nameList1.AddName("Zara");

             // Outputting the updated contents of the list
             Console.WriteLine("All names in the list after addition:");
             nameList1.OutputNames();

             // Removing a name from the list
             Console.WriteLine("Removing 'Oliver' from the list...");
             bool removed = nameList1.RemoveName("Oliver");
             if (removed)
             {
                 Console.WriteLine("'Oliver' has been removed from the list.");
             }
             else
             {
                 Console.WriteLine("'Oliver' was not found in the list.");
             }

             // Outputting the updated contents of the list
             Console.WriteLine("All names in the list after removal:");
             nameList1.OutputNames();

            //Task 3: Create a 'Wait' class to hold a Queue<> collection
            Names nameList2 = new Names("NamesList.txt");
            Wait waitQueue = new Wait(nameList2);

            // Choose a random name from the list
            Random random = new Random();
            int randomNumber = random.Next(0, nameList2.Count());
            string randomName = nameList2.GetNameAtIndex(randomNumber);

            // Add the random name to the queue
            waitQueue.AddName(randomName);

            // Output the number of names waiting and their names
            waitQueue.Status();

            // Output the name added to the queue
            Console.WriteLine("Random name added to the queue: " + randomName);

            // Remove a name from the queue
            string removedName = waitQueue.Remove();
            if (removedName != null)
            {
                Console.WriteLine("Removed name from the queue: " + removedName);
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }

            // Output the updated number of names waiting and their names
            waitQueue.Status();


            //Task 4: Use LINQ queries on your collection
            Console.ReadKey();
        }

        private static bool SimpleSearch(List<string> list, string name)
        {
                foreach (string item in list)
                {
                    if (item == name)
                        return true;
                }
                return false;
        }
      
    }
    
}
