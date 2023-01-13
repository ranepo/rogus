using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DeathMenuUI;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject PauseMenu;

    void Start()
    {
        //PlayerPrefs.SetInt("Level", 1);
        //Debug.Log("moi");
        //Debug.Log(PlayerPrefs.GetInt("Level"));
        //SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1));
 
    }
    void Update()
    {
        pauseMenu();
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
        SceneManager.LoadScene("rogus");
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
    public void Settingmenu()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void settingstomain()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void pausetomain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void pauseMenu()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
        }
    }

    public void resume()
    {
        Debug.Log("hell");
        PauseMenu.SetActive(false);
    }
}
