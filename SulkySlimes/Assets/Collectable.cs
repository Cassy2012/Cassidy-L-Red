using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    
    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public Transform SphereTransform;
    public Transform SphereValue;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = SphereTransform.position;
        endingPosition = SphereValue.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
