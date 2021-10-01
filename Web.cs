using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine;

public class Web : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(Register("Singer","dia123","Pablo","Real","R","x","Clinica 1",54));
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser",username);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityAxo/date.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }

        }
    }

    public IEnumerator Register(string username,string password,string name,string lastname,string arm, string injury,string clinic, string age)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        form.AddField("nameUser", name);
        form.AddField("lastname", lastname);
        form.AddField("armuser", arm);
        form.AddField("injuryuser", injury);
        form.AddField("clinicuser", clinic);
        form.AddField("ageuser", age);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityAxo/register.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }

        }
    }
}