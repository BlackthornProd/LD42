using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public WorldObject[] green;
    public Transform pos;

    private void Start()
    {
        int rand = Random.Range(0, green.Length);
        WorldObject instance = (WorldObject)Instantiate(green[rand], pos.position, transform.rotation);
        
    }
}
