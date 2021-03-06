using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Web : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(Register("Singer","dia123","Pablo","Real","R","x","Clinica 1",54));
    }

    public IEnumerator Login(string username, string password,string time)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser",username);
        form.AddField("loginPass", password);
        form.AddField("loginTime", time);

        using (UnityWebRequest www = UnityWebRequest.Post("http://savetheaxo.ddns.net/UnityAxo/login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "0")
                {
                    main.Instance.Displaywarn.ExitWarns();
                    Debug.Log(username);
                    main.Instance.Displaywarn.code();
                    main.Instance.Userinfo.Setinfo(username,password);
                    SceneManager.LoadScene("Instructivo");
                }

                if (www.downloadHandler.text == "1")
                {
                    main.Instance.Displaywarn.ExitWarns();
                    main.Instance.Displaywarn.LogPassWarn();
                }

                if (www.downloadHandler.text == "2")
                {
                    main.Instance.Displaywarn.ExitWarns();
                    main.Instance.Displaywarn.LogUsearWarn();
                }
            }

        }
    }

    public IEnumerator Score(System.Action<string> callback)
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://savetheaxo.ddns.net/UnityAxo/score.php"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
               Debug.Log(www.downloadHandler.text);
                string jsonArray = www.downloadHandler.text;

                //Call callback fucntion to pass results
                callback(jsonArray);

            }

        }
    }

    public IEnumerator Register(string username,string password,string name,string lastname,string arm, string injury,string clinic, string age,string time)
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
        form.AddField("loginTime", time);

        using (UnityWebRequest www = UnityWebRequest.Post("http://savetheaxo.ddns.net/UnityAxo/register.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                main.Instance.Displaywarn.ExitWarns();
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "1")
                {
                    main.Instance.Displaywarn.ExitWarns();
                    main.Instance.Displaywarn.Usertaken();
                }
                else
                {
                    main.Instance.Displaywarn.code();
                    main.Instance.Userinfo.Setinfo(username, password);
                    SceneManager.LoadScene("Instructivo");
                }
            }

        }
    }
}