using CMP1903M_Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 4
            //Challenge:  Determine what the value of the accumulator will be when the code is finished running
            //
            //Read each line of the input.
            //Determine whether it is a 'acc' or 'jmp' command for each line
            //Determine the value on each line
            //Find the value of 'acc' at the end
            //HINT: We can read each line as an array (or List) of strings; check [0] for 'a' or 'j', then check [4] and [5] for the values
            //OR: we could split each string at the space into an operation string and a value string
            //Can we read line by line instead of storing in a collection?


            //Week 4
            //Task 1: Add a page to the 'history'
            //Task 2: Add exceptions
            //Task 3: Use custom exceptions

            //example of creating a page with a title and URL
            //Test... remove this when you have seen it working
            Page p = new Page("Test Page", "http://www.lincoln.ac.uk");
            Console.WriteLine(p.Address);
            //.......

            //creating a new, empty history
            History h1 = new History();


        }
    }
}
