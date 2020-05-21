using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public bool pauseMenuOpen;

    void Start()
    {
        pauseMenuOpen = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //pauseMenuOpen = !pauseMenuOpen;
        }

        if (pauseMenuOpen)
        {
            pause.SetActive(true);
        }
        else
        {
            pause.SetActive(false);
        }
    }
}
