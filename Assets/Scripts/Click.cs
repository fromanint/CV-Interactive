using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Click : MonoBehaviour {

	[SerializeField] GameObject panel;

	RigidbodyFirstPersonController lockCursor;
	// Use this for initialization
	void Start () {
		lockCursor = FindObjectOfType (typeof(RigidbodyFirstPersonController)) as RigidbodyFirstPersonController;
		lockCursor.mouseLook.m_cursorIsLocked = true;
		lockCursor.mouseLook.UpdateCursorLock ();
	}
	void Update()
	{
		
	}

	void OnMouseDown()
	{
			panel.SetActive (true);
			lockCursor.mouseLook.m_cursorIsLocked = false;
			lockCursor.RotateView ();
		lockCursor.mouseLook.XSensitivity = 0;
		lockCursor.mouseLook.YSensitivity = 0;

	}
}
