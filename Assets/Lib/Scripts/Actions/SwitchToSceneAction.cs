using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Switch To Scene Action")]
public class SwitchToSceneAction : MonoBehaviour
{
	[Tooltip("Name of scene to load.")]
	public string
		sceneName;

	void DoAction ()
	{
		Application.LoadLevel (sceneName);
	}
}
