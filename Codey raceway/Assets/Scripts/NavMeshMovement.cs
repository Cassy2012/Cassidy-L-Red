using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal ;

    Animator animator;

    NavMeshAgent Agent;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject.FindGameObjectWithTag("Objects").transform;


    }

    // Update is called once per frame
    void Update()
    {
        
        //  transform.position += transform.forward * Time.deltaTime * 10;
        animator = GetComponentInChildren<Animator>();
        Agent = GetComponent<NavMeshAgent>();
        Agent.destination = goal.position;

    }
}
