using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DeathMenuUI;
    void Start()
    {
        //PlayerPrefs.SetInt("Level", 1);
        //Debug.Log("moi");
        //Debug.Log(PlayerPrefs.GetInt("Level"));
        //SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1));
 
    }

    public void LoadNewScene()
    {
        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeathMenuUI.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1));
    }
    public void RunTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
