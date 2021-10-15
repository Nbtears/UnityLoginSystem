using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public static main Instance;
    public Web Web;
    public Displaywarn Displaywarn;
    public Userinfo Userinfo;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Web = GetComponent<Web>();
        Displaywarn = GetComponent<Displaywarn>();
        Userinfo = GetComponent<Userinfo>();
    }

}
