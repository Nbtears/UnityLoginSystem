using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    public Button logbutton;
    public Button sign;
    public GameObject scenelog;
    public GameObject sceneReg;
    public GameObject actualscene;

    // Start is called before the first frame update
    void Start()
    {
        logbutton.onClick.AddListener(loginbutton);
        sign.onClick.AddListener(signbutton);
    }

    void loginbutton()
    {
        scenelog.SetActive(true);
        actualscene.SetActive(false);
    }

    void signbutton()
    {
        sceneReg.SetActive(true);
        actualscene.SetActive(false);
    }
}

