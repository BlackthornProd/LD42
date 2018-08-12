using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rays : MonoBehaviour {


    public GM gm;
    private Image img;
    public Color[] bgColors;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    private void Update()
    {

        if (gm.danger < 100)
        {
            img.color = bgColors[0];
        }
        else if (gm.danger >= 100 && gm.danger < 200)
        {
            img.color = bgColors[1];
        }
        else if (gm.danger >= 200 && gm.danger < 400)
        {
            img.color = bgColors[2];
        }
        else if (gm.danger >= 400 && gm.danger < 600)
        {
            img.color = bgColors[3];
        }
        else if (gm.danger >= 600 && gm.danger < 800)
        {
            img.color = bgColors[4];
        }
        else if (gm.danger >= 800 && gm.danger < 900)
        {
            img.color = bgColors[5];

        }
        else if (gm.danger >= 900 && gm.danger < 1100)
        {
            img.color = bgColors[6];
        }
        else if (gm.danger >= 1100 && gm.danger < 1200)
        {
            img.color = bgColors[7];
        }
        else if (gm.danger >= 1200 && gm.danger < 1400)
        {
            img.color = bgColors[8];
        }
        else if (gm.danger >= 1400 && gm.danger < 1600)
        {
            img.color = bgColors[9];
        }
        else if (gm.danger >= 1600 && gm.danger < 1800)
        {
            img.color = bgColors[10];
        }
        else if (gm.danger >= 2000)
        {
            img.color = bgColors[11];
        }
    }

}

