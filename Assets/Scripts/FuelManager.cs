using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelManager : MonoBehaviour {

    private static int sCurrentFuelOnLevel = 0;
    private static int sCurrentFuelOnWorld = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static int FuelGet()
    {
        return sCurrentFuelOnLevel;
    }

    public static void FuelUp()
    {
        sCurrentFuelOnLevel++;
    }

    public static void FuelDown()
    {
        sCurrentFuelOnLevel--;
    }

    public static void FuelReset()
    {
        sCurrentFuelOnLevel = 0;
    }

    public static void AddFuelToWorldFuel()
    {
        sCurrentFuelOnWorld += sCurrentFuelOnLevel;
        FuelReset();
    }

    public static int WorldFuelGet()
    {
        return sCurrentFuelOnWorld;
    }
}
