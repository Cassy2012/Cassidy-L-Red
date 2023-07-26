using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{

    [Header("Lives")]
    public livesManager livesManager;



    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Quaternion originalRotation;
    public Vector3 originalPosition;
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
        originalPosition = slimeTransform.position;
        originalRotation = slimeTransform.rotation;
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
            slimeTransform.position = originalPosition - launchVector / 400;
            launchVector.Normalize();
        }


        if (Input.GetMouseButtonUp(0))
        {   
            slimeRigidbody.isKinematic = false;
           // launchVector = new Vector3(xForce,yForce,zForce);
           slimeRigidbody.AddForce(launchVector * 40,ForceMode.VelocityChange);

            print("Release");
        }

        if (Input.GetMouseButtonDown(1)) 
        {
            slimeTransform.position = originalPosition;
            slimeTransform.rotation = originalRotation;

            slimeRigidbody.isKinematic = true;

        }

      //  if (slimeTransform.position.y < 4)
      //  {
          //  livesManager.RemoveLife();
      //  }

        if(livesManager.Lives < 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition; 
            livesManager.RemoveLife();
        }

        if (Input.GetMouseButton(0))
        {
            
        }

    }
}
