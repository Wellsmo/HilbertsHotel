using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUseKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    
    }

        private void OnTriggerEnter(Collider other)
        {
             if (other.gameObject.CompareTag("Keyhole"))
             {
                //gameObject.SetActive (false);
            print("hej");
            }
         }
}
