using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public bool canSpawn = true;

    public int modifyXPosition;
    public int modifyZPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))  
        {

            canSpawn = true;
                GameObject chosenPowerupClone = Instantiate(chosenPowerup, new Vector3(transform.position.x + modifyXPosition , transform.position.y, transform.position.z + modifyZPosition ), transform.rotation);
            
            print("Powerup");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
