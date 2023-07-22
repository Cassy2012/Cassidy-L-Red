using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;
    // Start is called before the first frame update

    public void RemoveLife()
    {
        lives -= 1;

        hearts[lives].SetActive(false);
        print("You lost a LifE! Lives: " + lives);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
