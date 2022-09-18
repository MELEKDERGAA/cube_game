using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public boost_respawn Boost_Respawn;

    private void OnTriggerStay(Collider other)
    {
        Boost_Respawn.completeLevel();
    }

}
