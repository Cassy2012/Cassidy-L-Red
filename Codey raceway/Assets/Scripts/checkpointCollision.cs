using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckpointCounter count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        didCollide = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && didCollide == false)
        {
            didCollide = true;
            count.triggeredCheckpoints++;
        }
    }
}
