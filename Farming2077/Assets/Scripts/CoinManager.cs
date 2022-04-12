using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text numOfYeeHaws;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    

    // Update is called once per frame
    void Update()
    {
        string yeehaws = Globals.YeeHaws.ToString();
        numOfYeeHaws.text = yeehaws;
    }
}
