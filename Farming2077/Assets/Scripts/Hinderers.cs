using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinderers : MonoBehaviour
{
    public float nextTime;
    public float modifier;

    public void SelectHinderer() {
        int hindererSelector = Random.Range(1, 2);
        switch (hindererSelector) {
            case 1: 
                Globals.YeeHaws -= 10;
                Globals.XP -= 0.05f;
                break;
            case 2: 
                if (Globals.Inventory["pizza"] > 3) {
                    Globals.Inventory["pizza"] -= 3;
                }
                if (Globals.Inventory["strawberry"] > 2) {
                    Globals.Inventory["strawberry"] -= 2;
                }
                if (Globals.Inventory["sushi"] > 3) {
                    Globals.Inventory["sushi"] -= 3;
                }
                break;
            case 3: 
                Globals.AnimalHealth -= 5;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        nextTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        modifier = 3f;
        nextTime = Time.time + modifier;
        if (Time.time > nextTime) {
            SelectHinderer();
        }
    }
}
