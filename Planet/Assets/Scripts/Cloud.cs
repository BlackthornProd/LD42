using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    private GM gm;

    public float minTime;
    public float maxTime;
    private float timeBtwLight;
    public int dangerStart;

    public GameObject lightning;
   

    private void Start()
    {
        timeBtwLight = Random.Range(minTime, maxTime);
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
    }

    private void Update()
    {
        if (gm.danger > dangerStart) {
            if (timeBtwLight <= 0)
            {
                Instantiate(lightning, transform.position, transform.rotation);
                timeBtwLight = Random.Range(minTime, maxTime);
            }
            else {
                timeBtwLight -= Time.deltaTime;
            }
        }
    }
}
