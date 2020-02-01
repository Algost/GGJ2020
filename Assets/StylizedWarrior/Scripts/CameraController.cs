using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    //public Camera GetComponent<Camera>();
    //public Camera GetComponent<Camera2>();

    //Camera cam01 = GameObject.GetComponent<Camera>();
    //Camera cam02 = GameObject.GetComponent<Camera2>();

    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;
    void Start()
    {
        //GetComponent<Camera>().enabled = true;
        //GetComponent<Camera2>().enabled = false;
        Camera1.enabled = true;
        Camera2.enabled = false;
        Camera3.enabled = false;
        Camera4.enabled = false;
    }

    void Update()
    {
        //This will toggle the enabled state of the two cameras between true and false each time
        /**if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Camera>().enabled = !GetComponent<Camera>().enabled;
            GetComponent<Camera2>().enabled = GetComponent<Camera2>().enabled;
        }
        */

        /**if (Input.GetKeyUp(KeyCode.Space))
        {
            Camera1.enabled = false;
            Camera2.enabled = true;
        }
        */

    

    }

    public void Camera1to2()
    {
        Camera1.enabled = false;
        Camera2.enabled = true;
    }

    public void Camera2to3()
    {
        Camera2.enabled = false;
        Camera3.enabled = true;
    }

    public void Camera2to1()
    {
        Camera2.enabled = false;
        Camera1.enabled = true;
    }

    public void Camera3to2()
    {
        Camera3.enabled = false;
        Camera2.enabled = true;
    }

    public void Camera3to4()
    {
        Camera3.enabled = false;
        Camera4.enabled = true;
    
    }
    public void Camera4to3()
    {
        Camera4.enabled = false;
        Camera3.enabled = true;
    }

    public void Camera4to1()
    {
        Camera4.enabled = false;
        Camera1.enabled = true;
    }
    public void Camera1to4()
    {
        Camera1.enabled = false;
        Camera4.enabled = true;
    }


}