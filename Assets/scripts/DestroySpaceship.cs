using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DestroySpaceship : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "asteroid")
		{
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
			SceneManager.LoadScene(1);
		}

	}

	
}
