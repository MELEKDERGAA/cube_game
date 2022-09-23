using UnityEngine;

public class quitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("quit done");
        Application.Quit();
    }
}
