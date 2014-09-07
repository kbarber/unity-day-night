using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Camera Switch")]
public class CameraSwitch : MonoBehaviour
{
	public Camera[] cameras;
	public int activeCamera;

	void switchCamera (int index)
	{
		for (int i = 0; i < cameras.Length; i++) {
			if (i == index) {
				cameras [i].gameObject.SetActive (true);
			} else {
				cameras [i].gameObject.SetActive (false);
			}
		}
	}

	void Start ()
	{
		switchCamera (activeCamera);
	}
	
	void Update ()
	{
		if (Input.GetKey ("c")) {
			activeCamera = 0;
		}
		if (Input.GetKey ("v")) {
			activeCamera = 1;
		}
		switchCamera (activeCamera);
	}
}
