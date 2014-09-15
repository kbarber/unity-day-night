﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Switch To Scene Action")]
public class SwitchToSceneAction : MonoBehaviour
{
	public string sceneName;

	void doAction ()
	{
		Application.LoadLevel (sceneName);
	}
}