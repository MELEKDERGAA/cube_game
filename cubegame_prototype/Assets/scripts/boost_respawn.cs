using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost_respawn : MonoBehaviour
{
    float i=3.0f;
    private bool isboosted=false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("slow"))
        {
            GetComponent<Rigidbody>().drag=3.0f;
            isboosted = true;
        }else if (other.gameObject.CompareTag("speed"))
        {
            GetComponent<Rigidbody>().drag = -2.0f;
            isboosted = true;
        }
        
    }
    private void Update()
    {
        if (isboosted)
        {
            i -= Time.deltaTime;
            if (i <= 0.0f)
            {
                GetComponent<Rigidbody>().drag = 0.0f;
                i = 3.0f;
                isboosted=false;
            }
        }
    }
   
}
