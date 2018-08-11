using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour {

    private Animator camAnim;
    private GM gm;
    public int dangerPlanet;
    private Animator anim;
    public GameObject destroyEffect;
    public GameObject explosion;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        anim = GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();

        gm.danger += dangerPlanet;
    }

    private void OnMouseOver()
    {
        anim.SetBool("isOver", true);

        if (gm.isDestroy == true) {
            if (Input.GetMouseButtonDown(0)) {
                camAnim.SetTrigger("shake");
                gm.isDestroy = false;
                DestroyWorldObject();
            }
        }

        if (gm.buildingSelected != 0 && Input.GetMouseButtonDown(0)) {
            for (int i = 0; i < gm.buildings.Length; i++)
            {
                if (i == gm.buildingSelected) {
                    Instantiate(gm.buildings[i], transform.position, transform.rotation);
                    gm.buildingSelected = 0;
                    DestroyWorldObject();
                }
            }
        }
    }

    void DestroyWorldObject() {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnMouseExit()
    {
        anim.SetBool("isOver", false);
    }
}
