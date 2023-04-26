using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        //Rotate the object on the x axis 
        transform.Rotate(Vector3.down, Time.deltaTime * 70f);
    }
}
