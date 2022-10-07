using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backfarfromcamera : MonoBehaviour
{
    public new Transform camera;
    public Transform maxpos;
    Vector3 position;
    Vector3 respawn;
    bool respawned;
    private void Start()
    {
        position = transform.position - camera.transform.position;
        respawn=camera.transform.position;
        respawned = false;
    }
    // Update is called once per frame
    void Update()
    {
        movement Movement= new();
        respawned = Movement.respawned;
        if (camera.transform.position.y > maxpos.transform.position.y)
        {
            if (!respawned)
            {
                Debug.Log("first go with");
                transform.position = new Vector3(camera.transform.position.x + position.x, transform.position.y, camera.transform.position.z + position.z);
            }
            else
            {
                Debug.Log("second go with plane");
                transform.position = respawn + position;
            }
        }
       
    }
}
