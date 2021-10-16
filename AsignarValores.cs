using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Web;


public class AsignarValores : MonoBehaviour
{
    private int txt;
    private string x;
    public Text reptext;
    public Text puntajetxt;
    public Button morebutton;

    // Start is called before the first frame update
    void Start()
    {
        txt = (int)(HealthBar.CurrentPorcentaje * 100f);
        puntajetxt.text = txt.ToString()+"%";
        reptext.text = AstronautMovement.rep.ToString();
        morebutton.onClick.AddListener(more);


    }

    void more()
    {
        string username = main.Instance.Userinfo.Username;
        Debug.Log(username);
        string url = "http://savetheaxo.ddns.net/Data/user.php?user=" + username;
        Application.OpenURL(url);
        
    }
}

