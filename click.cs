using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip clic;
    public Button btn { get { return GetComponent<Button>(); } }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        btn.onClick.AddListener(Play);
    }

    // Update is called once per frame
    void Play()
    {
        source.PlayOneShot(clic);
    }
}
