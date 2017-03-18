using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "bullet")
		{
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
		}

		if (coll.gameObject.tag == "border")
		{
			Destroy(this.gameObject);
		}
	}
}
