using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateExp : MonoBehaviour
{
    public float timeStart = 0;
    public int specimenLvl = 0; //need to store elsewhere
    public Image exp;
    public Image specimen;
    public Sprite sheep;
    public Sprite cow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        exp.fillAmount += 0.01f * Time.deltaTime;

        if (exp.fillAmount > 0.98 ){
            exp.fillAmount = 0;
            specimenLvl += 1;
        }

        if (specimenLvl == 1){
            specimen.sprite = sheep;
        }else if (specimenLvl == 2){
            specimen.sprite = cow;
        }
    }
}
