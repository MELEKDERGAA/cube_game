using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float x;
    private Collision collision;
    private Vector3 respawnpoint;
    public float force=5.0f;
    float i = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        respawnpoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //x = Input.GetAxis("Horizontal");
        //detect if the cube fall off or the force is not reseted yet
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("ground") || force != 5.0f || collision.gameObject.CompareTag("obs"))
            {
                force = 0.0f;
                transform.position = respawnpoint;
                //Debug.Log(force);
                // makes the cube after respawning hard to get right or left because  the force is too high and the mass is small
                GetComponent<Rigidbody>().drag = 2.5f;
                i -= Time.deltaTime;
                //Debug.Log(i);
                //it's like a clock when "i" gets <=0 that means it's been a 1sec from respawning and only after 1 sec the cube can move freely
                if (i <= 0.0f)
                {
                    i = 2.0f;
                    Debug.Log(i);
                    force = 5.0f;
                    Debug.Log(force);
                    GetComponent<Rigidbody>().drag = .0f;
                    collision = null;
                }
            }
        }
    }
    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        //gives unlimited Z(forword) force
        //it add force to the cube with (right_or_left,0 up_or_down,0 forword_or_backword)
        GetComponent<Rigidbody>().AddForce(new Vector3(x*6.0f,0.0f,force));

    }
    private void OnCollisionEnter(Collision collision)
    {
        this.collision = collision;
    }
}
