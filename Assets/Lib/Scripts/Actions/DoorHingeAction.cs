using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Door Hinge Action")]
public class DoorHingeAction : MonoBehaviour
{
	[Header("Read-only settings")]

	[Tooltip("RO: Is the door open or closed?")]
	public bool
		doorOpen = true;

	void CloseDoor ()
	{
		print ("Closing door");
		transform.Rotate (new Vector3 (0, 90, 0));
		doorOpen = false;
	}

	void OpenDoor ()
	{
		print ("Opening door");
		transform.Rotate (new Vector3 (0, -90, 0));
		doorOpen = true;
	}

	void DoAction ()
	{
		if (doorOpen) {
			/* Door is opened, close it */
			CloseDoor ();
		} else {
			/* Door is closed, open it */
			OpenDoor ();
		}
	}
}
