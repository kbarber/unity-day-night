using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Light Action")]
[RequireComponent (typeof(Light))]
public class LightAction : MonoBehaviour
{
	[Header("Read-only settings")]
	
	[Tooltip("RO: Is the light on?")]
	public bool
		lightOn = true;

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
