using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Splash Screen To Main Menu")]
[RequireComponent (typeof(GUITexture))]
public class SplashScreenToMainMenu : MonoBehaviour
{

	public float timeToWait = 3.0f;

	IEnumerator WaitCoroutine ()
	{
		yield return new WaitForSeconds (timeToWait);
		Application.LoadLevel ("MainMenu");
	}

	void Start ()
	{
		StartCoroutine (WaitCoroutine ());
	}
}
