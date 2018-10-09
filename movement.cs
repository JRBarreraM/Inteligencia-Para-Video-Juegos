using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private float rottt = 0;

	void Update () {

		if (Input.GetKey (KeyCode.Z)) 
		{
			rottt += 10f;
		}

		if (Input.GetKey (KeyCode.M)) 
		{
			rottt -= 10f;
		}

		transform.rotation = Quaternion.Euler(0f,0f,transform.rotation.z + rottt);
	}
}
