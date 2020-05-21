using System;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool paused = false;

    void Update()
    {
        if (Input.GetButtonDown("pauseButton"))
            paused = TogglePause();
    }

    bool TogglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}