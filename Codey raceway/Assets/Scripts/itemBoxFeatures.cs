using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }


    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
