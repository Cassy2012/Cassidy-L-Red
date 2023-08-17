using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    public Text LapTime;


    public float totalLapTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        totalLapTime -= Time.deltaTime;

        LapTime.text = Mathf.Round(totalLapTime).ToString();


        if(totalLapTime < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
