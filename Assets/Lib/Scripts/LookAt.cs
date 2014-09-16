using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Look At")]
public class LookAt : MonoBehaviour
{
	[Tooltip("Target transform to look at.")]
	public Transform
		target;

	void LookAtTarget (Transform t)
	{
		transform.LookAt (t);
	}

	void Start ()
	{
		LookAtTarget (target);
	}
	
	void LateUpdate ()
	{
		LookAtTarget (target);
	}
}
