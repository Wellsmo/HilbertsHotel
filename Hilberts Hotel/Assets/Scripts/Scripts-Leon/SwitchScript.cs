using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

   public Light light1;

    // Start is called before the first frame update
    void Start()
    {
        //OnTriggerEnter();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("light"))
        {
            light1.enabled = !light1.enabled;
            print("hej");
        }
    }
}
