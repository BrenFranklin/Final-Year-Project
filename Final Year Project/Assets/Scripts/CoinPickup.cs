using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int rotateSpeed;
    //Add sound
    //public AudioSource collectCoin;
    public GameObject Coin;
    
    void Update()
    {
        rotateSpeed = 2;
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        //collectCoin.Play();
        Destroy(Coin);
    }
}
