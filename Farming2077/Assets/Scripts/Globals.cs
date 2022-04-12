using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static int YeeHaws;
    public static int AnimalHealth;
    public static float XP;
    public static int CurrentAnimal;
    // Maps the item name (e.g. "Eggs") to its quantity
    public static Dictionary<string, int> Inventory;

    void Start()
    {
        YeeHaws       = 100;
        AnimalHealth  = 100;
        XP            = 0.0f;
        CurrentAnimal = 0;
        Inventory     = new Dictionary<string, int>();
        Inventory["pizza"] = 0;
        Inventory["strawberry"] = 0;
        Inventory["sushi"] = 0;
    }

}
