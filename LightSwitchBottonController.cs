using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchBottonController : MonoBehaviour
{
    // Sound
    private AudioSource source;
    public AudioClip buttonSound;

    private bool lightsOn = true;
    private bool buttonHit = false;
    private GameObject button;

    public Light light1, light2, light3, light4, light5, light6, light7;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();

        button = transform.GetChild(0).gameObject;

        light1.enabled = true;
        light2.enabled = true;
        light3.enabled = true;
        light4.enabled = true;
        light5.enabled = true;
        light6.enabled = true;
        light7.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonHit == true)
        {
            source.PlayOneShot(buttonSound);

            buttonHit = false;

            lightsOn = !lightsOn;

            toggleLights;
        }
    }

    public void toggleLights()
    {
        if (lightsOn)
        {
            light1.enabled = true;
            light2.enabled = true;
            light3.enabled = true;
            light4.enabled = true;
            light5.enabled = true;
            light6.enabled = true;
            light7.enabled = true;
        }
        else
        {
            light1.enabled = false;
            light2.enabled = false;
            light3.enabled = false;
            light4.enabled = false;
            light5.enabled = false;
            light6.enabled = false;
            light7.enabled = false;
        }
    }

    private void triggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerHand"))
        {
            switchHit = true;
        }
    }
}
