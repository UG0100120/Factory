using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator : MonoBehaviour
{

    public void StartAnimation()
    {
        this.gameObject.GetComponent<Animator>().enabled = true;
    }
    public void StopAnimation()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;

    }
}
