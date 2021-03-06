﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using static CelestialBody;

namespace Sat_CSV_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting from CSV!");
            ConvertFromCSV("CleanedData.csv");
        }

        static CelestialBody[] ConvertFromCSV(string filename)
        {
            // Write something here to maybe convert the CleanedData.json file and
            //   export like an array/vector of satellite objects (class CelestialBody???)

            /* 
                TODO: Brendan requests "Can you guys write a Json parser for our data and make an array of
                to roll with in the Unity envt?"
            */
            // I suspect the units for the Cleaned data is in feet

            // create array for all the bodies
            CelestialBody[] bodies = new CelestialBody[501];
            int count = 0;

            var path = filename;
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = false;

                // Skip the row with the column names
                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    CelestialBody tempCB = new CelestialBody();

                    // Read current line fields, pointer moves to the next line.
                    
                    string[] fields = csvParser.ReadFields();
                    Console.WriteLine(fields[0]);
                    string ID = fields[0];
                    string pos0 = fields[2];
                    string pos1 = fields[3];
                    string pos2 = fields[4];
                    string vel0 = fields[5];
                    string vel1 = fields[6];
                    string vel2 = fields[7];

                    tempCB.InternalID = Int32.Parse(ID);
                    
                    tempCB.Position[0] = Convert.ToDouble(pos0);
                    tempCB.Position[1] = Convert.ToDouble(pos1);
                    tempCB.Position[2] = Convert.ToDouble(pos2);
                    
                    tempCB.Velocity[0] = Convert.ToDouble(vel0);
                    tempCB.Velocity[1] = Convert.ToDouble(vel1);
                    tempCB.Velocity[2] = Convert.ToDouble(vel2);

                    bodies[count] = tempCB;
                    count++;

                }
            }

            return bodies;
        }
    }
}
