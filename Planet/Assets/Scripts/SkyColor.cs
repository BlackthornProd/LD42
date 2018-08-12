using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColor : MonoBehaviour {

    public GM gm;
    private Camera cam;
    private Animator anim;
    public Animator planet;

    public Color[] bgColors;

    private void Start()
    {
        anim = GetComponent<Animator>();
        cam = GetComponent<Camera>();
    }

    private void Update()
    {

        if (gm.danger >= 2000) {
            anim.SetBool("isDead", true);
            planet.SetBool("isDead", true);
        }

        if (gm.danger < 100)
        {
            cam.backgroundColor = bgColors[0];
        }
        else if (gm.danger >= 100 && gm.danger < 200)
        {
            cam.backgroundColor = bgColors[1];
        }
        else if (gm.danger >= 200 && gm.danger < 400)
        {
            cam.backgroundColor = bgColors[2];
        }
        else if (gm.danger >= 400 && gm.danger < 600)
        {
            cam.backgroundColor = bgColors[3];
        }
        else if (gm.danger >= 600 && gm.danger < 800)
        {
            cam.backgroundColor = bgColors[4];
        }
        else if (gm.danger >= 800 && gm.danger < 900)
        {
            cam.backgroundColor = bgColors[5];

        }
        else if (gm.danger >= 900 && gm.danger < 1100)
        {
            cam.backgroundColor = bgColors[6];
        }
        else if (gm.danger >= 1100 && gm.danger < 1200)
        {
            cam.backgroundColor = bgColors[7];
        }
        else if (gm.danger >= 1200 && gm.danger < 1400)
        {
            cam.backgroundColor = bgColors[8];
        }
        else if (gm.danger >= 1400 && gm.danger < 1600)
        {
            cam.backgroundColor = bgColors[9];
        }
        else if (gm.danger >= 1600 && gm.danger < 1800)
        {
            cam.backgroundColor = bgColors[10];
        }
        else if (gm.danger >= 2000)
        {
            cam.backgroundColor = bgColors[11];
        }
    }

}
