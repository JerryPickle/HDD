using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Button start;
    public Button exit;

    public string sampleScene;

    public void Awake()
    {
        start.onClick.AddListener(StartGame);
        exit.onClick.AddListener(ExitGame);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(sampleScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
