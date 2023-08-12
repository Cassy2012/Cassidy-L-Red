using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject ToastSlice;
    public GameObject Toast;
    public Stove stove;

    
    public string triggerName = "";

    public GameObject breadPrefab;
    public GameObject eggPrefab;
    public GameObject FriedEggPrefab;

    public GameObject heldItem;
    public string heldItemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Bread")
            {
                PickUpItem(breadPrefab, "breadSlice");
              
            }


            if(triggerName == "eGG")
            {
                PickUpItem(eggPrefab, "egg");
            }


            if (triggerName == "Stove")
            {

                if (heldItemName == "breadSlice")
                {
                    stove.ToastBread();
                    PlaceHeldItem();
                }
                else
                {
                    if (heldItemName == "egg")
                    {
                        stove.FryEgg();
                        PlaceHeldItem();
                    }


                    else
                    {

                        if (stove.cookedFood == "FriedEgg")
                        {
                            
                            PickUpItem(FriedEggPrefab, "FriedEgg");
                            stove.CleanStove();
                            heldItem.transform.localScale = new Vector3(4, 4, 7);
                        }

                        if (stove.cookedFood == "toast")
                        {
                            PickUpItem(breadPrefab, "toastSlice");
                            stove.CleanStove();
                        }
                    }
                }
            }


            if (triggerName == "Receivers")
            {
                if(heldItemName == "toastSlice")
                {
                    PlaceHeldItem();
                    GameObject.Find("Receivers/The Bread/ToastSlice").SetActive(true);
                }

                if(heldItemName == "FriedEgg")
                {
                    PlaceHeldItem();
                    GameObject.Find("Receivers/The Bread/friedEgg").SetActive(true);
                }
            }
        }
    }


    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }


    private void PickUpItem(GameObject itemPrefab, string itemName)
    {
        heldItem = Instantiate(itemPrefab, transform, false);
        heldItem.transform.localPosition = new Vector3(0, 2, 2);
        heldItemName = itemName;
    }
}
