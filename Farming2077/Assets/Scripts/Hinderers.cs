using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hinderers : MonoBehaviour
{
    public Text message;
    public Image health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int RandomStatus = Random.Range(0,8000);
        
        if (RandomStatus == 3 && !Globals.hasStatus) {
            Globals.YeeHaws -= 10;
            Globals.XP -= 0.02f;
            Globals.hasStatus = true;
            Globals.AnimalStatus = "Oh no! It's hungry! You just lost some XP and YeeHaws!";
        } else if (RandomStatus == 5 && !Globals.hasStatus) {
            Globals.AnimalHealth -= 0.5f;
            Globals.hasStatus = true;
            Globals.AnimalStatus = "Oh no! Your specimen got sick and lost health!";
        }

        if (Globals.hasStatus == false) {
            Globals.AnimalStatus = "Your specimen is looking healthy...";
        }

        message.text = Globals.AnimalStatus;
        health.fillAmount = Globals.AnimalHealth;
    }
}
