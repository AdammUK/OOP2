using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Assignment2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string filepath1 = "";
            string filepath2 = "";
            Console.WriteLine("Please choose two of the following files (1a, 1b, 2a, 2b, 3a, 3b)");
            Console.WriteLine("Input first choice: ");
            string choice1 = Console.ReadLine().ToLower();
            
            if (choice1 == "1a"){
                filepath1 = (@"Assessment2Files\GitRepositories_1a.txt");
            }
            if (choice1 == "1b")
            {
                filepath1 = (@"Assessment2Files\GitRepositories_1b.txt");
            }
            if (choice1 == "2a")
            {
                filepath1 = (@"Assessment2Files\GitRepositories_2a.txt");
            }
            if (choice1 == "2b")
            {
                filepath1 = (@"Assessment2Files\GitRepositories_2b.txt");
            }
            if (choice1 == "3a")
            {
                filepath1 = (@"Assessment2Files\GitRepositories_3a.txt");
            }
            if (choice1 == "3b")
            {
                filepath1 = (@"Assessment2Files\GitRepositories_3b.txt");
            }

            Console.WriteLine("Input second choice: ");
            string choice2 = Console.ReadLine().ToLower();
            if (choice2 == "1a")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_1a.txt");
            }
            if (choice2 == "1b")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_1b.txt");
            }
            if (choice2 == "2a")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_2a.txt");
            }
            if (choice2 == "2b")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_2b.txt");
            }
            if (choice2 == "3a")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_3a.txt");
            }
            if (choice2 == "3b")
            {
                filepath2 = (@"Assessment2Files\GitRepositories_3b.txt");
            }

            int same = 0;
            int different = 0;
            string[] Lines1 = File.ReadAllLines(filepath1);
            string[] Lines2 = File.ReadAllLines(filepath2);
            for (int line = 0; line < Lines1.Length; line++)
            {
                if (line < Lines2.Length)
                {
                    if (Lines1[line].Equals(Lines2[line]))
                    {
                        same++;
                    }
                    else
                    {
                        different++;
                    }
                }
                else
                {
                    different++;
                }
            }
            if (same == Lines2.Length)
            {
                Console.WriteLine("Files "+choice1+" and "+choice2+" are the same");
            }
            if (different > 0)
            {
                Console.WriteLine("Files "+ choice1+ " and " +choice2+ " are not the same");
            }

            
        }
    }
}
