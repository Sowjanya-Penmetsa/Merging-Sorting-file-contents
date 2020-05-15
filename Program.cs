using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Merging_files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the first file
            string[] File1 = File.ReadAllLines("C:/Users/Anvesh Penmetsa/Desktop/files/file1.txt");

            //Displaying the contents of first file
            Console.WriteLine("The contents of first file are:");
            foreach (string file11 in File1)
                Console.WriteLine(file11);

            // Reading the second file
            string[] File2 = File.ReadAllLines("C:/Users/Anvesh Penmetsa/Desktop/files/file2.txt");

            //Displaying the contents of second file
            Console.WriteLine("The contents of second file are:");
            foreach (string file12 in File2)
                Console.WriteLine(file12);

            //Merging two Strings
            var myList = new List<String>();
            myList.AddRange(File1);
            myList.AddRange(File2);
            String[] File3 = myList.ToArray();

           // Displaying the contents of merged file
            Console.WriteLine("The contents in the file after merging");
            foreach (String file13 in File3)
                Console.WriteLine(file13);

            // Sorting the contents of merged file and displaying them
            Array.Sort(File3);
            Console.WriteLine(" The contents of the file after sorting");
            foreach (String file14 in File3)
                Console.WriteLine(file14);

            Console.ReadLine();
            
            
        }
    }
}
