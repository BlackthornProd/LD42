using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

    public int gold = 100;

    public Text goldDisplay;
    public Image cursorImg;
    public Sprite normalCursor;
    public Sprite destroyCursor;
    public Sprite[] cursors;

    public bool isDestroy;

    public int buildingSelected;
    public int[] prices;
    public GameObject[] buildings;

    public int danger;

    public SpriteRenderer planetFace;
    public Sprite[] planetFaces;
    private int planetIndex;
    public Animator planetAnim;
    bool once;

    public GameObject finalExplosion;
    public GameObject finalExplosionTwo;
    public Animator fadePanel;
    public GameObject theEnd;

    private MusicBG bg;

    private void Start()
    {
        bg = GameObject.FindGameObjectWithTag("Music").GetComponent<MusicBG>();
    }

    private void Update()
    {

        if (danger < 100) {
            planetIndex = 0;
        } else if (danger >= 100 && danger < 200 && once == false) {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 1;
        } else if (danger >= 200 && danger < 400 && once == true) {
            planetAnim.SetTrigger("hurt");
            once = false;
            planetIndex = 2;
        }
        else if (danger >= 400 && danger < 600 && once == false)
        {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 3;
            bg.TrackTwo();
        }
        else if (danger >= 600 && danger < 800 && once == true)
        {
            planetAnim.SetTrigger("hurt");
            once = false;
            planetIndex = 4;
        }
        else if (danger >= 800 && danger < 900 && once == false)
        {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 5;
        }
        else if (danger >= 900 && danger < 1100 && once == true)
        {
            planetAnim.SetTrigger("hurt");
            once = false;
            planetIndex = 6;
            bg.TrackThree();
        }
        else if (danger >= 1100 && danger < 1200 && once == false)
        {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 7;
        }
        else if (danger >= 1200 && danger < 1400 && once == true)
        {
            planetAnim.SetTrigger("hurt");
            once = false;
            planetIndex = 8;
        }
        else if (danger >= 1400 && danger < 1600 && once == false)
        {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 9;
        }
        else if (danger >= 1600 && danger < 1800 && once == true)
        {
            planetAnim.SetTrigger("hurt");
            once = false;
            planetIndex = 10;
            bg.TrackFour();
        }
        else if (danger >= 1800 && danger < 2000 && once == false)
        {
            planetAnim.SetTrigger("hurt");
            once = true;
            planetIndex = 11;
        }
        if (danger >= 2000 && once == true) {

            if (once == true) {
                bg.DeathMusic();
                Death();
            }

        }

        planetFace.sprite = planetFaces[planetIndex];

        Debug.Log("DANGER " + danger);
        if (danger < 2000) {
            goldDisplay.text = gold.ToString();
        }


        if (buildingSelected != 0)
        {
            cursorImg.sprite = cursors[buildingSelected];
        }
        else {
            cursorImg.sprite = normalCursor;
        }
    }

    void Death() {
        theEnd.SetActive(true);

        gold = 0;
        goldDisplay.text = "???";
        planetIndex = 12;
        // Instantiate(finalExplosion, transform.position, Quaternion.identity);
        Instantiate(finalExplosionTwo, transform.position, Quaternion.identity);

        once = false;
    }

    public void Build(int buildIndex) {

        if (buildingSelected == 0) {
            if (gold >= prices[buildIndex])
            {

                gold -= prices[buildIndex];
                buildingSelected = buildIndex;
            }
        }
    }

    public void BackToMenu() {
        StartCoroutine(Finish());
    }

    IEnumerator Finish() {
        fadePanel.SetTrigger("fadeIn");
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("MainMenu");
    }

    public void DestroySmt() {
        isDestroy = true;
    }
}
