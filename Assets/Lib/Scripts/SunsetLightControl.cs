using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Sunset light control")]
[RequireComponent (typeof(Light))]
public class SunsetLightControl : MonoBehaviour
{
	[Tooltip("Y Axis trigger to enable/disable the light.")]
	[Range(0, 10000)]
	public int
		yAxisTrigger = 0;

	private void AdjustLight ()
	{
		if (transform.position.y > yAxisTrigger) {
			light.enabled = true;
		} else {
			light.enabled = false;
		}
	}

	void Start ()
	{
		AdjustLight ();
	}
	
	void Update ()
	{
		AdjustLight ();
	}
}
