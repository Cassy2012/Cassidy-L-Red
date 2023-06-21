using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;
    public float xForce;
    public float yForce;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;


    private void Start()
    {
        //slimeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;

        }


        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDiffrence = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDiffrence.x * 1f,
                mouseDiffrence.y * 1.2f,
                mouseDiffrence.y * 1.5f
                );
            launchVector.Normalize();
        }


        if (Input.GetMouseButtonUp(0))
        {   
            slimeRigidbody.isKinematic = false;
            launchVector = new Vector2(yForce,xForce);
            slimeRigidbody.AddForce(launchVector);

            print("Release");
        }
    }
}
