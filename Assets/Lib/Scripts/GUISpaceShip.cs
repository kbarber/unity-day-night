using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI/Space Ship")]
public class GUISpaceShip : MonoBehaviour
{
	[Header("Read-only settings")]

	[Tooltip("RO: Current engine power.")]
	public int
		enginePower = 0;

	private void AdjustEnginePower ()
	{
		float axis = Input.GetAxis ("Vertical");
		if ((axis > 0) && enginePower < 100) {
			enginePower++;
		} else if ((axis < 0) && enginePower > 0) {
			enginePower--;
		}
		GUI.Box (new Rect (10, 45, 120, 25), "Engine Power: " + enginePower);

	}

	void OnGUI ()
	{
		AdjustEnginePower ();
	}
}
