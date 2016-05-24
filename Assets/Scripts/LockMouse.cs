using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class LockMouse : MonoBehaviour {

	RigidbodyFirstPersonController lockCursor;
	// Use this for initialization
	public void Lock()
	{
		
		lockCursor = FindObjectOfType (typeof(RigidbodyFirstPersonController)) as RigidbodyFirstPersonController;
		lockCursor.mouseLook.m_cursorIsLocked = true;
		lockCursor.mouseLook.UpdateCursorLock ();
		lockCursor.mouseLook.XSensitivity = 2;
		lockCursor.mouseLook.YSensitivity = 2;
	}

}
