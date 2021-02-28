using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonQuit : MonoBehaviour
{
    // Sound
    private AudioSource source;
    public AudioClip buttonSound;

    private bool buttonHit = false;
    private GameObject button;

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

            // Quit game
            Application.Quit();
        }
    }

    private void triggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            buttonHit = true;
        }
    }
}
