using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
   namespace OOPfun
{
    internal class WordTools
    {
        public int WordCounter (string words)
        {
            int wordCount = 0;
            
            //split the string into separate words ti amke it easier to count
            string[] individualWords = words.Split(" ");
            
            wordCount = individualWords.Length;

            return (wordCount);
        }

        public int CharacterCounter(string words)
        {
            int CharacterCount = 0;

            CharacterCount = words.Length;

            return (CharacterCount);
        }

        public int[] AplphabetCounter(string words)
        {
            int[] letters = new int[26];
            //Loop through the entire string
            for (int i = 0; i < words.Length; i++)
            { 
                char c = words[i];

                c = char.ToLower(c);
               
                Console.WriteLine(c);
                //Check to make sure it is a lowercase letter
                if (c >= 97 && c <= 122)
                {
                    letters[(c-97)]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                char letter = (char)(i + 97);
                Console.Write(letter + ":"+ letters[i]);

                if (i < letters.Length - 1)
                {
                    Console.Write(", ");
                }
                
            }

            return letters;
        }
        
    }
}