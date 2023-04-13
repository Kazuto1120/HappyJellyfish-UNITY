using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logic : MonoBehaviour
{
    public Text money;
    public Text debt;
    public GameObject morale;
    public int moneynum = 0;
    public int debtnum = 0;
    public int moralenum = 0;
    
    public void addmoney(int num = 10) {
        moneynum += num;
    }
    
    public void adddebt(int num)
    {
        debtnum += num;
    }
    [ContextMenu("test")]
    public void addmorale(int num)
    {
        moralenum += num;
    }

    void Update()
    {
        morale.GetComponent<Slider>().value = moralenum;
        debt.text = debtnum.ToString();
        money.text = moneynum.ToString();

    }
}
