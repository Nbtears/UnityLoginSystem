using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField UserInput;
    public InputField PassInput;
    public InputField confirmPass;
    public InputField nameuser;
    public InputField lastname;
    public Dropdown arm;
    public InputField injury;
    public InputField clinic;
    public InputField age;
    public Button playbutton;
    public GameObject warning1;
    public GameObject scroll;


    void Start()
    {
        playbutton.onClick.AddListener(button);
    }

    void button()
    {
        if (PassInput.text == confirmPass.text)
        {
            warning1.SetActive(false);
            StartCoroutine(main.Instance.Web.Register(UserInput.text, PassInput.text,nameuser.text,lastname.text,arm.options[arm.value].text,injury.text,clinic.text,age.text));

        }
        else
        {
            warning1.SetActive(true);
            scroll.transform.localPosition = new Vector3(0f, -425f, 0);
        }
    }
}
