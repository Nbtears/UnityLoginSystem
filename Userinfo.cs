using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Userinfo : MonoBehaviour
{
    public string Username { get; private set; }
    public string Userpassword { get; private set; }

    public void Setinfo(string username, string password)
    {
        Username = username;
        Userpassword = password;
    }
}
