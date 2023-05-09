using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public AudioSource audio1;
    public GameObject slider;
    // Start is called before the first frame update
    private void Awake()
    {
        
        slider = GameObject.Find("Slider");
        slider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volume",1f);
        DontDestroyOnLoad(transform.gameObject);
        
        audio1.volume = slider.GetComponent<Slider>().value;
    }
    public void volume()
    {
        audio1.volume = slider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("volume", audio1.volume);
    }

}
