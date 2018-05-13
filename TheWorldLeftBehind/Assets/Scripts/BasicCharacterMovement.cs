using UnityEngine;
using System.Collections;

public class BasicCharacterMovement : MonoBehaviour
{

	public float movementSpeed = 0f;
	public float gravity = 9.8f;

	private float checkIf0 = 0f;
	private Vector3 fallVector;
	private CharacterController controller;

	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");
		fallVector = Vector3.zero;

		Vector3 movement = new Vector3(x, 0.0f, y);

		if(movement != Vector3.zero) //Check if V3 is 0
			transform.rotation = Quaternion.LookRotation(movement);
		if (controller.isGrounded == false) {
			fallVector += Physics.gravity;
		}
		transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);

		controller.Move (fallVector * Time.deltaTime);
	}

}