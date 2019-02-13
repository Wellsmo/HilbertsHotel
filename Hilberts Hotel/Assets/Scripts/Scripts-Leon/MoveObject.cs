﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    float throwForce = 600f;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject tempParent;
    public GameObject item;
    public bool isHolding = false;
    // Update is called once per frame
    void Update()
    {
        if(isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                //throw
            }
        }

        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions = true;
    }

    void OnMouseUp()
    {
        isHolding = false;
    }
    /*void ItemFollow ()
    {
        if (item.GetComponent<Rigidbody>().isKinematic = true)
        {
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
        }*/
}
