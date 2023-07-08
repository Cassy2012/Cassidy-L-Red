using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove = 40;

    
    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = startingPosition + new Vector3(distanceToMove,0, 0);
            

       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (direction * speed * Time.deltaTime * +, 0, 0); 
        if (transform.position.x < startingPosition.x)
        {
            direction = 1;
        }

        if(transform.position.x > endingPosition.x)
        {
            direction = -1;
        }
      
    }
}
