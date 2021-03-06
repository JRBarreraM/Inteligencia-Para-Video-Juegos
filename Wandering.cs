using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour {

	public float _speed;
	public float rotationSensitivity;
	private float orientation;
	private float rotation;

	void FixedUpdate () {
		transform.rotation = Quaternion.Euler(0f,0f,rotation) * transform.rotation;
		transform.position = Vector3.MoveTowards(transform.position,transform.GetChild(0).transform.position,_speed * Time.deltaTime);
		rotation = Random.Range(-1f,1f) * rotationSensitivity;
	}
}