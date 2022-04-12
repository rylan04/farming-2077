using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Text numOfPizza;
    public Text numOfStrawberry;
    public Text numOfSushi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string pizza = Globals.Inventory["pizza"].ToString();
        string strawberry = Globals.Inventory["strawberry"].ToString();
        string sushi = Globals.Inventory["sushi"].ToString();

        numOfPizza.text = pizza;
        numOfStrawberry.text = strawberry;
        numOfSushi.text = sushi;
    }
}
