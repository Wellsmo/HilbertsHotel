using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	void Update () {
		ReactivateChild ();

	}
	void ReactivateChild(){
		foreach (Transform child in this.transform) {
			if (Input.GetKey (KeyCode.R)) {
				child.gameObject.SetActive (true);
			}
		}
	}
}

