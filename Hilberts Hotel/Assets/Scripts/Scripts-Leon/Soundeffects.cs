using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffects : MonoBehaviour
{

    public AudioClip test;
    AudioSource audioSource;


    // Start is called before the first frame updat
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey(KeyCode.W))
        {
            audioSource.PlayClipAtPoint
        }
    }
}
