using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Click : MonoBehaviour {

	[SerializeField] GameObject panel;
    Color Color = new Color32(234, 238, 4, 0);
    Transform Pointer;


    RigidbodyFirstPersonController lockCursor;
    Guided Sequece;
    [HideInInspector]public bool Visit;

    // Use this for initialization
    void Start () {
		lockCursor = FindObjectOfType (typeof(RigidbodyFirstPersonController)) as RigidbodyFirstPersonController;
		lockCursor.mouseLook.m_cursorIsLocked = true;
		lockCursor.mouseLook.UpdateCursorLock ();
        Visit = false;
        Sequece = FindObjectOfType(typeof(Guided)) as Guided;
        Pointer =  transform.Find("Pointer");

    }


    public void Next()
    {
        Pointer.GetComponent<Animator>().SetBool("Next", true);
    }

	void OnMouseDown()
	{
			panel.SetActive (true);
			
			lockCursor.RotateView ();
		    lockCursor.mouseLook.XSensitivity = 0;
		    lockCursor.mouseLook.YSensitivity = 0;
            lockCursor.mouseLook.m_cursorIsLocked = false;
            Visit = true;
            Pointer.GetComponent<Light>().color = Color;
            Pointer.GetComponent<Animator>().SetBool("Visit", Visit);
            Sequece.ActiveNext();
      }
}
