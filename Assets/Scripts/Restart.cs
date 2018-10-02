using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	void OnMouseDown() {
		Application.LoadLevel (Application.loadedLevel);
	}
}
