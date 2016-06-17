using UnityEngine.UI;
using UnityEngine;
using System.Collections;
public class KeyboardManager : MonoBehaviour {

    [SerializeField] Button Esc, Next, Previous;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Esc.onClick.Invoke();
        }
        if (Next || Previous != null)
        {
            if (Input.GetKeyDown("right"))
            { Next.onClick.Invoke(); }

            if (Input.GetKeyDown("left"))
            { Previous.onClick.Invoke(); }
        }
    }
}
