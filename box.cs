using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class box : MonoBehaviour
{
    public float rotation = 90f;
    void Start()
    {

    }
    // enable gravity for dollars but not hands

    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "dollar") { // visible dollar
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
            
                if (obj.name == "dollar1") { // invisible dollar
                    obj.GetComponent<MeshRenderer>().enabled = true;
                }
                if (obj.name == "hand1") { // invisible hand
                    obj.GetComponent<MeshRenderer>().enabled = true;
                    yield return new WaitForSeconds(3); // wait 3 seconds
                    obj.Rotate (0, rotation, 0);
                }
            }
       }
   }
}
