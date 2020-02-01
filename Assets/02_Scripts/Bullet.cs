using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform transformTarget;
    public float speed = 8.0f;
    public int damage = 5;
    public Vector3 lastPos;

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (this.transform == null)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, lastPos, step);
        }
        else
            this.transform.position = Vector3.MoveTowards(this.transform.position, transformTarget.position, step);
        lastPos = transformTarget.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mobs")
        {
            collision.gameObject.GetComponent<MobController>().changePV(damage);
            Destroy(this.gameObject);
        }
    }
}
