using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour {
    public static bool started=false;
    public GameObject menuUI;

    public GameObject acorn;

    private void Start()
    {
        Debug.Log("Scene started");
        if (started)
        {
            menuUI.SetActive(false);
            acorn.SetConditionalActive(true);
        }
    }
    public void startGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        started = true;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
