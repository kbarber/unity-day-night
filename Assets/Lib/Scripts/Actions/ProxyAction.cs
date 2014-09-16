using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Proxy Action")]
public class ProxyAction : MonoBehaviour
{
	[Tooltip("Forward action requests to this transform.")]
	public Transform
		forwardTo;

	void doAction ()
	{
		forwardTo.SendMessage ("doAction");
	}
}
