using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class Displaywarn : MonoBehaviour
{
    public GameObject userwarn;
    public GameObject passwarn;
    public GameObject takenwarn;
    public GameObject scroll;
    public string user = "Dozen";

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

    public void code()
    {
        var psi = new ProcessStartInfo();
        psi.FileName = @"C:\Users\Edith\AppData\Local\Programs\Python\Python39\python.exe";
        var script = @"D:\ESCRITORIOO\MODULAR\ConSupinacion_basecorrecta.py";
        psi.Arguments = $"\"{script}\"";
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        using (var process= Process.Start(psi))
        {

        }
    }
}
   