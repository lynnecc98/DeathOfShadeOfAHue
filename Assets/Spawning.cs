using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject collectible;
    public float spawnTime;
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(collectible, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}
