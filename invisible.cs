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
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
