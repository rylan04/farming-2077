using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateExp : MonoBehaviour
{
    public float timeStart = 0;
    public Image exp;
    public Image specimen;
    public Sprite sheep;
    public Sprite cow;
    public Sprite wagyu;

    // Start is called before the first frame update
    void Start()
    {
    	exp.fillAmount = Globals.XP; 
    }

    // Update is called once per frame
    void Update()
    {
    	if (!Globals.hasStatus){
            exp.fillAmount += 0.01f * Time.deltaTime;
            Globals.XP = exp.fillAmount;
        }

        if (exp.fillAmount > 0.98){
            exp.fillAmount = 0;
            Globals.CurrentAnimal += 1;
        }

        if (Globals.CurrentAnimal == 1){
            specimen.sprite = sheep;
        }else if (Globals.CurrentAnimal == 2){
            specimen.sprite = cow;
        }else if (Globals.CurrentAnimal == 3){
            specimen.sprite = wagyu;
            SceneManager.LoadScene(4);
        }
    }
}
