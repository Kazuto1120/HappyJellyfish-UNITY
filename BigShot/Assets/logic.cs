using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logic : MonoBehaviour
{
    public Text money;
    public Text debt;
    public GameObject morale;
    public int moneynum = 0;
    public int debtnum = 0;
    public int moralenum = 0;
    public int monPay = 0;
    public int customer = 0;
    private void Start()
    {
        moneynum = PlayerPrefs.GetInt("moneynum");
        debtnum = PlayerPrefs.GetInt("debtnum");
        moralenum = PlayerPrefs.GetInt("moralenum");
        customer = PlayerPrefs.GetInt("customer");
        
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
        if(moralenum > 100)
        {
            moralenum = 100;
        }
        PlayerPrefs.SetInt("moralenum",moralenum);
    }
  
    public void addcustomer(int num)
    {
        int temp = Random.Range(0 + num, 20 + num);
        customer += temp;
        PlayerPrefs.SetInt("customer", customer);
    }

    void Update()
    {
        morale.GetComponent<Slider>().value = moralenum;
        debt.text = debtnum.ToString();
        money.text = moneynum.ToString();
        monPay = (int)(debtnum / 10);
        if(moneynum < 0||moralenum < 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
