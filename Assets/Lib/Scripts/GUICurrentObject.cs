using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI/Current Object")]
public class GUICurrentObject : MonoBehaviour
{
	[Tooltip("Link to the GetAimedObject component.")]
	public GetAimedObject
		getAimedObjectHandler;

	[Header("Read-only settings")]

	[Tooltip("RO: The label of the object we have focus on.")]
	public string
		aimedLabel;

	private void DrawLabel ()
	{
		aimedLabel = getAimedObjectHandler.objectLabel;
		if (aimedLabel != null) {
			GUI.Box (new Rect (10, 10, 150, 25), aimedLabel);
		}
	}

	void OnGUI ()
	{
		DrawLabel ();
	}
}