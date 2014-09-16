using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI/Cross Hair")]
public class GUICrossHair : MonoBehaviour
{
	[Tooltip("Texture to draw as a cross hair.")]
	public Texture
		crosshairTexture;

	[Tooltip("Is cross hair visible?")]
	public bool
		visible = true;
	
	[Header("Read-only settings")]

	[Tooltip("RO: Position in the GUI for the crosshair.")]
	public Rect
		position;

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