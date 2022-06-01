using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    internal class ucMethods
    {
        public void findFrequency()
        {
            string input = "to be or not to be";
            string[] wordsArray = input.Split(' ');
            IEnumerable<string> uniqueItems = wordsArray.Distinct<string>();
            string [] words = uniqueItems.ToArray();
            int[] frequency = new int[wordsArray.Length];
            MyMapNode<int, string> hashtable = new MyMapNode<int, string>(wordsArray.Length);           
            for (int i = 0; i < wordsArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < wordsArray.Length; j++)
                {
                    if (wordsArray[j].ToLower() == wordsArray[i].ToLower())
                    {
                        count++;
                    }
                }
                frequency[i] = count;
                hashtable.Add(i, wordsArray[i]);
                
                if (i < words.Length)
                {
                    Console.WriteLine(words[i] + " occurs " + count);                    
                }
                count = 0;
            }

        }
        public void findFrequencyParagraph()
        {
            string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] wordsArray = input.Split(' ');
            IEnumerable<string> uniqueItems = wordsArray.Distinct<string>();
            string[] words = uniqueItems.ToArray();
            int[] frequency = new int[wordsArray.Length];
            MyMapNode<int, string> hashtable = new MyMapNode<int, string>(wordsArray.Length);
            for (int i = 0; i < wordsArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < wordsArray.Length; j++)
                {
                    if (wordsArray[j].ToLower() == wordsArray[i].ToLower())
                    {
                        count++;
                    }
                }
                frequency[i] = count;
                hashtable.Add(i, wordsArray[i]);

                if (i < words.Length)
                {
                    Console.WriteLine(words[i] + " occurs " + count);
                }
                count = 0;
            }

        }
    }
}
