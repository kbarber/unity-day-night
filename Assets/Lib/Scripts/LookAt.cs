using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Look At")]
public class LookAt : MonoBehaviour
{

	[Tooltip("Target transform to look at.")]
	public Transform
		target;

	void lookAt (Transform t)
	{
		transform.LookAt (t);
	}

	void Start ()
	{
		lookAt (target);
	}
	
	void LateUpdate ()
	{
		lookAt (target);
	}
}
