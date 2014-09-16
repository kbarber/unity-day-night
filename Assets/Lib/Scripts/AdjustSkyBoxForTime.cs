using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Adjust Sky Box for Time")]
public class AdjustSkyBoxForTime : MonoBehaviour
{
	public RotateUniverse rotateUniverse;
	public Camera cameraToAdjust;
	public Color dayColor = new Color (135, 206, 235);
	public Color nightColor = new Color (0, 0, 0);
	public Material nightSkybox;
	public Material daySkybox;

	private Color SkyBoxColor (bool day)
	{
		if (day) {
			return dayColor;
		} else {
			return nightColor;
		}
	}

	private Material SkyboxMaterial (bool day)
	{
		if (day) {
			return daySkybox;
		} else {
			return nightSkybox;
		}
	}

	void updateSkyBox ()
	{
		cameraToAdjust.backgroundColor = SkyBoxColor (rotateUniverse.isDay);
		Skybox skybox = cameraToAdjust.GetComponent<Skybox> ();
		if (skybox != null) {
			skybox.material = SkyboxMaterial (rotateUniverse.isDay);
		}
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
