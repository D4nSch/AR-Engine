using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchToCont : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
		SceneManager.LoadScene (1);
		}
	}
}
