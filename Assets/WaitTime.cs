using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTime : MonoBehaviour
{

    public void WaitForThis ()
    {
        StartCoroutine(TimeWait());
    }

    IEnumerator TimeWait()
    {
        yield return new WaitForSecondsRealtime(1);
    }

}
