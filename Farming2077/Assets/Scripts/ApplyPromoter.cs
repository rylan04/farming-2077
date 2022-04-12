using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyPromoter : MonoBehaviour
{
    public Image exp;
    public Button feedBtn;
    
    public void Feed(){
        if (Globals.Inventory["sushi"] > 0) {
    	    exp.fillAmount += 0.09f;
            Globals.Inventory["sushi"] -= 1;
        } else if (Globals.Inventory["strawberry"] > 0) {
    	    exp.fillAmount += 0.04f;
            Globals.Inventory["strawberry"] -= 1;
        } else if (Globals.Inventory["pizza"] > 0) {
    	    exp.fillAmount += 0.015f;
            Globals.Inventory["pizza"] -= 1;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        feedBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.Inventory["sushi"] > 0 || Globals.Inventory["strawberry"] > 0 || Globals.Inventory["pizza"] > 0) {
            feedBtn.interactable = true;
        }
        else {
            feedBtn.interactable = false;
        }
    }
}
