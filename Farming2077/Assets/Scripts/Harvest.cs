using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvest : MonoBehaviour
{
    public Button harvestBtn;
    public Text numOfYeeHaws;

    public void HarvestCoin() {
        Globals.YeeHaws += 25;
        string yeehaws = Globals.YeeHaws.ToString();
        numOfYeeHaws.text = yeehaws;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
