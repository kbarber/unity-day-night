using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Light Action")]
public class LightAction : MonoBehaviour
{
	// Source of light
	public Light lightSource;

	// RO: Light off or on?
	public bool lightOn = true;

	// Turn off/on light
	void doAction ()
	{
		print ("Light Action");
		if (lightOn) {
			lightSource.enabled = false;
			lightOn = false;
		} else {
			lightSource.enabled = true;
			lightOn = true;
		}
	}
}
