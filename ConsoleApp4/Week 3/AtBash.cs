using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Atbash
    {
        public string encode(string text)
        {
            // Initialise a new string to store the encoded text
            string encodedString = "";
            // for each letter in the string store the current last unstored character in the next point in the list
            for (int x = text.Length - 1; x > -1; x--)
            {
                //create the new string
                encodedString += text[x];
            }
            return encodedString;
        }

        public string decode(string text)
        {
            string decodedString = "";
            // for each letter in the string store the current last unstored character in the next point in the list
            for (int x = text.Length - 1; x > -1; x--)
            {
                //create the new string
                decodedString += text[x];
            }
            return decodedString;
        }
    }
}