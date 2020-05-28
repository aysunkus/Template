using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject Coin;
    public Vector3 randomPos;

    void Start()
    {
        InvokeRepeating("CreateNewCoin", 2, 1);
    }

    public void StopSpawn()
    {
        CancelInvoke("CreateNewCoin");
    }

    void CreateNewCoin()
    {
        Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
        vec += transform.position;
        Instantiate(Coin, vec, Quaternion.identity);
    }
}