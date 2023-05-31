using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerrsCountdown : MonoBehaviour
{
    public Text laptime;
    public Text startCountdown;


    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove Speed;
    void Update()
    {

        if (totalCountdownTime >= 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Speed.Speed = 0;
        }

        if(totalCountdownTime <= 0)
        {
            startCountdown.text = ("");
            totalLapTime -= Time.deltaTime;

            laptime.text = Mathf.Round(totalLapTime).ToString();
            Speed.Speed = 700;
        }

        if (totalLapTime < 0)
        {
            print("Time is up!");
            SceneManager.LoadScene(1);
        }

    }
}
