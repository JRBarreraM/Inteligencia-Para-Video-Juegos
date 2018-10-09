using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fish_Movement : MonoBehaviour {

	public float _speed;
	public float rotationSensitivity;
	private float orientation;
	private float rotation;

	void FixedUpdate () {
		Rotation ();

		if (Input.GetKey (KeyCode.M)) {
			orientation = 1f;
		}

		if (Input.GetKey (KeyCode.Z)) {
			orientation = -1f;
		}

		if (!Input.GetKey (KeyCode.Z) && !Input.GetKey (KeyCode.M)){
			orientation = 0f;
		}
	}

	void Rotation(){

		if (orientation == 1f) {
			rotation = -1f * rotationSensitivity;
		}

		if (orientation == -1f) {
			rotation = 1f * rotationSensitivity;
		}

		transform.rotation = Quaternion.Euler(0f,0f,rotation) * transform.rotation ;
		transform.position = Vector3.MoveTowards(transform.position,transform.GetChild(0).transform.position,_speed * Time.deltaTime);
	}
}