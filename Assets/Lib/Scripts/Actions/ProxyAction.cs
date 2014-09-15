using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Action/Proxy Action")]
public class ProxyAction : MonoBehaviour
{
	public Transform forwardTo;

	void doAction ()
	{
		forwardTo.SendMessage ("doAction");
	}
}
