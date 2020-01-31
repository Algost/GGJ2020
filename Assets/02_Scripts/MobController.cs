using UnityEngine;
using UnityEngine.AI;

public class MobController : MonoBehaviour
{
    public NavMeshAgent agent;

    public void setDestionation(Transform target)
    {
        agent.SetDestination(target.position);
    }
}
