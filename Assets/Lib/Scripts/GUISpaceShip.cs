using UnityEngine;
using System.Collections;

public class GUISpaceShip : MonoBehaviour
{

	public int enginePower = 0;

	void OnGUI ()
	{
		float axis = Input.GetAxis ("Vertical");
		if ((axis > 0) && enginePower < 100) {
			enginePower++;
		} else if ((axis < 0) && enginePower > 0) {
			enginePower--;
		}
		GUI.Box (new Rect (10, 45, 120, 25), "Engine Power: " + enginePower);
	}
}
