using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Player;
    Vector3 aradakiMesafe;

    void Start()
    {
        aradakiMesafe = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + aradakiMesafe;
    }
}
