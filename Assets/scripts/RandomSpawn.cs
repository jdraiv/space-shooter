using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
	public GameObject asteroid;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnAsteroid", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void SpawnAsteroid (){
		Vector3 position = transform.position;
		int teleport = Random.Range(-11,11);
		position.y += 5;
		position.x += teleport;
		Instantiate(asteroid,position,transform.rotation);
	}

}
