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
    public int interest = 0;
    public int monPay = 0;
    private void Start()
    {
        moneynum = PlayerPrefs.GetInt("moneynum");
        debtnum = PlayerPrefs.GetInt("debtnum");
        moralenum = PlayerPrefs.GetInt("moralenum");
        interest = PlayerPrefs.GetInt("interest");
        
    }
    public void addmoney(int num) {
        moneynum += num;
        PlayerPrefs.SetInt("moneynum",moneynum);
    }
    
    public void adddebt(int num)
    {
        debtnum += num;
        PlayerPrefs.SetInt("debtnum", debtnum);
    }
    [ContextMenu("test")]
    public void addmorale(int num)
    {
        moralenum += num;
        PlayerPrefs.SetInt("moralenum",moralenum);
    }
    public void addinterest(int num)
    {
        interest += num;
        PlayerPrefs.SetInt("interest",interest);
    }

    void Update()
    {
        morale.GetComponent<Slider>().value = moralenum;
        debt.text = debtnum.ToString();
        money.text = moneynum.ToString();
        monPay = (int)(debtnum * (interest * 0.01));
    }
}
