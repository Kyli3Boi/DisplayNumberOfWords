using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DisplayNumberOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will display the number of words in a .txt file");
            
            Console.WriteLine("Please enter the full path of the .txt file");
            var path = Console.ReadLine();
            
            var numberOfWords = 0;

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);

                if (!string.IsNullOrEmpty(content))
                {
                    string[] words = content.Split(' ');


                    foreach (var word in words)
                    {
                        numberOfWords++;
                    }

                    Console.WriteLine("There are " + numberOfWords + " words in your .txt document");
                }
                else
                {
                    Console.WriteLine("File is empty");
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.ReadKey();
        }

    }
}
