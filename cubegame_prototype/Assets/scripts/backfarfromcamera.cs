using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backfarfromcamera : MonoBehaviour
{
    public Transform camera;
    Vector3 position;
    private void Start()
    {
        position = transform.position - camera.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position + position;
    }
}
