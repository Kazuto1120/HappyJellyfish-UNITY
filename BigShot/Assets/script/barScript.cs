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
    [ContextMenu("test")]
    public void Set()
    {
        slider.value -= 1;
    }
}
