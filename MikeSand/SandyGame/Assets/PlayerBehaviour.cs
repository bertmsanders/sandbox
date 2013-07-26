using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	
	public float moveSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal") > 0) {
			rigidbody.AddForce(new Vector3(moveSpeed, 0f, 0f), ForceMode.VelocityChange);
		} else if (Input.GetAxis("Horizontal") < 0) {
			rigidbody.AddForce(new Vector3(-moveSpeed, 0f, 0f), ForceMode.VelocityChange);
		}
		
		if (Input.GetAxis("Vertical") > 0) {
			rigidbody.AddForce(new Vector3(0f, 0f, moveSpeed), ForceMode.VelocityChange);
		} else if (Input.GetAxis("Vertical") < 0) {
			rigidbody.AddForce(new Vector3(0f, 0f, -moveSpeed), ForceMode.VelocityChange);
		}
	}
}
