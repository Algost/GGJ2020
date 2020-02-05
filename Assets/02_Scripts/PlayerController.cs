using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody m_rb;
    // Start is called before the first frame update
    private Vector3 m_movement;
    private Animator m_animator;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        TurnPlayer();
        AnimatePlayer();
    }

    private void AnimatePlayer()
    {
        if (m_animator == null) return;
        float forw = Vector3.Dot(m_movement, transform.forward);
        m_animator.SetFloat("Forward", forw);
       
    }

    private void TurnPlayer()
    {
        if (m_movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(m_movement);
            m_rb.MoveRotation(newRotation);
        }
    }

    private void MovePlayer()
    {
        m_rb.MovePosition(transform.position + (speed * Time.deltaTime * m_movement));
    }

    private void OnMovement(InputValue inputValue)
    {
        Vector2 vec = inputValue.Get<Vector2>();
        m_movement.Set(vec.x, 0, vec.y);
    }
}
