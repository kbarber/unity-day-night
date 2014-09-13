using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Look At")]
public class LookAt : MonoBehaviour
{

	// Target object to look at
	public Transform target;

	void DoLookAt ()
	{
		transform.LookAt (target);
	}

	void Start ()
	{
		DoLookAt ();
	}
	
	void LateUpdate ()
	{
		DoLookAt ();
	}
}
