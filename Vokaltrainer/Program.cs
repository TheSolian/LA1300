using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;



namespace LA3000
{
    class Program
    {
        static void Main(string[] args)
        {



            //importiert alle Wörter aus der Wordlist und speichert diese in Arrays
            string inPath = @"..\..\..\wordlist.csv";
            string text = File.ReadAllText(inPath);



            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] english = new string[words];
            string[] german = new string[words];



            for (int line = 0; line < lines.Length - 1; line++)
            {
                string[] items = lines[line].Split(',');
                english[line] = items[0].Replace("\"", string.Empty); ;
                german[line] = items[1];
            }



            //fragt den Benutzer ab
            string input;
            string[,] wrongAnsweres = new string[german.Length, 2];



            for (int i = 0; i < english.Length - 1; i++)
            {
                Console.Write(german[i] + ": ");
                input = Console.ReadLine();
                if (input == english[i])
                {



                }
                else
                {
                    wrongAnsweres[i, 0] = german[i];
                    wrongAnsweres[i, 1] = english[i];
                }



            }



            //gibt die falschen Antworten aus
            for (int q = 0; q < 4; q++)
            {
                Console.Write(wrongAnsweres[q, 0] + ", ");
                Console.WriteLine(wrongAnsweres[q, 1]);
            }



        }
    }
}




//string[] namesArray = new string[2];



//List<string> namesList = new List<string>();



//ArrayList namesArrayList = new ArrayList();