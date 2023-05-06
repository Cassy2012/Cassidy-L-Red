using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public bool canSpawn = false;

    public int modifyXPosition;
    public int modifyZPosition;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canSpawn)
        {

            Debug.Log("Powerup");
            canSpawn = false;
            GameObject chosenPowerupClone = Instantiate(chosenPowerup, new Vector3(transform.position.x + modifyXPosition , transform.position.y, transform.position.z + modifyZPosition ), transform.rotation);
            
            print("Powerup");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            print("PickedUp");
            canSpawn = true;
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
