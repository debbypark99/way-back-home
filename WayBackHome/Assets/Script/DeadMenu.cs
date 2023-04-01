using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class DeadMenu : MonoBehaviour {

    public GameObject DeadUI;

    public static bool dead_state = false;

    void Start()
    {
        DeadUI.SetActive(false);
    }
    void Update()
    {
        if(dead_state)
        {
            DeadUI.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            DeadUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        Debug.Log("resume button clicked");
        dead_state = false;
        //DeadUI.SetActive(false);
        //Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("modified");
        dead_state = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
