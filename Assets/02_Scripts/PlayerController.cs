using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private bool m_move;
    // Start is called before the first frame update
    private Vector3 m_movement;

    private void Start()
    {
        m_move = true;
    }

    private void FixedUpdate()
    {
        Vector3 newVec = speed * Time.deltaTime * m_movement;
        rb.MovePosition(transform.position + newVec);
    }

    private void OnMovement(InputValue inputValue)
    {
        Vector2 vec = inputValue.Get<Vector2>();
        m_movement = new Vector3(vec.x, transform.position.y, vec.y);
    }
}
