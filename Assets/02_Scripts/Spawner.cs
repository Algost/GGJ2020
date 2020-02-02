using UnityEngine;


public class Spawner : MonoBehaviour
{

    static float COOLDOWN = 0.5f;

    //Public Variables
    public GameObject prefabEnnemi;
    public float spawnTime;
    public float spawnTimeRandom;

    public Transform positionToReach;

    //Private Variables
    private float spawnTimerGloabal;
    private float spawnTimerEnnemi;

    void Start()
    {
        ResetSpawnTimerEnnemi();
        spawnTimerGloabal = Time.time;
    }

    //Update is called once per frame
    void Update()
    {
        spawnTimerEnnemi -= Time.deltaTime;
        //Debug.Log("spawnTimerEnnemi : "+spawnTimerEnnemi);
        if (spawnTimerEnnemi <= 0.0f && spawnTime < Time.time)
        {
            this.SpawnEnnemi();
            ResetSpawnTimerEnnemi();
        }
    }

    private void SpawnEnnemi()
    {
        /*if (Physics.OverlapSphere(this.transform.position + Vector3.up, 0.8f).Length == 0)
        {
            Instantiate(prefabEnnemi, this.transform.position, Quaternion.identity);
        }*/
        GameObject mob = Instantiate(prefabEnnemi, this.transform.position, Quaternion.identity);
        mob.GetComponent<MobController>().setDestionation(positionToReach);
    }

    //Resets the spawn timer with a random offset
    void ResetSpawnTimerEnnemi()
    {
        spawnTimerEnnemi = (float)(spawnTime + Random.Range(0, spawnTimeRandom * 100) / 100.0);
        spawnTimerGloabal = Time.time + COOLDOWN;
    }

}
