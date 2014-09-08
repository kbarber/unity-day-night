using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Rotate Universe")]
public class RotateUniverse : MonoBehaviour
{
	// How many degrees per second to move the sun & moon
	public int degreesPerSecond = 10;

	// Time of the world, from 0 to maximumTime
	public float worldTime;

	// Maximum time
	public float maximumWorldTime = 100;

	// Starting Position
	public float startingTime = 0.25f;

	// Day?
	public bool isDay;

	private void Rotate ()
	{
		// Rotate the object around its X axis at 10 degree/second.
		transform.Rotate (0, 0, Time.deltaTime * degreesPerSecond);
	}

	/* Here we convert the rotation of the world into time */
	private static float RotationToWorldTime (float eulerAngle, float maxTime, float startTime)
	{
		float rotationCalc = eulerAngle / 360 * maxTime;
		return ((maxTime * startTime) + rotationCalc) % maxTime;
	}

	private static bool calcDay (float currentTime, float maxTime)
	{
		if (currentTime < (maxTime / 2)) {
			return true;
		} else {
			return false;
		}
	}

	private void UpdateWorldTime ()
	{
		worldTime = RotationToWorldTime (transform.rotation.eulerAngles.z, maximumWorldTime, startingTime);
		isDay = calcDay (worldTime, maximumWorldTime);
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
