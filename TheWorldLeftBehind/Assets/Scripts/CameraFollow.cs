using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	
	public Transform target;
	public float distance1;
	public float distance2;
	public float height;
	void Update(){
		Vector3 temp = transform.position;


		temp.z = target.position.z - distance1;
		temp.y = target.position.y + height;
		temp.x = target.position.x + distance2;

		transform.position = temp;
	}
}
