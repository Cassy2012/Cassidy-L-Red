using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    // A longer example of Vector3.Lerp usage.
    // Drop this script under an object in your scene, and specify 2 other objects in the "startMarker"/"endMarker" variables in the script inspector window.
    // At play time, the script will move the object along a path between the position of those two markers.
    
        // Transforms to act as start and end markers for the journey.
        public Transform startMarker;
        public Transform endMarker;

    // Movement speed in units per second.
    public float speed = 1.0F;

        // Time when the movement started.
        private float startTime;

        // Total distance between the markers.
        private float journeyLength;


    public AnimationCurve curve;
    public float time;
 

        void Start()
        {
            // Keep a note of the time the movement started.
            startTime = Time.time;

            // Calculate the journey length.
            journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        }

        // Move to the target end position.
        void Update()
        {
            // Distance moved equals elapsed time times speed..
            float distCovered = (Time.time - startTime) * speed;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        //transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
        time += Time.deltaTime;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, curve.Evaluate(time));
        
         //transform.position = Vector3.Lerp(endMarker.position, startMarker.position, fractionOfJourney);

    }
}
