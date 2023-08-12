using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public GameObject toast;
    public GameObject FriedEgg;

    public string cookedFood = "";

   
    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        FriedEgg.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ToastBread()
    {
        toast.SetActive(true);
        cookedFood = "toast";
    }


    public void CleanStove()
    {
        toast.SetActive(false);
        cookedFood = "";
        FriedEgg.SetActive(false);
        cookedFood = "";
    }

    public void FryEgg()
    {
        FriedEgg.SetActive(true);
        cookedFood = "FriedEgg";
    }
}
