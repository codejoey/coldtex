using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donationcollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "100dol") {

            // collision function

        }
	if (collision.gameObject.name == "10000dol") {

            // collision function

        }
	if (collision.gameObject.name == "clock") {

            // collision function

        }
	if (collision.gameObject.name == "Hambuger") {

            GetComponent<Renderer>().material.color = Color.green;

        }
    }
}
