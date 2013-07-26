using UnityEngine;
using System.Collections;

public class JetPackBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump")) {
			particleSystem.enableEmission = true;
		}else{
			particleSystem.enableEmission = false;
		}
	}
}
