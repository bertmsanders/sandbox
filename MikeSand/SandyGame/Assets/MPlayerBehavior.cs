using UnityEngine;
using System.Collections;

public class MPlayerBehavior : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpSpeed;
	
	// Use this for initialization
	void Start () {
		renderer.material.color = Color.black;
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
		
		if (Input.GetButton("Jump")) {
			rigidbody.AddForce(new Vector3(0f, jumpSpeed, 0f), ForceMode.VelocityChange);
		}
	}
}
