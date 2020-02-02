using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [System.Serializable]
    public class TriggerEventCallback : UnityEvent<Collider> { }
    [SerializeField]
    private TriggerEventCallback m_onEnter;

    [SerializeField]
    private TriggerEventCallback m_onExit;

    void OnTriggerEnter(Collider collider)
    {
        m_onEnter?.Invoke(collider);
    }

    void OnTriggerExit(Collider collider)
    {
        m_onExit?.Invoke(collider);
    }
}
