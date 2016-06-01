using UnityEngine;
using System.Collections;

public class Presentation : MonoBehaviour {


    float waitTime = 1.5f;
    // Use this for initialization
    void OnEnable()
    {
        StartCoroutine("WaitASec");
    }

    // Update is called once per frame
    IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<LockMouse>().Lock();
        Debug.Log("Lock Mouse");
        Debug.Log("Disable");
        gameObject.SetActive(false);
    }
}
