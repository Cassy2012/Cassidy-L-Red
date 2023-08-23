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
    public GameObject SteakPrefab;
    public GameObject CookedSteakPrefab;
    public GameObject BunPrefab;
    public GameObject bUNPrefab;
    public GameObject SausagePrefab;
    public GameObject SAusagePrefab;

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


            if(triggerName == "Steak")
            {
                PickUpItem(SteakPrefab, "Steak");
            }

            
            if(triggerName == "Bun")
            {
                PickUpItem(BunPrefab, "Bun");
            }

            if(triggerName == "Sausage")
            {
                PickUpItem(SausagePrefab, "Sausage");
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
                        if (heldItemName == "Steak")
                        {
                            stove.Steaks();
                            PlaceHeldItem();
                        }
                        else
                        {
                            if(heldItemName == "Sausage")
                            {
                                stove.SausaGE();
                                PlaceHeldItem();
                            }
                            else
                            {

                            

                            if (heldItemName == "Bun")
                            {
                                stove.BUN();
                                PlaceHeldItem();
                            }
                            else
                            {
                                if(stove.cookedFood == "sAusage")
                                {
                                    if(stove.isCooking == false)
                                    {
                                        PickUpItem(SAusagePrefab, "SausagE");
                                        stove.CleanStove();
                                        heldItem.transform.localScale = new Vector3(4, 4, 7);
                                    }
                                        else
                                        {
                                            stove.Invoke("CompleteCooking", 2f);
                                        }
                                }

                            




                            else
                            {
                                        if (stove.cookedFood == "bUN")
                                        {
                                            if (stove.isCooking == false)
                                            {
                                                PickUpItem(bUNPrefab, "BuN");
                                                stove.CleanStove();
                                                heldItem.transform.localScale = new Vector3(4, 4, 7);
                                            }
                                            else
                                            {
                                                stove.Invoke("CompleteCooking", 2f);
                                            }
                                        }





                                        else
                                        {
                                            if (stove.cookedFood == "CookedSteak")
                                            {
                                                if (stove.isCooking == false)
                                                {
                                                    PickUpItem(CookedSteakPrefab, "SteAk");
                                                    stove.CleanStove();
                                                    heldItem.transform.localScale = new Vector3(4, 4, 7);
                                                }
                                                else
                                                {
                                                    stove.Invoke("CompleteCooking", 3f);
                                                }
                                            }




                                            else
                                            {

                                                if (stove.cookedFood == "FriedEgg")
                                                {
                                                    if (stove.isCooking == false)
                                                    {
                                                        PickUpItem(FriedEggPrefab, "FriedEgg");
                                                        stove.CleanStove();
                                                        heldItem.transform.localScale = new Vector3(4, 4, 7);
                                                    }
                                                    else
                                                    {
                                                        stove.Invoke("CompleteCooking", 6f);

                                                    }


                                                }

                                                if (stove.cookedFood == "toast")
                                                {
                                                    if (stove.isCooking == false)
                                                    {
                                                        PickUpItem(breadPrefab, "toastSlice");
                                                        stove.CleanStove();
                                                    }
                                                    else
                                                    {
                                                        stove.Invoke("CompleteCooking", 4f);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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


                if(heldItemName == "SteAk")
                {
                    PlaceHeldItem();
                    GameObject.Find("Receivers/The Steak/SteaK").SetActive(true);
                }

                if(heldItemName == "BuN")
                {
                    PlaceHeldItem();
                    GameObject.Find("Receivers/The Bun/Bun9").SetActive(true);
                }

                if(heldItemName == "SausagE")
                {
                    PlaceHeldItem();
                    GameObject.Find("Receivers/The Bun/sausage9").SetActive(true);
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
