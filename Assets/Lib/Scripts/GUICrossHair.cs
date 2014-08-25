using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI Cross Hair")]
public class GUICrossHair : MonoBehaviour {

	// Texture to draw as a cross hair
	public Texture crosshairTexture;

	// RO Position in the GUI for the crosshair.
	public Rect position;
	
	public bool OriginalOn = true;

	void Update () {
		position = new Rect(
			(Screen.width - crosshairTexture.width) / 2,
			(Screen.height - crosshairTexture.height) /2,
			crosshairTexture.width, crosshairTexture.height);
	}
	
	void OnGUI () {
		if(OriginalOn == true) {
			GUI.DrawTexture(position, crosshairTexture);
		}
	}
}
