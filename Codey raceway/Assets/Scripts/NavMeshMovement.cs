using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal ;
    private GameObject[] targets;

    Animator animator;

    private NavMeshAgent Agent;
    // Start is called before the first frame update
     private void Start()
    {
        GameObject.FindGameObjectWithTag("Objects");
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        GetComponent<NavMeshAgent>().SetDestination(goal.transform.position);
        targets = GameObject.FindGameObjectsWithTag("Objects");

        goal = GameObject.FindGameObjectWithTag("Objects").transform; 
        foreach(GameObject target in targets)
        {
            if (Vector3.Distance(target.transform.position, transform.position) < Vector3.Distance(goal.position, transform.position))
            {
                goal = target.transform;
            }
        }

        
        

        Agent.destination = goal.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        //Agent = GetComponent<NavMeshAgent>();
        //Agent.destination = goal.transform.position;

        //GetComponent<NavMeshAgent>().SetDestination(goal.transform.position);
        //goal = GameObject.FindGameObjectWithTag("testNav").transform;

        //Agent.destination = goal.transform.position;
        //Debug.Log(Agent.destination);



        // transform.position += transform.forward * Time.deltaTime * 10;
        // animator = GetComponentInChildren<Animator>();

        // Debug.Log(transform.position);
        // Agent.SetDestination (goal.position);

    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Objects")
        {
            Destroy(other.gameObject);
        }
    }
}
