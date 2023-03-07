using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
//    public GameObject player1stPerson;
    private Vector3 offset = new Vector3 (0, 6, -10);
    // Start is called before the first frame update

    //main (3rd Person)
    Camera camera1;
    //1st person
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = Camera.main;
        camera1.enabled = true;

        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (camera1.enabled)
            {
                camera2.enabled = true;
                camera1.enabled = false;
            }
            else
            {
                camera2.enabled = false;
                camera1.enabled = true;
                transform.position = player.transform.position + offset;
            }
        }
    }

    void LateUpdate()
    {
       transform.position = player.transform.position + offset;
    }
}
