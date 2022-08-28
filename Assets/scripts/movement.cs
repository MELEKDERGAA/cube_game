using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float x;
    private Collision collision;
    private Vector3 respawnpoint;
    public float force=5.0f;
    float i = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        respawnpoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        //detect if the cube fall off or the force is not reseted yet
        if (collision.gameObject.CompareTag("ground")||force!=5.0f)
        {
            force = 0.0f;
            transform.position = respawnpoint;
            // makes the cube after respawning hard to get right or left because  the force is too high and the mass is small
            GetComponent<Rigidbody>().drag = 3.0f;
            i-= Time.deltaTime;
            //it's like a clock when "i" gets <=0 that means it's been a 1sec from respawning and only after 1 sec the cube can move freely
            if (i<= 0.0f)
              {
                    i = 1.0f;
                    force = 5.0f;
                    GetComponent<Rigidbody>().drag = .0f;
            }
        }
    }
    void FixedUpdate()
    {
        //gives unlimited Z(forword) force
        //it add force to the cube with (right_or_left,0 up_or_down,0 forword_or_backword)
        GetComponent<Rigidbody>().AddForce(new Vector3(x*6.0f,0.0f,force));

    }
    private void OnCollisionEnter(Collision collision)
    {
        this.collision = collision;
    }
}
