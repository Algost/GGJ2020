using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float rotSpeed = 40;

    private void Update()
    {
        transform.Rotate(Time.deltaTime * rotSpeed * Vector3.up);
    }
}


