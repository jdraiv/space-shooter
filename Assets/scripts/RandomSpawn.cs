using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
	public GameObject spawnObject;



	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", 3.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void SpawnEnemy() {
		Instantiate(spawnObject, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), 0), Quaternion.identity);
	}
}
