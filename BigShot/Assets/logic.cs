using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logic : MonoBehaviour
{
    public Text money;
    public Text debt;
    public GameObject morale;
    
    public void addmoney(int num = 10) {
        money.text = num.ToString();
    }
    
    public void adddebt(int num)
    {
        debt.text = num.ToString();
    }
    [ContextMenu("test")]
    public void addmorale()
    {
        morale.GetComponent<Slider>().value +=1;
    }
}
