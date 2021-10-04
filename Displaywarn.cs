using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displaywarn : MonoBehaviour
{
    public GameObject userwarn;
    public GameObject passwarn;

    public void LogUsearWarn()
    {
        userwarn.SetActive(true);
    }

    public void LogPassWarn()
    {
        passwarn.SetActive(true);
    }

    public void ExitWarns()
    {
        userwarn.SetActive(false);
        passwarn.SetActive(false);
    }
}