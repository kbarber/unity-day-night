using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI Cross Hair")]
public class GUICrossHair : MonoBehaviour
{
	// Texture to draw as a cross hair
	public Texture crosshairTexture;

	// RO Position in the GUI for the crosshair.
	private Rect position;

	// Use to make cross hair visible
	public bool visible = true;

	void Update ()
	{
		position = new Rect (
			(Screen.width - crosshairTexture.width) / 2,
			(Screen.height - crosshairTexture.height) / 2,
			crosshairTexture.width,
			crosshairTexture.height);
	}
	
	void OnGUI ()
	{
		if (visible == true) {
			GUI.DrawTexture (position, crosshairTexture);
		}
	}
}