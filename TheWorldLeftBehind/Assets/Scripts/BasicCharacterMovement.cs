using UnityEngine;
using System.Collections;

public class BasicCharacterMovement : MonoBehaviour
{

	public float movementSpeed = 0f;

	private float checkIf0 = 0f;

	void Update()
	{
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(x, 0.0f, y);

		if(movement != Vector3.zero) //Check if V3 is 0
			transform.rotation = Quaternion.LookRotation(movement);

		transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
	}

}