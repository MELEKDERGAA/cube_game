using UnityEngine;

public class quit_Game : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("quit done");
        Application.Quit();
    }
}
