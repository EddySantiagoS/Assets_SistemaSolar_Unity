using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour
{
    public Transform target;
    private float distance;
    
    void Start ()
    {
        distance = -transform.position.z;
    }
    
    // Update is called once per frame
    void Update()
    {       

        Vector3 relativePos = target.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);

        transform.Translate(0, 0, distance * Time.deltaTime);
    }
}
