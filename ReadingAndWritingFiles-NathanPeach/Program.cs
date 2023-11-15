using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //this is required to read files
namespace ReadingAndWritingFiles_NathanPeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading & Writing Files in C#");
            Console.WriteLine();

            //reads from the "Text.txt" file 
            string path = @"Test.txt";
            //reads from the "Map.txt" file
            string mapPath = @"Map.txt";

            //making two new string variables that equal the text content of both of the files
            string input = File.ReadAllText(path);
            string mapInput = File.ReadAllText(mapPath);

            //Writes the contents of the files
            Console.WriteLine(input);
            Console.WriteLine(mapInput);
            Console.WriteLine();


            //Reading all lines
            string[] mapRows;
            mapRows = File.ReadAllLines(mapPath);
            //ReadAllLines outputs an array of strings instead of outputting the entire file as a single string
            
            for (int y = 0; y < mapRows.Length; y++)
            {
                string mapRow = mapRows[y]; //represents a single row of the map array
                for (int x = 0; x < mapRow.Length; x++)
                {
                    char tile = mapRow[x];
                    Console.Write(tile);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
