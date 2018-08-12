using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour {

    private GM gm;
    public int dangerMax;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>(); ;
        dangerMax = Random.Range(200, 600);
    }

    private void Update()
    {
        if (gm.danger > dangerMax) {
            Destroy(gameObject);
        }
    }
}
