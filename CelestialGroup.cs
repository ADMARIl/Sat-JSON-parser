using System.Collections;
using System.Collections.Generic;

//using UnityEngine;
using static CelestialBody;

public class CelestialGroup
{
    // Member variables
    public CelestialBody[] Bodies; // Array of CelestialBody objects to control
    public double[] BodyTrails; // Storing color of CelestialBody trails

    // Start is called before the first frame update
    void Start()
    {
        // Call a function to take in and create objects from JSON data in
        //   CleanedData.json -- there should be C# libraries to do this w/ JSON

        // Instantiate all of the necessary CelestialBody objects into the scene
        //   and store them in public array above

       // ConvertFromJSON("CleanedData.json");    
    }

    // Update is called once per frame
    void Update()
    {

    }

}
