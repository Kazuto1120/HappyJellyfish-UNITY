using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class logic : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text debt;
    public GameObject morale;
    public int moneynum = 0;
    public int debtnum = 0;
    public int moralenum = 0;
    public int monPay = 5000;
    public int customer = 0;
    public int month = 0;
    [SerializeField] GameObject NextButton;
    private void Awake()
    {
        morale = GameObject.Find("morale");
    }
    private void Start()
    {
        
        moneynum = PlayerPrefs.GetInt("moneynum");
        debtnum = PlayerPrefs.GetInt("debtnum");
        moralenum = PlayerPrefs.GetInt("moralenum");
        customer = PlayerPrefs.GetInt("customer");
        monPay = PlayerPrefs.GetInt("monPay");
        month = PlayerPrefs.GetInt("month");
        
    }
    public void addMonpay(int num)
    {
        monPay += num;
        PlayerPrefs.SetInt("monPay", monPay);
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
    public void addcost(int num) {
        monPay += num;
        PlayerPrefs.SetInt("monPay", monPay);
    }
  
    public void addcustomer(int num)
    {
        int temp = Random.Range(0 + num, 20 + num);
        customer += temp;
        PlayerPrefs.SetInt("customer", customer);
    }
    public void nextscene()
    {

        int x = Random.Range(1,4);
        if (x < 2||month<=0)
        {
            scene();
        }
        else
        {
            int y = Random.RandomRange(16, 21);
            
             SceneManager.LoadScene(y);
        }
    }
    public void scene() {
        month += 1;
        PlayerPrefs.SetInt("month", month);
        SceneManager.LoadScene(month+2);
    }

    public void replaceWithNextButton()
    {
        GameObject choiceButtons = GameObject.Find("ChoiceButtonsCanvas");
        Destroy(choiceButtons);
        spawnNextButton();
    }

    public void spawnNextButton()
    {
        Vector3 position = new Vector3((float)4.67, (float)0.83, 0);
        GameObject canvas = GameObject.Find("Canvas");
        Instantiate(NextButton, position, Quaternion.identity, canvas.transform);
    }
    public void pay()
    {
        int temp = (customer * moralenum * 5) - monPay-(debtnum/(12));
        addmoney(temp);
        adddebt(-(debtnum / (12)));
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
