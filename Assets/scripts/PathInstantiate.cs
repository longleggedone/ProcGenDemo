using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class PathInstantiate : MonoBehaviour
{


	private int counter = 0;
	public Transform floorPrefab;
	public Transform gridGenPrefab;
	private float randomSpawnChance;
	private float randomSpawnNum;


	// Use this for initialization
	void Start ()
	{
		randomSpawnChance = Random.Range (0f, 1f);
		randomSpawnNum = Random.Range (0f, 1f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (counter < 50) {
			float randomNum = Random.Range (0f, 1f);
		
			if (randomNum < 0.25f) {
				transform.Rotate (0f, 90f, 0f);
			} else if (randomNum >= 0.25f && randomNum < 0.5f) {
				transform.Rotate (0f, -90f, 0f);
			}
			Instantiate (floorPrefab, transform.position, Quaternion.Euler (0f, 0f, 0f));
			transform.position += (transform.forward * 5f);
			counter += 1;
		} else if (randomSpawnNum < randomSpawnChance) {
			Instantiate (gridGenPrefab, transform.position, Quaternion.Euler (0f, 0f, 0f));
			Destroy(gameObject);
		}
		}
	}

