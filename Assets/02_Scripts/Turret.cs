using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public List<GameObject> objectToShoot;
    public GameObject bulletPrefab;
    public float repeatRate = 0.5f;
    public Transform bulletSpawn;
    [SerializeField]
    private Vector2 m_overHeatRange;

    private int m_overHeatStatus;
    private Repairable m_repairable;

    private void Awake()
    {
        m_repairable = GetComponent<Repairable>();
        InvokeRepeating("shootATarget", 1.0f, repeatRate);
    }
    public void CheckMobsEnter(Collider other)
    {
        if (other.tag == "Mobs")
            objectToShoot.Add(other.gameObject);
    }

    public void CheckMobsExit(Collider other)
    {
        if (other.tag == "Mobs")
            objectToShoot.Remove(other.gameObject);
    }

    public Transform findTheClosestTarget()
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        foreach (GameObject potentialTarget in objectToShoot)
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget.transform;
            }
        }
        return bestTarget;
    }

    public void shootATarget()
    {
        Transform tmp;
        objectToShoot.RemoveAll(item => item == null);
        if ((tmp = findTheClosestTarget()) != null && !m_repairable.damaged)
        {
            InstantiateBullet(tmp);
        }
    }

    private void InstantiateBullet(Transform tmp)
    {
        GameObject bullet = Instantiate(bulletPrefab, (bulletSpawn.position), Quaternion.identity) as GameObject;
        bullet.GetComponent<Bullet>().transformTarget = tmp;
        m_overHeatStatus++;
        if (m_overHeatStatus >= m_overHeatRange.y)
            m_repairable.SetOverHeat();
        else if (m_overHeatStatus >= m_overHeatRange.x && Random.Range(0, 4) == 0)
            m_repairable.SetOverHeat();
    }
}
