using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour {
	public int health = 2;

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.tag == "bullet")
		{
			if (health == 1)
			{
				Destroy(coll.gameObject);
			    Destroy(this.gameObject);
			}
			else
			{
				health -= 1;
				Destroy(coll.gameObject);
				
			}
		}

		if (coll.gameObject.tag == "border")
		{
			Destroy(this.gameObject);
		}
	}
}
