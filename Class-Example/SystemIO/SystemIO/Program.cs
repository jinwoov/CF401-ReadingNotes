using System;
using System.IO;

namespace SystemIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //WriteToFile();
            //ReadaFile();
            //FileAppendText();

            //ReadAllLines();
            DeleteAFile();
        }
        // Create a File
        static void WriteToFile()
        {
            // Defined the file 
            // change the path to specific location
            string path = "../../../jin.txt";
            // Wrote to the file specific text
            File.WriteAllText(path, "Coronavirus popclyse");

        }

        // Read a file
        static void ReadaFile()
        {
            string path = "../../../jin.txt";
            string myFile = File.ReadAllText(path);
            Console.WriteLine(myFile);
        }

        static void ReadAllLines()
        {
            string path = "../../../jin.txt";
            string[] line = File.ReadAllLines(path);
            Console.WriteLine(String.Join(", ", line));
        }

        // adding text
        static void FileAppendText()
        {
            string[] words = { "", "The cat in the hat", "beets", "bear", "battlegalactica" };
            string path = "../../../jin.txt";

            File.AppendAllLines(path, words);
        }
        //alternative way to read a file
        static void ReadFile()
        {
            string path = "../../../jin.txt";

            try
            {
                // using a stream/ opening a connection
                using (StreamReader sr = File.OpenText(path))
                {
                    string text = "";
                    while ((text = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Your file is not available");
            }
            finally
            {
                Console.WriteLine("The process is completed");
            }
        }
        // Update file

        //static void UpdateFile()
        //{
        //    string path = "../../../jin.txt";

        //    // Add the numbers 0 - 4 in the text
        //    try
        //    {
        //        using (StringWriter sr = File.AppendText(path))
        //        {
        //            for (int i = 0; i < 5; i++)
        //            {
        //                sr.WriteLine(i);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        // Delete a file

        static void DeleteAFile()
        {
            string potato = "../../../jin.txt";

            File.Delete(potato);
        }

        static void PracticeUsingSplit()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string text = "one\ttwo three:four, five six seven";

            string[] words = text.Split(delimiterChars);

            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }

        static void DeleteItem(string testToremove)
        {
            string[] words = ReadAllLines();
            string[] newWords = new string[words.Length - 1];

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i])
            }


        }
    }
}
