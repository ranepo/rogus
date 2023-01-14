using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DeathMenu;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject PauseMenu;
    public static bool IsPaused = false;

    void Start()
    {
        AudioListener.volume = 0;
        Cursor.lockState = CursorLockMode.None;
        IsPaused = false;
        Time.timeScale = 1f;
        //PlayerPrefs.SetInt("Level", 1);
        //Debug.Log("moi");
        //Debug.Log(PlayerPrefs.GetInt("Level"));
        //SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1));

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void LoadNewScene()
    {
        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeathMenu.SetActive(false);
        Time.timeScale = 1f;
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
        Cursor.visible = true;
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
        PauseMenu.SetActive(false);
    }
    public void settingstomain()
    {
        Cursor.visible = true;
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void pausetomain()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Main Menu");
    }

    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        IsPaused = false;
    }
    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if (!DeathMenu.activeSelf)
        {
            SettingsMenu.SetActive(false);
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            IsPaused = true;
        }
    }
    public void death()
    {
        DeathMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
    }

}
