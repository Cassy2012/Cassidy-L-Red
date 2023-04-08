using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public int ThrowableCounter;
    public GameObject anything;
    public Vector3 offset;
    private AnimateMovement AM;
    public Text collectableCounter;
    public Text ThrowingObjectText;


    // Start is called before the first frame update
    void Start()
    {
        AM = GetComponent<AnimateMovement>();

        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ThrowableCounter >0)
        {
            ThrowableCounter--;
            collectableCounter.text = ThrowableCounter.ToString();
           GameObject clone;

            


            if (AM.facingRight)
            {
                //If the avatar is facing right and it's true, throw the shuriken in the right
                //clone = Instantiate()

                clone = Instantiate(anything, new Vector3(transform.position.x + 2, transform.position.y, 0.0f), transform.rotation);
                
            }

            if (AM.facingLeft)
            {
                //If the avatar is facing left and it's true, throw the shuriken in the left


                clone = Instantiate(anything, new Vector3(transform.position.x - 2, transform.position.y, 0.0f ), transform.rotation);
            }
            

        }
       
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Collectable")
        {
            ThrowableCounter++;
            collectableCounter.text = ThrowableCounter.ToString();
            Destroy(collider.gameObject);


        }
     
    }

}








    





