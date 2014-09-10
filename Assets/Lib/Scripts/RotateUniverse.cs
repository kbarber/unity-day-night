using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Rotate Universe")]
public class RotateUniverse : MonoBehaviour
{
	[Tooltip("Degrees per second to rotate the universe.")]
	[Range(0, 90)]
	public int
		degreesPerSecond = 10;

	[Header("Time Scale Controls")]

	[Tooltip("Maximum time scale.")]
	public int
		maximumTimeScale = 100;

	[Tooltip("% of rotation completed when script starts. For example, if your sun starts at the sunrise location, " + 
	         "then use zero. If it starts at the top of the sky (midday), then use 25%.")]
	[Range(0, 100)]
	public int
		startingPercent = 25;

	[Header("Read-only settings")]

	[Tooltip("RO: Returns true if it is day.")]
	public bool
		isDay;

	[Tooltip("RO: Current time of the world.")]
	public int
		worldTime;

	private void Rotate ()
	{
		// Rotate the object around its X axis at 10 degree/second.
		transform.Rotate (0, 0, Time.deltaTime * degreesPerSecond);
	}

	private static int RotationToWorldTime (float eulerAngle, int maxTime, int startingPercent)
	{
		float rotationCalc = (eulerAngle / 360f) * maxTime;
		float startTime = startingPercent / 100f;
		return Mathf.RoundToInt ((maxTime * startTime) + rotationCalc) % maxTime;
	}

	private static bool calcDay (float currentTime, int maxTime)
	{
		if (currentTime < (maxTime / 2f)) {
			return true;
		} else {
			return false;
		}
	}

	private void UpdateWorldTime ()
	{
		worldTime = RotationToWorldTime (transform.rotation.eulerAngles.z, maximumTimeScale, startingPercent);
		isDay = calcDay (worldTime, maximumTimeScale);
	}

	void Start ()
	{
		UpdateWorldTime ();
	}

	void Update ()
	{
		Rotate ();
		UpdateWorldTime ();
	}
}
