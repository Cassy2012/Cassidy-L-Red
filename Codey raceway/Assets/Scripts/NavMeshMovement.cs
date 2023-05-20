using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal ;

    Animator animator;

    private NavMeshAgent Agent;
    // Start is called before the first frame update
     private void Start()
    {
        GameObject.FindGameObjectsWithTag("Objects");
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        GetComponent<NavMeshAgent>().SetDestination(goal.transform.position);
        goal = GameObject.FindGameObjectWithTag("Objects").transform;
        Agent = GetComponent<NavMeshAgent>();

        Agent.destination = goal.transform.position;
        Debug.Log(Agent.destination);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.forward * Time.deltaTime * 10;
       // animator = GetComponentInChildren<Animator>();
        //Agent = GetComponent<NavMeshAgent>();
       // Debug.Log(transform.position);
       // Agent.SetDestination (goal.position);
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Objects")
        {
            Destroy(gameObject);
        }
    }
}
