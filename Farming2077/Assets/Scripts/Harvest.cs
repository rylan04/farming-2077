using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvest : MonoBehaviour
{
    public Button harvestBtn;
    public Text numOfYeeHaws;
    public bool harvestAvailable;
    public float timePassed;

    public void HarvestCoin() {
        if (Globals.CurrentAnimal == 0) {
            Globals.YeeHaws += 5;
        } else if (Globals.CurrentAnimal == 1) {
            Globals.YeeHaws += 10;
        } else if (Globals.CurrentAnimal == 2) {
            Globals.YeeHaws += 15;
        }
        timePassed = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        harvestAvailable = false;
        harvestBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += 1 * Time.deltaTime;
        if (timePassed > 3){
        	harvestBtn.interactable = true;
        }else{
        	harvestBtn.interactable = false;
        }
    }
}
