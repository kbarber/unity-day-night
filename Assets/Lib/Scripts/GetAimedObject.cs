using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Get Aimed Object")]
[RequireComponent (typeof(Camera))]
public class GetAimedObject : MonoBehaviour
{
	[Header("Read-only settings")]

	[Tooltip("RO: The object have focus on.")]
	public Transform
		objectHit;

	[Tooltip("RO: The corresponding interactive object component of the object.")]
	public InteractiveGameObject
		objectInteractive;

	[Tooltip("RO: The label of the interactive object we are focusing on.")]
	public string
		objectLabel;

	private void RayCastForObject ()
	{
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay (new Vector3 (camera.pixelWidth / 2, camera.pixelHeight / 2, 0));
		if (Physics.Raycast (ray, out hit)) {
			objectHit = hit.transform;
			objectInteractive = hit.transform.gameObject.GetComponent<InteractiveGameObject> ();
			if (objectInteractive) {
				objectLabel = objectInteractive.label;
			} else {
				objectLabel = null;
			}
		} else {
			objectInteractive = null;
			objectLabel = null;
		}
	}

	private void DoActionOnObject ()
	{
		if (objectInteractive && Input.GetKey ("f")) {
			objectInteractive.SendMessage ("DoAction");
		}
	}
	
	void Update ()
	{
		RayCastForObject ();
		DoActionOnObject ();
	}
}
