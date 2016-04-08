using UnityEngine;
using System.Collections;

// Allows controlling the camera by holding down right mouse button
// when testing from the Unity editor
// Source: https://github.com/abrp/GazerNew
public class MouseControlledEditorCamera : MonoBehaviour {
	
	[SerializeField] private float m_sensitivityX = 8f;
	[SerializeField] private float m_sensitivityY = 8f;
	private float m_mouseHeading = 0f;
	private float m_mousePitch = 0f;

	private void Update()
	{
		#if UNITY_EDITOR
		if (!(Input.GetMouseButton(1)))
			return;
		Vector2 delta = new Vector2(Input.GetAxis("Mouse X") * m_sensitivityX,Input.GetAxis("Mouse Y") * m_sensitivityY);
		ChangeHeading(delta.x);
		ChangePitch(-delta.y);
		#endif
	}

	private void ChangeHeading(float newHeading){
		m_mouseHeading += newHeading;
		transform.localEulerAngles = new Vector3(m_mousePitch, m_mouseHeading, 0);
	}
	
	private void ChangePitch(float newPitch){
		m_mousePitch += newPitch;
		transform.localEulerAngles = new Vector3(m_mousePitch, m_mouseHeading, 0);
	}

}