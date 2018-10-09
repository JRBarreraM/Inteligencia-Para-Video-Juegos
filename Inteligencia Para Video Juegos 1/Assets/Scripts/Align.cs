using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour {
	public GameObject target;

	void FixedUpdate () {

		transform.rotation = Quaternion.RotateTowards(transform.rotation,target.transform.rotation,10f);
	}
}