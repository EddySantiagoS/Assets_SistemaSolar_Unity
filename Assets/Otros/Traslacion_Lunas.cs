using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion_Lunas : MonoBehaviour
{
    public Transform target;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(relativePos);
       
    }
}
