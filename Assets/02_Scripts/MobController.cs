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
    public int PV = 10;
    public int fortressDgt = 1;
    public AudioSource audioDatas;
    public Ondie onDie;
    public OnTouch onTouch;
    public Animator animator;
    public float maxSpeed = 5.0f;

    [Serializable]
    public class Ondie : UnityEvent<int> { }

    [Serializable]
    public class OnTouch : UnityEvent<int> { }

    private void Start()
    {
        agent.speed = Random.Range(1.0f, maxSpeed);
        onDie.AddListener(GameManager.Instance.addPointsToScore);
        onTouch.AddListener(GameManager.Instance.loosingFortressPoints);
        audioDatas = GetComponent<AudioSource>();
        animator.SetTrigger("Walk");
    }

    public void setDestionation(Transform target)
    {
        agent.SetDestination(target.position);
        Debug.Log("target.position : " + target.position.ToString());
    }

    public void changePV(int degats)
    {
        PV += degats;
        if (PV <= 0)
        {
            audioDatas.Play(0);
            onDie.Invoke(mobPoints);
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Fortress")
        {
            onTouch.Invoke(fortressDgt);
        }
    }
}
