using UnityEngine;
using System.Collections;

public class Guided : MonoBehaviour {

    [SerializeField] Click[] Sequence;

   void Start()
    {
        Sequence[0].Next();
    }


    public void ActiveNext()
    {
        foreach (Click cl in Sequence)
        {
            if (!cl.Visit)
            {
                cl.Next();
                break;
            }
        }
    }
}
