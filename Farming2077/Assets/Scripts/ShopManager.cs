using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
  public void buyPizza(){
    if (Globals.YeeHaws < 5){
    	print("not enough money");
    }else{
    	Globals.Inventory["pizza"] += 1;
    	Globals.YeeHaws -= 5; 
    }
  }   
   
  public void buyStrawberry(){
    if (Globals.YeeHaws < 7){
    	print("not enough money");
    }else{
    	Globals.Inventory["strawberry"] += 1;
    	Globals.YeeHaws -= 7; 
    }
  }
  
  public void buySushi(){
    if (Globals.YeeHaws < 10){
    	print("not enough money");
    }else{
    	Globals.Inventory["sushi"] += 1;
    	Globals.YeeHaws -= 10; 
    }
  } 
}
