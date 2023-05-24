using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissappearDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward * Time.deltaTime * 5;
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
