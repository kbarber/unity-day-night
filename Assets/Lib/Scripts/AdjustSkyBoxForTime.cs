using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Adjust Sky Box for Time")]
public class AdjustSkyBoxForTime : MonoBehaviour
{
	[Tooltip("RotateUniverse object for time reference.")]
	public RotateUniverse
		rotateUniverse;

	[Tooltip("Camera object to focus on.")]
	public Camera
		cameraToAdjust;

	[Tooltip("Color for the day sky.")]
	public Color
		dayColor = new Color (135, 206, 235);

	[Tooltip("Color for the night sky.")]
	public Color
		nightColor = new Color (0, 0, 0);

	[Tooltip("Skybox for the day sky.")]
	public Material
		nightSkybox;

	[Tooltip("Skybox for the night sky.")]
	public Material
		daySkybox;

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

	void UpdateSkyBox ()
	{
		cameraToAdjust.backgroundColor = SkyBoxColor (rotateUniverse.isDay);
		Skybox skybox = cameraToAdjust.GetComponent<Skybox> ();
		if (skybox != null) {
			skybox.material = SkyboxMaterial (rotateUniverse.isDay);
		}
	}
	
	void Start ()
	{
		UpdateSkyBox ();
	}

	void Update ()
	{
		UpdateSkyBox ();
	}
}
