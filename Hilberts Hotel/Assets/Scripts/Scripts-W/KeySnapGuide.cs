using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySnapGuide : MonoBehaviour
{

    Vector3 keysnapPos;

    public GameObject tempParent;
    public GameObject key;


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
            key.GetComponent<Rigidbody>().velocity = Vector3.zero;
            key.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            key.transform.SetParent(tempParent.transform);

            key.transform.position = keysnapPos;
        }
    }
}
