using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hinderers : MonoBehaviour
{
    public Text message;
    public Image health;
    // public float nextTime;
    // public float modifier;

    public void SelectHinderer() {
    	// print("selecting hinderer");
        // int hindererSelector = Random.Range(1, 2);
        // switch (hindererSelector) {
        //     case 1: 
        //         Globals.YeeHaws -= 10;
        //         Globals.XP -= 0.05f;
        //         break;
        //     case 2: 
        //         if (Globals.Inventory["pizza"] > 3) {
        //             Globals.Inventory["pizza"] -= 3;
        //         }
        //         if (Globals.Inventory["strawberry"] > 2) {
        //             Globals.Inventory["strawberry"] -= 2;
        //         }
        //         if (Globals.Inventory["sushi"] > 3) {
        //             Globals.Inventory["sushi"] -= 3;
        //         }
        //         break;
        //     case 3: 
        //         Globals.AnimalHealth -= 5;
        //         break;
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        // nextTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        int RandomStatus = Random.Range(0,2000);
        // print(RandomStatus.ToString());
        // print(Globals.hasStatus);
        
        if (RandomStatus == 3 && !Globals.hasStatus){
            Globals.YeeHaws -= 10;
            Globals.XP -= 0.05f;
            Globals.hasStatus = true;
            Globals.AnimalStatus = "Oh no! It's hungry! You just lost some XP and YeeHaws!";
        }else if (RandomStatus == 5 && !Globals.hasStatus ){
            Globals.AnimalHealth -= 0.5f;
            Globals.hasStatus = true;
            Globals.AnimalStatus = "Oh no! Your specimen got sick and lost health!";
        }

        if (Globals.hasStatus == false){
            Globals.AnimalStatus = "Your specimen is looking healthy...";
        }

        message.text = Globals.AnimalStatus;
        health.fillAmount = Globals.AnimalHealth;
        // modifier = 3f;
        // nextTime = Time.time + modifier;
        // if (Time.time > nextTime) {
        //     SelectHinderer();
        // }
    }
}
