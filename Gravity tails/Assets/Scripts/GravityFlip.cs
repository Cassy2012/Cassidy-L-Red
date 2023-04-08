using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1f;
            Vector3 newDirection = transform.localScale;
            Vector3 thisScale = transform.localScale;

            if (thisScale.y > 0)
            {
                thisScale.y = -1;
            }
            else if (thisScale.y < 0)
            {
                thisScale.y = 1;
            }
           
            transform.localScale = thisScale;

          

            newDirection.y *= 1;
        }
    }
}
