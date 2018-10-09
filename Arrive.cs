using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : MonoBehaviour {

	public GameObject target;
	private int aceleration = 1;
	private float maxVelocity = 2f;
	private Vector3 velocity;
	private Vector3 direction;
	private float slowRadius = 2f;
	private float targetRadius = 0.2f; 
	private float distance;

	void Update () {
		direction = target.transform.position - transform.position;
		distance = direction.magnitude;
		//direction = transform.position - target.transform.position;
		direction = direction.normalized;
		velocity += direction * aceleration * Time.deltaTime;

		if(distance < targetRadius){
			velocity = Vector3.zero;
		} else if(targetRadius < distance && distance < slowRadius) {
			velocity = velocity / 1.05f;
		}
		transform.position = transform.position + velocity * Time.deltaTime;

		if (velocity.magnitude > maxVelocity){
			velocity = velocity.normalized;
			velocity *= maxVelocity;
		} 
	}
}