using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class firstPersonRaycast : MonoBehaviour {
public Camera camera;
public float rayDistance;
public float distance;

public GameObject target;

CursorLockMode cursorLock;

void Start () {
cursorLock = CursorLockMode.Locked;
}

void Update () {
if (Input.GetKeyDown (KeyCode.E)) {
Pickup (); 
}

if (Input.GetKeyDown ("escape")) {
cursorLock = CursorLockMode.None;
}
}//End Update

void Pickup (){
RaycastHit hit;
Ray ray = camera.ScreenPointToRay (Input.mousePosition);

if (Physics.Raycast (ray, out hit, rayDistance)) {
if (hit.collider.tag == "pickObject") {
Debug.Log ("You hit a pickObject!");
}
}
}//End Pickup
}//End Script

