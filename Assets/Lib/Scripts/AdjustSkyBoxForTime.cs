using UnityEngine;
using System.Collections;

public class AdjustSkyBoxForTime : MonoBehaviour
{
	public RotateUniverse rotateUniverse;
	public Camera cameraToAdjust;
	public Color dayColor = new Color (135, 206, 235);
	public Color nightColor = new Color (0, 0, 0);

	private Color SkyBoxColor (bool day)
	{
		if (day) {
			return dayColor;
		} else {
			return nightColor;
		}
	}

	void updateSkyBox ()
	{
		cameraToAdjust.backgroundColor = SkyBoxColor (rotateUniverse.isDay);
	}

	// Use this for initialization
	void Start ()
	{
		updateSkyBox ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		updateSkyBox ();
	}
}
