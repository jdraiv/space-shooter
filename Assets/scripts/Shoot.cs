using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public AudioClip shootSound;

	private AudioSource source;
	private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    void Awake () {
		source = GetComponent<AudioSource>();

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		{
			float vol = Random.Range( volLowRange, volHighRange);
			source.PlayOneShot(shootSound,vol);
			Instantiate(bullet,transform.position, transform.rotation);
		}
		
	}
}
