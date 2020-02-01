using UnityEngine;
using UnityEngine.AI;

public class MobController : MonoBehaviour
{
    public NavMeshAgent agent;
    public int mobPoints = 10;
    public int PV = 10;
    public AudioSource audioDatas;

    private void Start()
    {
        audioDatas = GetComponent<AudioSource>();
    }

    public void setDestionation(Transform target)
    {
        agent.SetDestination(target.position);
    }

    public void changePV(int newPV)
    {
        PV += newPV;
        if (PV <= 0)
        {
            audioDatas.Play(0);
            Destroy(this);
        }
    }
}
