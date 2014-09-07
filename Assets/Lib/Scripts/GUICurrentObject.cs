using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/GUI Current Object")]
public class GUICurrentObject : MonoBehaviour
{

	public GetAimedObject getAimedObjectHandler;

	// RO: current aimedLabel
	public string aimedLabel;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
		aimedLabel = getAimedObjectHandler.objectLabel;
		if (aimedLabel != null) {
			GUI.Box (new Rect (10, 10, 100, 25), aimedLabel);
		}
	}
}
