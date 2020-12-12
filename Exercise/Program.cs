using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise
{
    public class Program
    {
        public int OpenFile(string fileName)
        { // opens a local file from a given path such as Exercise.Tests/files/text1.txt
          // returns -2 if directory does not exist, -1 if file could not be opened; 0 if everything worked

                return -1;
        }

        public string[] OpenFileAndReadLines(string fileName, int howMany)
        { // opens a local file from a given path such as Exercise.Tests/files/text1.txt
          // returns the first <howMany> lines from the given file or an empty string array if the file does not exist

            return null;
        }

        public int PersistentFileOpen(string fileName)
        { // opens a local file from a given path such as Exercise.Tests/files/text1.txt
          // returns -2 if directory does not exist, -1 if file could not be opened; 0 if everything worked
          // return 1 if the file is already open


            return -1;
        }

        public int PersistentFileClose(string fileName)
        { // closes a local file from a given path such as Exercise.Tests/files/text1.txt
          // returns -1 if file could not be closed; 0 if everything worked

            return -1;
        }

        public string[] PersistentFileRead(int numOfLines)
        { // uses the last opened file and reads a given number of lines
          // returns <numOfLines> lines from the given file or 
          //  an empty string array if the file does not exist
          // if called a second time it again reads from the beginning of the file


            return new string[10];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercise 7!");
        }
    }
}
