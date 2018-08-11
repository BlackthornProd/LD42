using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject enemy;

    public float startTimeBtwShots;
    private float timeBtwShots;

    private void Update()
    {
        if (timeBtwShots <= 0)
        {
            int randPos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randPos].position, spawnPoints[randPos].rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
