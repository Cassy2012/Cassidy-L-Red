using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class livesManager : MonoBehaviour
{
    public int Lives;
    public GameObject[] hearts;
    // Start is called before the first frame update

    public void RemoveLife()
    {

        Lives -= 1;

        hearts[Lives].SetActive(false);
        print("You lost a LifE! Lives: " + Lives);
        
    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives == -1)
        {
            SceneManager.LoadScene(0);
        }
    }
}
