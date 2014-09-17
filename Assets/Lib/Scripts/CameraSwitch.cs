using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Camera Switch")]
public class CameraSwitch : MonoBehaviour
{
	[Tooltip("Camera to include in switching.")]
	public Camera[]
		cameras;

	[Header("Read-only settings")]

	[Tooltip("RO: Index of active camera.")]
	public int
		activeCamera;

	private void SwitchCamera (int index)
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
		SwitchCamera (activeCamera);
	}
	
	void Update ()
	{
		if (Input.GetKey ("c")) {
			activeCamera = 0;
		}
		if (Input.GetKey ("v")) {
			activeCamera = 1;
		}
		SwitchCamera (activeCamera);
	}
}
