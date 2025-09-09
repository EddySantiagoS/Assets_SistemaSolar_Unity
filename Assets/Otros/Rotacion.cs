using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float speed = 3f;
    private float rote;

    // Start is called before the first frame update
    void Start()
    {
        rote = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rote, 0);
    }
}
