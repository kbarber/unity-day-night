using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Splash Screen To Main Menu")]
[RequireComponent (typeof(GUITexture))]
public class SplashScreenToMainMenu : MonoBehaviour
{
	[Tooltip("Time to wait before loading main menu.")]
	[Range(0f, 100f)]
	public float
		timeToWait = 3.0f;

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
