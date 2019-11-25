using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.VisualBasic.FileIO;
using static CelestialBody;

namespace Sat_JSON_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConvertFromJSON("CleanedData.json");
        }

        static CelestialBody[] ConvertFromJSON(string filename)
        {
            Console.WriteLine("Bottom Text got that Bottom Text");


            var path = filename;
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string Name = fields[0];
                    string Address = fields[1];
                }
            }
            // HELLO CHAS
            // Hello Andre
            // Write something here to maybe convert the CleanedData.json file and
            //   export like an array/vector of satellite objects (class CelestialBody???)

            /* 
                TODO: Brendan requests "Can you guys write a Json parser for our data and make an array of
                to roll with in the Unity envt?"
            */
            // I suspect the units for the Cleaned data is metric but I have no idea which one
            // read in file to one big string
            //string jsonString = ;

            //var satIDs = JsonConvert.DeserializeObject<CelestialBody>(File.ReadAllText(filename));

            CelestialBody tempCB = new CelestialBody();

            CelestialBody[] bodies = new CelestialBody[500];
            //bodies[0] = ;
            return bodies;
            //GameObject temp = new GameObject();

        }
    }
}
