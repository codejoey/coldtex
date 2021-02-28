using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class handshow : MonoBehaviour
{
    public float rotation = 90f;
    void Start()
    {
        // start script for invisible hands and dollars:
        // gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    // enable gravity for dollars but not hands

    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "dollar") {
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
            
                if (obj.name == "dollar1") {
                    obj.GetComponent<MeshRenderer>().enabled = true;
                }
                if (obj.name == "hand1") {
                    obj.GetComponent<MeshRenderer>().enabled = true;
                    yield return new WaitForSeconds(3); // wait 3 seconds
                    obj.Rotate (0, rotation, 0);
                }
            }
       }
   }
}
