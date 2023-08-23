using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{

    [Header("Prefabs")]
    public GameObject toast;
    public GameObject FriedEgg;
    public GameObject SteAk;
    public GameObject BuN;
    public GameObject SausagE;

    [Header("Inventory")]
    public string cookedFood = "";
    public bool isCooking = false;


    [Header("Particles")]
    public ParticleSystem Smoke;
    public ParticleSystem Complete;

   
    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        Smoke.Stop();

        FriedEgg.SetActive(false);

        SteAk.SetActive(false);

        BuN.SetActive(false);

        SausagE.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ToastBread()
    {
        isCooking = true;
        Smoke.Play();
        toast.SetActive(true);
        cookedFood = "toast";
        //Invoke("CompleteCooking", 6f);
    }


    public void CleanStove()
    {
        toast.SetActive(false);
        cookedFood = "";
        FriedEgg.SetActive(false);
        cookedFood = "";
        SteAk.SetActive(false);
        cookedFood = "";
        BuN.SetActive(false);
        cookedFood = "";
        SausagE.SetActive(false);
        cookedFood = "";
        Smoke.Stop();
        Complete.Stop();

      
    }

    public void FryEgg()
    {
        isCooking = true;
        Smoke.Play();
        FriedEgg.SetActive(true);
        cookedFood = "FriedEgg";
       // Invoke("CompleteCooking", 8f);
    }


    private void CompleteCooking()
    {
        isCooking = false;
        Smoke.Stop();
        Complete.Play();
    }

    public void Steaks()
    {
        isCooking = true;
        Smoke.Play();
      SteAk.SetActive(true);
        cookedFood = "CookedSteak";
    }

    public void BUN()
    {
        isCooking = true;
        Smoke.Play();
        BuN.SetActive(true);
        cookedFood = "bUN";
       
    }


    public void SausaGE()
    {
        isCooking = true;
        Smoke.Play();
        SausagE.SetActive(true);
        cookedFood = "sAusage";
    }
}
