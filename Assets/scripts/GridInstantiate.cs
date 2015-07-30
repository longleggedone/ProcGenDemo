using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorPrefab;
	public Transform wallPrefab;
	public Transform pathGenPrefab;
	private float randomSpawnChance;
	private float randomSpawnNum;

	// Use this for initialization
	void Start () {
		randomSpawnChance = Random.Range (0f, 1f);
		randomSpawnNum = Random.Range (0f, 1f);
		for (int x = 0; x < 5; x++){
			for (int z = 0; z < 5; z++){
				Vector3 pos = new Vector3 (x * 5, 0, z* 5) + transform.position;
				float randomNum  = Random.Range (0f, 1f);
				if (randomNum < 0.7f){
					Instantiate (floorPrefab, pos, Quaternion.Euler (0f, 0f, 0f));
				} else if (randomNum >=0.7f && randomNum < 0.95f){
					Instantiate (wallPrefab, pos, Quaternion.Euler (0f, 0f, 0f));
				}
			}
		}
		if (randomSpawnNum < randomSpawnChance){
			//Debug.Log ("Path");
			Instantiate (pathGenPrefab, transform.position, Quaternion.Euler (0f, 0f, 0f));
			Destroy (gameObject);
		}
	}
}



