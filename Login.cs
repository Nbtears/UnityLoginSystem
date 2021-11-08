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
    public Dropdown time;
    string duration;

    // Start is called before the first frame update
    void Start()
    {
        Signbutton.onClick.AddListener(activate);
        Logbutton.onClick.AddListener(() =>
        {
            string s = time.options[time.value].text;
            duration = s.Split(' ')[0];
            StartCoroutine(main.Instance.Web.Login(UserInput.text, PassInput.text,duration));
        });
    }

    void activate()
    {
        actual.SetActive(false);
        sign.SetActive(true);
    }
}
