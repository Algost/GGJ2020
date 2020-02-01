using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public List<GameObject> objectToShoot;
    public GameObject bulletPrefab;
    //public BoxCollider boxCollider;

    private void Awake()
    {
        InvokeRepeating("shootATarget", 1.0f, 1.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mobs")
            objectToShoot.Add(other.gameObject);
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
        if ((tmp = findTheClosestTarget()) != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, (this.transform.position), Quaternion.identity) as GameObject;
            bullet.GetComponent<Bullet>().transformTarget = tmp;
        }
    }

    public void removeFromListShooting(GameObject name)
    {

    }
}
