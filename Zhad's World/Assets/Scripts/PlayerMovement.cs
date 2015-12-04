using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float movementSpeed = 10.0f;
	public float rotateSpeed = 50.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			MoveForward();
		}
		
		if (Input.GetKey(KeyCode.D)) {
			TurnRightward();
		}
		
		if (Input.GetKey(KeyCode.A)) {
			TurnLeftward();
		}
		
		if (Input.GetKey(KeyCode.S)) {
			MoveBackward();
		}
	}
	
	void MoveForward () {
		transform.Translate((Vector3.forward) * movementSpeed * Time.deltaTime);
	}
	
	void TurnRightward () {
		transform.Rotate((Vector3.up) * rotateSpeed * Time.deltaTime);
	}
	
	void TurnLeftward () {
		transform.Rotate((Vector3.up) * -rotateSpeed * Time.deltaTime);
	}
	
	void MoveBackward () {
		transform.Translate((Vector3.back) * movementSpeed * Time.deltaTime);
	}
}
