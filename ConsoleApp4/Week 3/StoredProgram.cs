using CMP1903MWorkshopCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a message object
            Message message = new Message();
            //Call the message to get the text from the console
            message.readMessageFromInput();


            // Create AtBash object
            Atbash atbash = new Atbash();

            // perform Error Handelling
            string inputMessage = message.message;
            if (string.IsNullOrEmpty(inputMessage))
            {
                Console.WriteLine("Error: The input is null or empty. ");
            }
            else 
            { 
                // Pass the message to the encode method of AtBash
                string text = atbash.encode(message.message);
                Console.WriteLine($"The message is encoded to be the following: {text}");

                string originalText = atbash.encode(text);
                Console.WriteLine($"The message is decoded to be the following: {originalText}");
            }



            // 
            Message message1 = new Message();
            string fileName = "MyFile.txt";
            message1.readMessageFromFile(fileName);

            Console.ReadKey();


            //Week 3
            //Challenge: Get the message from the encrypted text
            //
            //1. EITHER:    Read in the .txt file into a List of Strings (or anything else?)
            //   OR:        Read in each line one at a timen and get its maximum character 
            //2. For each string:
            //      Count each character in the string
            //      The maximum is the character
            //3. Output the unencrypted message.

            //Week 3
            //Task 1: create Message object, call the readTextFromInput() method
            //Task 2: create Atbash object Step 1: pass message to encode() method Step 2: put in the encode logic
            //Task 3: put in the decode logic to the decode() method, check if it works
            //Task 4: read text to encode from a file



        }
    }
}
