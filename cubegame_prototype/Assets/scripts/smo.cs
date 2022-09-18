using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smo : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector2 mat=GetComponent<MeshRenderer>().material.mainTextureOffset;
        mat.x += Time.deltaTime*0.03f;
        GetComponent<MeshRenderer>().material.mainTextureOffset=mat;
    }
}
