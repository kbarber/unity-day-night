using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Door Frame Action")]
public class DoorFrameAction : MonoBehaviour
{
	/* Reference to doorhinge to pivot */
	public Transform doorHinge;

	/* false = closed, true = open */
	public bool doorOpen = true;

	/* Open door */
	void doAction ()
	{
		print ("Door Action");
		if (doorOpen) {
			/* Door is opened, close it */
			doorHinge.Rotate (new Vector3 (0, 90, 0));
			doorOpen = false;
		} else {
			/* Door is closed, open it */
			doorHinge.Rotate (new Vector3 (0, -90, 0));
			doorOpen = true;
		}
	}
}
