using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvest : MonoBehaviour
{
    public Button harvestBtn;
    public Text numOfYeeHaws;
    public bool harvestAvailable;

    public void HarvestCoin() {
        if (Globals.CurrentAnimal == 0) {
            Globals.YeeHaws += 10;
        } else if (Globals.CurrentAnimal == 1) {
            Globals.YeeHaws += 15;
        } else if (Globals.CurrentAnimal == 2) {
            Globals.YeeHaws += 25;
        }
        harvestAvailable = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        harvestAvailable = false;
        harvestBtn.interactable = false;
        StartCoroutine(ActivateButton());
    }

    // Update is called once per frame
    void Update()
    {
        if (!harvestAvailable) {
            harvestBtn.interactable = false;
        }
        string yeehaws = Globals.YeeHaws.ToString();
        numOfYeeHaws.text = yeehaws;
    }

    IEnumerator ActivateButton() {
        yield return new WaitForSeconds(3f);
        harvestAvailable = true;
        harvestBtn.interactable = true;
    }
}
