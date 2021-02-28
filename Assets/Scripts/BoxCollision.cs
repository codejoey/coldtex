using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class shoppingCartCollision : MonoBehaviour
{
    public Material doomSky;
    SpriteRenderer renderReference;
    private deteriorate deter;
    private changeSkybox csky;
    private System.Random rand;
    private float skyAmt;

    void Start()
    {
        deter = GameObject.Find("/Scripts").GetComponent<deteriorate>();
        csky = GameObject.Find("/Scripts").GetComponent<changeSkybox>();
        rand = new System.Random();
        skyAmt = 0.15f;
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "Meat") {

            // get those trees
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
                if (obj.name == "Tree") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            child.gameObject.name == "Trunk" ? 0.25f : (float)rand.NextDouble(),
                            (float)rand.NextDouble() * 2f + 1f,
                            child.gameObject.name == "Trunk" ? 0 : (child.gameObject.name == "Fruits" ? 3 : 1),
                            1f - (float)rand.NextDouble() * .5f
                        ));
                    };
                }
                if (obj.name == "Grass" || obj.name == "Flower") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            0.10f,
                            (float)rand.NextDouble(),
                            1,
                            0.9f
                        ));
                    };
                }
            }

            // bye water
            deter.StartCoroutine(deter.Deter(
                GameObject.Find("Water"),
                0.4f,
                (float)rand.NextDouble(),
                1, 1f - (float)rand.NextDouble() * .5f
            ));


            // dooming sky
            csky.StartCoroutine(csky.sky(doomSky, 8.0f, skyAmt));
            skyAmt += 0.15f;
        }
		else if (collision.gameObject.name == "Plastic") {
            UnityEngine.Debug.Log("Plastic");
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
                if (obj.name == "Tree") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            child.gameObject.name == "Trunk" ? 0.25f : 0.9f,
                            (float)rand.NextDouble(),
                            child.gameObject.name == "Trunk" ? 0 : 1,
                            1f - (float)rand.NextDouble() * .5f
                        ));
                    };
                }
            }

            // some trash
            foreach(Transform child in GameObject.Find("Trash1").GetComponentsInChildren<Transform>()) {
                deter.StartCoroutine(deter.Heal(
                    child.gameObject,
                    0.5f, 0.5f, new Color(0,0,0,0)
                ));
            };

            foreach(Transform child in GameObject.Find("Trash2").GetComponentsInChildren<Transform>()) {
                deter.StartCoroutine(deter.Heal(
                    child.gameObject,
                    0.5f, 0.5f, new Color(0,0,0,0)
                ));
            };


            // dooming sky
            csky.StartCoroutine(csky.sky(doomSky, 8.0f, skyAmt));
            skyAmt += 0.15f;
        }
        else if (collision.gameObject.name == "Paper") {
            UnityEngine.Debug.Log("Paper");
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
                if (obj.name == "Tree") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            child.gameObject.name == "Trunk" ? 0.25f : 2f,
                            (float)rand.NextDouble() * 2f + 2f,
                            child.gameObject.name == "Trunk" ? 0 : 3,
                            1f - (float)rand.NextDouble() * .5f
                        ));
                    };
                }
                if (obj.name == "Bush") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            0.15f,
                            (float)rand.NextDouble(),
                            1, 1f
                        ));
                    };
                }
            }


            // dooming sky
            csky.StartCoroutine(csky.sky(doomSky, 8.0f, skyAmt));
            skyAmt += 0.15f;
        }
    }
}
