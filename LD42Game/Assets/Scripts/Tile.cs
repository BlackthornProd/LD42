using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    bool isEmpty = true;

    public GameObject turret;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (isEmpty == true) {
                Instantiate(turret, transform.position, Quaternion.identity);
                isEmpty = false;
            }
        }
    }
}
