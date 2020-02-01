using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnZone : MonoBehaviour
{
    public Transform Spawn_pos;
    public GameObject Spawnee;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(Spawnee, Spawn_pos.position, Spawn_pos.rotation);
        }
    }
}
