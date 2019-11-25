using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
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

        static CelestialBody[] ConvertFromJSON(string filename) {
            Console.WriteLine("Bottom Text got that Bottom Text");
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
