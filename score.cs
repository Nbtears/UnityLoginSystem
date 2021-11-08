using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI ScoreTotal;
    private float time;
    private int aux1;
    private int aux2;
    public int number;
    public int limitFE;
    public int limitSP;
    public AudioClip Success;
    public string RepFlex;
    public string RepSup;
    public TextMeshProUGUI Sup;
    public GameObject AvisoRecord;
    public GameObject AvisoVel;
    public GameObject SUP;
    public GameObject FLEX;
    public TextMeshProUGUI Flex;

    public void Start()
    {
        aux1 = 0;
        aux2 = 0;
        StartCoroutine(getData());
    }

    public void Update()
    {
        ScoreTotal.text = "Score: " + AstronautMovement.score;
        

        if (Input.GetKeyDown(KeyCode.H))
        {
            SUP.SetActive(true);
            FLEX.SetActive(false);
        }
        if (AstronautMovement.ck==0 && AstronautMovement.rep > limitFE && aux1==0)
        {
            time = Time.time;
            GetComponent<AudioSource>().PlayOneShot(Success);
            aux1 = 1;
            AvisoVel.SetActive(false);
            AvisoRecord.SetActive(true);
        }
        if (AstronautMovement.ck == 1 && AstronautMovement.rep > limitSP && aux2 == 0)
        {
            time = Time.time;
            AvisoRecord.SetActive(true);
            aux2 = 1;
            GetComponent<AudioSource>().PlayOneShot(Success);
        }
        if (Time.time >= time + 2)
        {
            AvisoRecord.SetActive(false);
        }
    }


    IEnumerator getData()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://savetheaxo.ddns.net/UnityAxo/score.php");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            string s = www.downloadHandler.text;
            RepFlex = s.Split('-')[0];
            RepSup = s.Split('-')[1];

            Debug.Log("Flex = " + RepFlex);
            Debug.Log("Sup = " + RepSup);
           
            if (int.TryParse(RepFlex, out number))
            {
                limitFE = number;
            }
            else
            {
                limitFE = 0;
            }
            if (int.TryParse(RepSup, out number))
            {
                limitSP = number;
            }
            else
            {
                limitSP = 0;
            }

            Flex.text = limitFE.ToString();
            Sup.text = limitSP.ToString();
        }   
    }
}

