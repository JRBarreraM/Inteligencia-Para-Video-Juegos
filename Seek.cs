using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {

	public GameObject target;
	private float aceleration = 1f;
	private float maxVelocity = 0.5f;
	private Vector3 velocity;
	private Vector3 direction;
	
	void Update () {

		direction = target.transform.position - transform.position;
		//direction = transform.position - target.transform.position;
		direction = direction.normalized;
		velocity += direction * aceleration * Time.deltaTime;

		if (velocity.magnitude > maxVelocity){
			velocity = velocity.normalized;
			velocity *= maxVelocity;
		}
		transform.position = transform.position + velocity * Time.deltaTime;
	}
}