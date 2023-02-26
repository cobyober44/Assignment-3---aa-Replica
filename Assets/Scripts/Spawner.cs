using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;
	public AudioSource source;
	public AudioClip clip;

	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			SpawnPin();
			source.PlayOneShot(clip);
		}
	}

	void SpawnPin ()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}

}
