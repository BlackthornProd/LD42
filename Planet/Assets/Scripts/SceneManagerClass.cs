using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerClass : MonoBehaviour {

    public Animator whitePanel;
    private AudioSource source;
    private MusicBG bg;

    public bool isTitle;
    public float wait;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        bg = GameObject.FindGameObjectWithTag("Music").GetComponent<MusicBG>();
        bg.TrackOne();
    }

    private void Update()
    {
        if (isTitle == true) {
            if (wait <= 0)
            {
                LoadMenu();
            }
            else {
                wait -= Time.deltaTime;
            }
        }
    }

    void LoadMenu() {
        whitePanel.SetTrigger("fadeIn");
        StartCoroutine(PlayMenu());
    }

    public void SetSmallRatio() {
        source.Play();
        Screen.SetResolution(960, 600, false);
    }
    public void SetBigRatio()
    {
        source.Play();
        Screen.SetResolution(1600, 900, false);
    }

    public void Play()
    {
        source.Play();
        whitePanel.SetTrigger("fadeIn");
        StartCoroutine(PlayRules());
    }

    public void PlayTwo() {
        source.Play();
        whitePanel.SetTrigger("fadeIn");
        StartCoroutine(PlayGame());
    }

    IEnumerator PlayMenu()
    {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator PlayGame()
    {

        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("Game");
    }


    IEnumerator PlayRules() {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("Rules");
    }
}
