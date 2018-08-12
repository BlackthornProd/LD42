using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBG : MonoBehaviour {

    private static MusicBG instance;

    private AudioSource source;
    public AudioClip[] clips;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance.gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void TrackOne() {
        source.clip = clips[0];
        source.Play();
    }

    public void TrackTwo() {
        source.clip = clips[1];
        source.Play();
    }

    public void TrackThree()
    {
        source.clip = clips[2];
        source.Play();
    }

    public void TrackFour()
    {
        source.clip = clips[3];
        source.Play();
    }

    public void DeathMusic() {
        source.Stop();
    }


}
