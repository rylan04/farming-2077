using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    int START = 0;
    int BARN = 1;
    int SHOP = 2;
    int MAP = 3;
    int WIN = 4;
    int HTP = 5;

    public void playButtonIsPressed()
    {
        SceneManager.LoadScene(BARN);
    }
    public void backToMapButtonIsPressed()
    {
        SceneManager.LoadScene(MAP);
    }
    public void barnButtonIsPressed()
    {
        SceneManager.LoadScene(BARN);
    }
    public void shopButtonIsPressed()
    {
        SceneManager.LoadScene(SHOP);
    }
    public void winGame(){
    	SceneManager.LoadScene(WIN);
    }
    public void toHTP(){
    	SceneManager.LoadScene(HTP);
    }
    public void BackfromHTP(){
    	SceneManager.LoadScene(START);
    }
}
