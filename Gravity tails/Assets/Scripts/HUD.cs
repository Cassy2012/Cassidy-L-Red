using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{

    public Text ThrowingObjectText;

    public int currentScore;

    public int NoScore;

    // Start is called before the first frame update
    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score) 
    {
        ThrowingObjectText.text = score.ToString();
    }

    
}
