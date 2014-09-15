using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Door Hinge Action")]
public class DoorHingeAction : MonoBehaviour
{
	/* false = closed, true = open */
	public bool doorOpen = true;

	/* Open door */
	void doAction ()
	{
		if (doorOpen) {
			/* Door is opened, close it */
			print ("Closing door");
			transform.Rotate (new Vector3 (0, 90, 0));
			doorOpen = false;
		} else {
			/* Door is closed, open it */
			print ("Opening door");
			transform.Rotate (new Vector3 (0, -90, 0));
			doorOpen = true;
		}
	}
}
