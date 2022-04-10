using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Map_to_Shop(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
    public void Shop_to_Map(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
    } 
    public void Map_to_UserUI(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
    } 
    public void UserUI_to_Map(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    } 
    public void Map_to_Barn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); 
    } 
    public void Barn_to_Map(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); 
    } 
}
