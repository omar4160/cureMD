using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCureMD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char space = ' '; int count = 1;
            Console.WriteLine("Enter a sentence:");
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == space)
                {
                    count++;
                }
            }


            string[] words = new string[count];
            string[] words2 = new string[count];
            int[] freq = new int[count];
            int k = 0;
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] != space)
                {
                    words[k] += line[j];
                }
                else
                {
                    k++;
                }
            }
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    if (words[l] == words[m])
                    {
                        freq[l]++;
                    }
                        

                }
                Console.WriteLine("frequency of " + words[l]);
                Console.WriteLine(freq[l]);

            }

            Console.WriteLine("Enter a number N");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] sentences = new string[N];
            Random rdn = new Random();
            for(int j=0; j< N; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    sentences[j] += words[rdn.Next(count)]+" ";
                }
                Console.WriteLine(sentences[j]);
            }

            string longest = "";
            string shortest = words[0];
            for(int i=0; i< count; i++)
            {
                if (words[i].Length > longest.Length)
                { 
                    longest = words[i];
                }
                if (words[i].Length < shortest.Length)
                {
                    shortest = words[i];
                }

            }
            Console.WriteLine("Shortest word is " + shortest);
            Console.WriteLine("Longest word is "+ longest);


            Console.WriteLine("entr the word you want to search:");
            string wordsearch = Console.ReadLine();
            int flag = 0;
            for(int i=0; i< count; i++)
            {
                if (wordsearch == words[i])
                {
                    Console.WriteLine("The word "+wordsearch+ " is present");
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("The word is not present");
            }
            string palindromes = "";
            String test = "";
            int c = 0;
            int flagP = 0;
            for(int i= 0; i< count; i++) 
            {
                test = words[i];
                c=test.Length-1;
             
                
                for(int j= 0; j< test.Length; j++)
                {
                    if (test[j] != test[c])
                    {
                        flagP = 1;
                        break;
                    }
                    c--;
                }
                if(flagP == 0)
                {
                    palindromes += test+", ";
                }

                flagP= 0;  
            }
            if(palindromes == "")
            {
                Console.WriteLine("there are no palindromes");
            }
            else
            {
                Console.WriteLine("palindromes");
            }





        }




    }
}
