using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerrsCountdown : MonoBehaviour
{
    public Text laptime;
    public Text startCountdown;


    public float totalLapTime;
    public float totalCountdownTime;
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        laptime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
