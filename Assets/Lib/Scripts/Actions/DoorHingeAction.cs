using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Door Hinge Action")]
public class DoorHingeAction : MonoBehaviour
{
	[Header("Read-only settings")]

	[Tooltip("RO: Is the door open or closed?")]
	public bool
		doorOpen = true;

	void closeDoor ()
	{
		print ("Closing door");
		transform.Rotate (new Vector3 (0, 90, 0));
		doorOpen = false;
	}

	void openDoor ()
	{
		print ("Opening door");
		transform.Rotate (new Vector3 (0, -90, 0));
		doorOpen = true;
	}

	void doAction ()
	{
		if (doorOpen) {
			/* Door is opened, close it */
			closeDoor ();
		} else {
			/* Door is closed, open it */
			openDoor ();
		}
	}
}
