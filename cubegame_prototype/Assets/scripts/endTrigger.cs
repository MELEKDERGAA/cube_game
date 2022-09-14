using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public boost_respawn Boost_Respawn;

    void OnTriggerEnter()
    {
        Boost_Respawn.completeLevel();
    }

}
