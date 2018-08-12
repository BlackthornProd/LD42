using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour {

    public Animator anim;

    private void Start()
    {
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame() {
        yield return new WaitForSeconds(10f);
        anim.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu");
    }
}
