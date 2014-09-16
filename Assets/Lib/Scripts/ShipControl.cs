using UnityEngine;
using System.Collections;

[AddComponentMenu("DN/Ship Control")]
public class ShipControl : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	[Tooltip("Axes of rotation.")]
	public RotationAxes
		axes = RotationAxes.MouseXAndY;

	[Tooltip("X Sensitivity.")]
	public float
		sensitivityX = 15F;

	[Tooltip("Y Sensitivity.")]
	public float
		sensitivityY = 15F;

	[Tooltip("X Minimum.")]
	public float
		minimumX = -360F;
	[Tooltip("X Maximum.")]
	public float
		maximumX = 360F;

	[Tooltip("Y Minimum.")]
	public float
		minimumY = -60F;
	[Tooltip("Y Maximum.")]
	public float
		maximumY = 60F;

	[Tooltip("Y Rotation.")]
	float
		rotationY = 0F;
	
	void Update ()
	{
		if (axes == RotationAxes.MouseXAndY) {
			float rotationX = transform.localEulerAngles.y + Input.GetAxis ("Mouse X") * sensitivityX;
			
			rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			
			transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
		} else if (axes == RotationAxes.MouseX) {
			transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);
		} else {
			rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			
			transform.localEulerAngles = new Vector3 (-rotationY, transform.localEulerAngles.y, 0);
		}
	}
	
	void Start ()
	{
		// Make the rigid body not change rotation
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}
}
