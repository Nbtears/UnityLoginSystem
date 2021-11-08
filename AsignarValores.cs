using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Web;


public class AsignarValores : MonoBehaviour
{
    
    public Text repfe;
    public Text repsp;
    public Button morebutton;

    // Start is called before the first frame update
    void Start()
    {
        
        repfe.text= AstronautMovement.fe.ToString();
        repsp.text = AstronautMovement.sp.ToString();
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

