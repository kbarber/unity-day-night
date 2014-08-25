using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Rotate Universe")]
public class RotateUniverse : MonoBehaviour {

	void Rotate () {
		// Slowly rotate the object around its X axis at 1 degree/second.
		transform.Rotate(0, 0, Time.deltaTime);
	}

	void Update () {
		Rotate();
	}
}
