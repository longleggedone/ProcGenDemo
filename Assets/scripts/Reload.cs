using UnityEngine;
using System.Collections;

public class Reload : MonoBehaviour {

	void Update() {
		//simplest reset is this: tell Unity to reload the current level
		if (Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel (Application.loadedLevel);
		}
	}

}
