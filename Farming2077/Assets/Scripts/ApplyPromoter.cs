using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyPromoter : MonoBehaviour
{
    public Image exp;
    public Button feedPizzaBtn;
    public Button feedStrawBtn;
    public Button feedSushiBtn;
    
    public void feedPizza(){
    	if (Globals.Inventory["pizza"] > 0) {
    	    exp.fillAmount += 0.015f;
            Globals.Inventory["pizza"] -= 1;
            Globals.hasStatus = false;
            Globals.AnimalHealth = 1;
        }
    }
    
    public void feedStrawberry(){
    	if (Globals.Inventory["strawberry"] > 0) {
    	    exp.fillAmount += 0.04f;
            Globals.Inventory["strawberry"] -= 1;
            Globals.hasStatus = false;
            Globals.AnimalHealth = 1;
        }
    }
    
    public void feedSushi(){
    	if (Globals.Inventory["sushi"] > 0) {
    	    exp.fillAmount += 0.09f;
            Globals.Inventory["sushi"] -= 1;
            Globals.hasStatus = false;
            Globals.AnimalHealth = 1;
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        feedPizzaBtn.interactable = false;
        feedSushiBtn.interactable = false;
        feedStrawBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
    	
        if (Globals.Inventory["sushi"] > 0){
            feedSushiBtn.interactable = true;
        }else{
       	    feedSushiBtn.interactable = false;
        }
        
        if (Globals.Inventory["pizza"] > 0){
            feedPizzaBtn.interactable = true;
        }else{
            feedPizzaBtn.interactable = false;
        }
        
        if (Globals.Inventory["strawberry"] > 0){
            feedStrawBtn.interactable = true;
        }else{
	    feedStrawBtn.interactable = false;
        }
    }
}
