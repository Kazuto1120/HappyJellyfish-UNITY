using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public GameObject audio;
    public Slider slide;
    // Start is called before the first frame update

    private void Awake()
    {
        
        audio = GameObject.Find("audio");
    }
    // Update is called once per frame
    public void set()
    {
        audio.GetComponent<AudioSource>().volume = slide.value;
    }
}
