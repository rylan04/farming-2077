using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyPromoter : MonoBehaviour
{
    public Image exp;
    
    public void Feed(){
    	exp.fillAmount += 0.25f;
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
