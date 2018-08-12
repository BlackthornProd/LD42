using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    private GM gm;

    public float startTimeBtwGold;
    private float timeBtwGold;
    public int gold;

    public GameObject human;
    public GameObject explosion;

    private void Start()
    {
        timeBtwGold = startTimeBtwGold;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
        Instantiate(human, gm.transform.position, transform.rotation);
    }

    private void Update()
    {

        if (gm.danger >= 2000) {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (timeBtwGold <= 0)
        {
            gm.gold += gold;
            timeBtwGold = startTimeBtwGold;
        }
        else {
            timeBtwGold -= Time.deltaTime;
        }
    }
}
