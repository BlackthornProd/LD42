using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
       
    }

    private void OnMouseOver()
    {
        

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.eulerAngles = new Vector3(0, 0, 90);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.eulerAngles = new Vector3(0, 0, -90);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)){
            transform.eulerAngles = new Vector3(0, 0, -180);
        }
    }

    private void OnMouseEnter()
    {
        anim.SetBool("isOver", true);
    }

    private void OnMouseExit()
    {
        Debug.Log("exit");
        anim.SetBool("isOver", false);
    }
}
