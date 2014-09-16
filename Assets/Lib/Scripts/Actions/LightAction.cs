using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Light Action")]
[RequireComponent (typeof(Light))]
public class LightAction : MonoBehaviour
{
	// RO: Light off or on?
	public bool lightOn = true;

	// Turn off/on light
	void doAction ()
	{
		print ("Light Action");
		if (lightOn) {
			light.enabled = false;
			lightOn = false;
		} else {
			light.enabled = true;
			lightOn = true;
		}
	}
}
