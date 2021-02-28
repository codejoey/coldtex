using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonCredits : MonoBehaviour
{
    // Sound
    private AudioSource source;
    public AudioClip buttonSound;

    // public text object Credits
    // public text/image object Title, possibly two images if we have a title and the HackUTD logo

    private bool buttonHit = false;
    private GameObject button;

    bool creditsUp = false;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();

        button = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonHit == true)
        {
            source.PlayOneShot(buttonSound);

            toggleCredits();
        }
    }

    private void triggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            buttonHit = true;
        }
    }

    private void toggleCredits()
    {
        if(!creditsUp)
        {
            // hide title and hackutd logo

            // bring up credits
            // change visibility of object to visible
            
        }
        else
        {
            // hide credits
            // change visibility of object to invis

            // bring up Title and HackUTD logo
        }
    }
}



