using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static int YeeHaws;
    public static float AnimalHealth;
    public static float XP;
    public static int CurrentAnimal;
    public static bool hasStatus;
    public static string AnimalStatus;
    // Maps the item name (e.g. "Eggs") to its quantity
    public static Dictionary<string, int> Inventory;

    void Start()
    {
        YeeHaws       = 100;
        AnimalHealth  = 1.0f;
        hasStatus     = false;
        AnimalStatus  = "";
        XP            = 0.0f;
        CurrentAnimal = 0;
        Inventory     = new Dictionary<string, int>();
        Inventory["pizza"] = 0;
        Inventory["strawberry"] = 0;
        Inventory["sushi"] = 0;
    }

}
