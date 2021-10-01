using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField UserInput;
    public InputField PassInput;
    public Button Logbutton;
    public Button Signbutton;
    public GameObject sign;
    public GameObject actual;

    // Start is called before the first frame update
    void Start()
    {
        Signbutton.onClick.AddListener(activate);
        Logbutton.onClick.AddListener(() =>
        {
            StartCoroutine(main.Instance.Web.Login(UserInput.text, PassInput.text));
        });
    }

    void activate()
    {
        actual.SetActive(false);
        sign.SetActive(true);
    }
}
