using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Switch To Space")]
public class SwitchToSpace : MonoBehaviour
{
	void doAction ()
	{
		Application.LoadLevel ("Space");
	}
}
