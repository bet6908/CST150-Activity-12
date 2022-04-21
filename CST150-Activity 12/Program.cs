using System;
using System.IO;
using System.Collections.Generic;
//Roberto GonzalezRamirez
//CST 150- Activity 12

namespace Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a StreamReader variable.
            StreamReader inputFile;

            // Open file and get text from file.
            inputFile = File.OpenText("TextFile.txt");

            // Creating a single string from inputFile
            string stringRead = inputFile.ReadToEnd();
            string remPunk = null;

  

            foreach (char c in stringRead)
            {
                if (!char.IsPunctuation(c))
                {
                    remPunk += c;
                }
            }

            // intializing and creating array 
            const int SIZE = 7;
            string[] strSep = remPunk.Split(new[] { " ", "\n" }, StringSplitOptions.None);


            // declaring counter
            int charCount = 0; 
            foreach (string str in strSep)
            {   
                //count e and t
                if (str.ToLower().EndsWith("e") || str.ToLower().EndsWith("t"))
                {
                    charCount++;

                }
            }

            Console.WriteLine("There are " + charCount + " words that end in t or e.");
            Console.ReadLine();


        }
    }
}