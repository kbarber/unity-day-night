using UnityEngine;
using System.Collections;

public class TurnOffSunLight : MonoBehaviour
{
	public Light sunLight;
	public RotateUniverse rotateUniverse;
	
	private void adjustSunlight ()
	{
		if (rotateUniverse.isDay) {
			sunLight.enabled = true;
		} else {
			sunLight.enabled = false;
		}
	}

	void Start ()
	{
		adjustSunlight ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		adjustSunlight ();
	}
}
