using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class donationCollision : MonoBehaviour
{


    void Start()
    {
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "Coin") {

            // collision function
            
        }
    }
}
        
