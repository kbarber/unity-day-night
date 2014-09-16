using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Main Menu Item")]
[RequireComponent (typeof(GUITexture))]
public class MainMenuItem : MonoBehaviour
{

	public enum ButtonTypes
	{
		Start,
		Quit
	}

	[Tooltip("The button type that is represented by this GUITexture.")]
	public ButtonTypes
		buttonType = ButtonTypes.Start;
	
	void OnMouseOver ()
	{
		guiText.color = Color.red;
	}

	void OnMouseExit ()
	{
		guiText.color = Color.white;
	}

	void OnMouseUp ()
	{
		switch (buttonType) {
		case ButtonTypes.Start:
			Application.LoadLevel ("SpacePort");
			break;
		case ButtonTypes.Quit:
			Application.Quit ();
			break;
		default:
			Debug.LogError ("Invalid button type");
			break;
		}
	}
}
