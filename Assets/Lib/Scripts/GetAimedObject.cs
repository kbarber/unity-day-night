using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Get Aimed Object")]
public class GetAimedObject : MonoBehaviour
{

	public Transform objectHit;
	public InteractiveGameObject objectInteractive;
	public string objectLabel;
	
	void Update ()
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
		}
	}
}
