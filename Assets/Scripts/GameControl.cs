using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject Coin;
    public Vector3 randomPos;

    void Start()
    {
        //StartCoroutine(olustur());
        InvokeRepeating("CreateNewCoin", 2, 1);
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 120; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Coin, vec, Quaternion.identity);
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(2);
        }
    }

    public void StopSpawn()
    {
        CancelInvoke("CreateNewCoin");
    }

    void CreateNewCoin()
    {
        Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
        Instantiate(Coin, vec, Quaternion.identity);
    }
}