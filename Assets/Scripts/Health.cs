using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Start()
    {
        GetHealthVal();
        CheckHealth();
    }

    void CheckHealth()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        SaveHealth();
    }

    public void GetHealth()
    {
        if (health > numOfHearts)
            return;

        health++;
        CheckHealth();
    }

    public void LoseHealth()
    {
        if (health < 0)
            return;

        health--;
        CheckHealth();
    }

    public void SaveHealth()
    {
        PlayerPrefs.SetInt("Health", health);
    }

    public void GetHealthVal()
    {
        health = PlayerPrefs.GetInt("Health", 3);
    }
}