using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using System;


public class MobController : MonoBehaviour
{
    public NavMeshAgent agent;
    public int mobPoints = 10;
    public int PV = 10;
    public int fortressDgt = 1;
    public AudioSource audioDatas;
    public Ondie onDie;
    public OnTouch onTouch;

    [Serializable]
    public class Ondie : UnityEvent<int> { }

    [Serializable]
    public class OnTouch : UnityEvent<int> { }

    private void Start()
    {
        onDie.AddListener(GameManager.Instance.addPointsToScore);
        onTouch.AddListener(GameManager.Instance.loosingFortressPoints);
        audioDatas = GetComponent<AudioSource>();
    }

    public void setDestionation(Transform target)
    {
        agent.SetDestination(target.position);
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
