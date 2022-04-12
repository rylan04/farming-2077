using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static int YeeHaws;
    public static int AnimalHealth;
    public static int XP;
    public static int CurrentAnimal;
    // Maps the item name (e.g. "Eggs") to its quantity
    public static Dictionary<string, int> Inventory;

    void Start()
    {
        YeeHaws       = 100;
        AnimalHealth  = 100;
        XP            = 0;
        CurrentAnimal = 0;
        Inventory     = new Dictionary<string, int>();
    }

}
