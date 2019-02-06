using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffects : MonoBehaviour
{

    //public AudioClip test;
    public AudioClip test;
 

    // Start is called before the first frame updat
    void Start()
    {
        AudioSource.PlayClipAtPoint(test, new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
