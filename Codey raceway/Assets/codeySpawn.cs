using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisonEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Terrain")
        {
            Destroy(gameObject);
        }
    }

}
