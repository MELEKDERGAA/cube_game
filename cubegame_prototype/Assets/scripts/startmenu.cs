using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public GameObject game;
    public GameObject pausedbutton;
    bool ispaused;
    private void Start()
    {
        ispaused = false;
    }
    public void Start_menu()
    {
        SceneManager.LoadScene("start",LoadSceneMode.Single);
    }
    public void Restart()
    {
       Scene scene=SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name,LoadSceneMode.Single);
    }
    public void paused() 
    {
        ispaused = true;   
    }
    public void Resume()
    {
        ispaused=false;
    }
    private void Update()
    {
        if (ispaused)
        {
            Time.timeScale = 0.0f;
        }else
        {
            Time.timeScale = 1.0f;
        }
        if (game != null && pausedbutton != null)
        {
            game.SetActive(ispaused);
            pausedbutton.SetActive(!ispaused);
        }
    }

}
