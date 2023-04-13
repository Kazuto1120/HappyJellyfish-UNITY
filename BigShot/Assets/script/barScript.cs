using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class barScript : MonoBehaviour
{
    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        if (slider == null)
        {
            slider = GetComponent<Slider>();
        }  
    }

    public void Set(int num)
    {
        slider.value = num;
    }
}
