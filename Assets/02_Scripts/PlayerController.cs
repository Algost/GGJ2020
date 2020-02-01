using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    // Start is called before the first frame update
    private Vector3 m_movement;

    private void FixedUpdate()
    {
        m_movement = new Vector3(m_movement.x, 0, m_movement.y);
        m_movement = speed * Time.deltaTime * m_movement.normalized;
        rb.MovePosition(transform.position + m_movement);
    }

    private void OnMovement(InputValue inputValue)
    {
        //print("Move");
        m_movement = inputValue.Get<Vector2>();
        Debug.Log(m_movement);
    }
}
