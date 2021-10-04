using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displaywarn : MonoBehaviour
{
    public GameObject userwarn;
    public GameObject passwarn;
    public GameObject takenwarn;
    public GameObject scroll;

    public void LogUsearWarn()
    {
        userwarn.SetActive(true);
    }

    public void LogPassWarn()
    {
        passwarn.SetActive(true);
    }

    public void Usertaken()
    {
        scroll.transform.localPosition = new Vector3(0f, -425f, 0);
        takenwarn.SetActive(true);
    }

    public void ExitWarns()
    {
        userwarn.SetActive(false);
        passwarn.SetActive(false);
        takenwarn.SetActive(false);
    }
}