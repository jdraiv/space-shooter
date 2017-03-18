using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * speed *  Time.deltaTime;
		//Up and Down movement
		//newPosition.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
		transform.position = newPosition;
	}
}
