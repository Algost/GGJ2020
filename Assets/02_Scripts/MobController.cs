using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using System;
using System.Collections;
using Random = UnityEngine.Random;

public class MobController : MonoBehaviour
{
    public NavMeshAgent agent;
    public int mobPoints = 10;
    public int PV = 5;
    public int fortressDgt = 1;
    public Ondie onDie;
    public OnTouch onTouch;
    public Animator animator;
    public float maxSpeed = 5.0f;
    public bool isDead;

    [Serializable]
    public class Ondie : UnityEvent<MobController> { }

    [Serializable]
    public class OnTouch : UnityEvent<int> { }

    private void Start()
    {
        //Invoke("died", 2.0f);
        agent.speed = Random.Range(1.0f, maxSpeed);
        onDie.AddListener(GameManager.Instance.addPointsToScore);
        onTouch.AddListener(GameManager.Instance.loosingFortressPoints);
        animator.SetFloat("MoveSpeed", 1f);
    }

    public void setDestionation(Transform target)
    {
        agent.SetDestination(target.position);
    }

    public void changePV(int degats)
    {
        if (isDead)
            return;
        PV += degats;
        if (PV <= 0)
        {
            died();
        }
    }

    public void died()
    {
        isDead = true;
        agent.speed = 0;
        onDie.Invoke(this);
    }

    public void DestroyZombie()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Fortress"))
        { 
            onTouch.Invoke(fortressDgt);
            died();
        }
    }
}
