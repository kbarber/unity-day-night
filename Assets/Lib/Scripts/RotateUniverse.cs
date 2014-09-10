using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Rotate Universe")]
public class RotateUniverse : MonoBehaviour
{
	[Tooltip("Degrees per second to move the sun & moon.")]
	[Range(0, 90)]
	public int
		degreesPerSecond = 10;

	[Header("Time Scale Controls")]

	[Tooltip("Maximum time scale.")]
	public int
		maximumTimeScale = 100;

	[Tooltip("% of day completed when starting rotation.")]
	[Range(0, 100)]
	public int
		startingPercent = 25;

	[Header("Read-only settings")]

	[Tooltip("RO: Returns true if it is day.")]
	public bool
		isDay;

	[Tooltip("RO: Current time of the world.")]
	public float
		worldTime;

	private void Rotate ()
	{
		// Rotate the object around its X axis at 10 degree/second.
		transform.Rotate (0, 0, Time.deltaTime * degreesPerSecond);
	}

	private static float RotationToWorldTime (float eulerAngle, int maxTime, int startPercent)
	{
		float rotationCalc = eulerAngle / 360 * maxTime;
		float startTime = startPercent / 100;
		return ((maxTime * startTime) + rotationCalc) % maxTime;
	}

	private static bool calcDay (float currentTime, int maxTime)
	{
		if (currentTime < (maxTime / 2)) {
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
