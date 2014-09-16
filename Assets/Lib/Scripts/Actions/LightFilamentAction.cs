using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Light Filament Action")]
[RequireComponent (typeof(MeshRenderer))]
public class LightFilamentAction : MonoBehaviour
{
	[Tooltip("On material.")]
	public Material
		onMaterial;

	[Tooltip("Off material.")]
	public Material
		offMaterial;

	[Header("Read-only settings")]
	
	[Tooltip("RO: Is the filament on?")]
	public bool
		filamentOn = true;

	void DoAction ()
	{
		if (filamentOn) {
			renderer.material = offMaterial;
			filamentOn = false;
		} else {
			renderer.material = onMaterial;
			filamentOn = true;
		}
	}
}
