using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public AnimateMovement direction;
    public float speed;
    private Rigidbody2D RB;
   // public Teleport TP;
    //private AnimateMovement AM;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<AnimateMovement>();
        //AM = GetComponent<>();
        if (direction.facingRight)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.right * Time.deltaTime * speed;
        }

        if (direction.facingLeft)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.left * Time.deltaTime * speed;
        }
        //TP.enemyCount = 4;
        //Debug.Log("Projectile, (TP.enemyCount):" + TP.enemyCount);
    }

    // Update is called once per frame
    void Update()
    {
       
        
        

        //transform.position += direction.offset * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            Destroy(collider.gameObject);
            Invoke("DestroyThrowable", 2);
            //P.enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            //Debug.Log("Projectile, (TP.enemyCount):" + TP.enemyCount);
           // TP.enemyCount--;
   
        }
    }


    private void DestroyThrowable()
    {

        Destroy(gameObject);




    }

}
