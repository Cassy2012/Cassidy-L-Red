using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float maximumXPosition;
    public float minimumXPosition;
    public Teleport TP;

    private Rigidbody2D enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition)
        {
            speed = speed * -1;
        }
        if (transform.position.x >= maximumXPosition)
        {
            speed = speed * -1;
        }
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            TP.enemyCount--;
            Debug.Log(TP.enemyCount);
        }
       
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

       
        
    }


}
