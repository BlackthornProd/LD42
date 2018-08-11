using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
