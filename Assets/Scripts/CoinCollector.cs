using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public int toplananCoinSayisi;

    public Text text;

    void OnTriggerEnter(Collider other)
    {
        toplananCoinSayisi++;

        other.gameObject.SetActive(false);

        text.text = "Point:  " + toplananCoinSayisi.ToString();
        //Destroy(other.gameObject); siliyor
        //Debug.Log("TEMAS OLDU");
        // sayac++;
        //
        // sayacText.text = "Sayac = " + sayac;
        //
        // if (sayac == Coin)
        // {
        //     gameOverPanel.SetActive(true);
        // }
    }


    void Start()
    {

    }

    void Update()
    {

    }
}
