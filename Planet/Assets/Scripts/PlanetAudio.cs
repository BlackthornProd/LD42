using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAudio : MonoBehaviour {

    private GM gm;
    private AudioSource source;
    public AudioClip[] clips;


    public float startTimeBtwClips;
    private float timeBtwClips;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
    }

    private void Update()
    {
        if (timeBtwClips <= 0)
        {
            if (gm.danger < 500)
            {
                int rand = Random.Range(0, 3);
                source.clip = clips[rand];
                source.Play();
            }
            else if (gm.danger >= 500 && gm.danger < 1000)
            {
                int rand = Random.Range(3, 5);
                source.clip = clips[rand];
                source.Play();
            }
            else if (gm.danger >= 1000 && gm.danger < 1500)
            {
                int rand = Random.Range(5, 7);
                source.clip = clips[rand];
                source.Play();
            }
            else if (gm.danger >= 1500 && gm.danger < 2000)
            {
                int rand = Random.Range(7, 9);
                source.clip = clips[rand];
                source.Play();
            }
            timeBtwClips = startTimeBtwClips;
        }
        else {
            timeBtwClips -= Time.deltaTime;
        }
    }
}
