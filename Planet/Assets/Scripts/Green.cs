using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour {


    public SpriteRenderer rend;
    public Sprite[] sprites;

    public GameObject[] butters;
    private float randTimer;
    int randOne;
    int randButter;

    bool stop;
    private void Start()
    {
        randOne = Random.Range(0, 5);
        randButter = Random.Range(0, butters.Length);
        int rand = Random.Range(0, sprites.Length);
        randTimer = Random.Range(0, 5);
        rend.sprite = sprites[rand];

       
    }

    private void Update()
    {
        if (randOne == 2)
        {
            if (randTimer <= 0)
            {
                if (stop  == false) {
                    Instantiate(butters[randButter], transform.position, transform.rotation);
                    stop = true;
                }
              
            }
            else {
                randTimer -= Time.deltaTime;
            }
            
        }
    }

}
