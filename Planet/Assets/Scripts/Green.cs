using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour {


    public SpriteRenderer rend;
    public Sprite[] sprites;

    private void Start()
    {
        int rand = Random.Range(0, sprites.Length);
        rend.sprite = sprites[rand];
    }

}
