using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour {
	public GameObject target;
	private float diferencia;
	//private float restitucion;

	void FixedUpdate ()
	{
		diferencia = target.transform.eulerAngles.z - transform.eulerAngles.z;
		//if (diferencia != 0f) {
			//restitucion+=(1f/(diferencia));
		transform.rotation = Quaternion.Euler (0f, 0f, diferencia + transform.eulerAngles.z);
		//}

	}
		//transform.rotation = Quaternion.RotateTowards(transform.rotation,target.transform.rotation,1f);
}