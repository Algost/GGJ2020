using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    private Vector2 m_movement;

    private void Update()
    { 
        transform.Translate(speed * Time.deltaTime * m_movement.normalized);
    }

    private void OnMovement(InputValue inputValue)
    {
        print("Move");
        m_movement = inputValue.Get<Vector2>();
    }

    private void OnRepair(InputValue value)
    {
        print("Repair");
    }
}
