using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector forward -> (0,0,1)
        //(0,0,1) * Time.deltaTime = (0,0,.016) * = (0,0, .16)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
