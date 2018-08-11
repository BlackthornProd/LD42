using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private void Update()
    {

        if (danger < 100) {
            planetIndex = 0;
        } else if (danger >= 100 && danger <= 200) {
            if (once == false) {
                planetAnim.SetTrigger("hurt");
                once = true;
            }
            planetIndex = 1;
        }

        planetFace.sprite = planetFaces[planetIndex];

        Debug.Log("DANGER " + danger);
        goldDisplay.text = gold.ToString();

        if (buildingSelected != 0)
        {
            cursorImg.sprite = cursors[buildingSelected];
        }
        else {
            cursorImg.sprite = normalCursor;
        }
    }

    public void Build(int buildIndex) {
        if (gold >= prices[buildIndex]) {
            gold -= prices[buildIndex];
            buildingSelected = buildIndex;
        }
      
    }

    public void DestroySmt() {
        isDestroy = true;
    }
}
