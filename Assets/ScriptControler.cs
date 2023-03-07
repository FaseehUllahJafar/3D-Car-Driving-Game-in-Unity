using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptControler : MonoBehaviour
{
    float speed = 20;
    float horizontalInput = 0;
    float forwardInput = 0;

    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //moves the care based on vertical input
       
        transform.Translate(Vector3.forward *  Time.deltaTime * speed * forwardInput);

        //reotates the on base of horizontal
        transform.Rotate(Vector3.up *  Time.deltaTime * speed * horizontalInput);
    }

}
