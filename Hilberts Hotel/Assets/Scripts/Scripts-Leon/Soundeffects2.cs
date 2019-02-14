using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffects2 : MonoBehaviour
{

    //public AudioClip test;
    public AudioClip SoundFX;
    public AudioClip BackgroundSound;
    public bool Ringer = true;
 

    // Start is called before the first frame updat
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Ringer == true)
        {
            AudioSource.PlayClipAtPoint(BackgroundSound, new Vector3(0, 0, 0));
        }
    }

    void OnTriggerEnter(Collider test)
    {

        if (gameObject.CompareTag("Ambient"))
        {
            AudioSource.PlayClipAtPoint(SoundFX, new Vector3(0, 0, 0));
            print("play test");
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (gameObject.CompareTag("Phonezone") && (Ringer = true) && Input.GetKeyDown(KeyCode.E)) 
        {
            AudioSource.PlayClipAtPoint(SoundFX, new Vector3(0, 0, 0));
            print("play test");
        }

        /*if (Ringer = true)
        {

        }*/
    }
}
