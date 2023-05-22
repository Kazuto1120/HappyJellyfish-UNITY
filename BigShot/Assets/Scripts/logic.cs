using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
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
    [SerializeField] int count = 0;
    [SerializeField] int employeecount = 3;
    [SerializeField] int percent = 100;
    [SerializeField] GameObject NextButton;
    private void Awake()
    {
        morale = GameObject.Find("morale");
    }
    private void Start()
    {
        percent = PlayerPrefs.GetInt("percent");
        employeecount = PlayerPrefs.GetInt("employeecount");
        count = PlayerPrefs.GetInt("count");
        moneynum = PlayerPrefs.GetInt("moneynum");
        debtnum = PlayerPrefs.GetInt("debtnum");
        moralenum = PlayerPrefs.GetInt("moralenum");
        customer = PlayerPrefs.GetInt("customer");
        monPay = PlayerPrefs.GetInt("monPay");
        month = PlayerPrefs.GetInt("month");
        
    }
    public void addemployee(int num)
    {
        employeecount += num;
        PlayerPrefs.SetInt("employeecount",employeecount);
        if(employeecount <= 0)
        {
            PlayerPrefs.SetString("endmessage","You run out of employee");
            SceneManager.LoadScene("gameover");
        }
    }
    public void share(int num)
    {
        percent += num;
        PlayerPrefs.SetInt("percent", percent);
        if (percent <= 0)
        {
            PlayerPrefs.SetString("endmessage","you lost all your share of the buiness");
            SceneManager.LoadScene("gameover");
        }
    }
    public void addMonpay(int num)
    {
        monPay += num;
        PlayerPrefs.SetInt("monPay", monPay);
    }
    public void addmoney(int num) {
        moneynum += num;
        PlayerPrefs.SetInt("moneynum",moneynum);
        money.text = PlayerPrefs.GetInt("moneynum").ToString();
        if (moneynum < 0)
        {
            PlayerPrefs.SetString("endmessage","You run of of money");
            SceneManager.LoadScene("gameover");
        }
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
        if ( moralenum < 0)
        {
            PlayerPrefs.SetString("endmessage", "Your employee lost all morale and decided to all quit");
            SceneManager.LoadScene("gameover");
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
    public void addcustomer(int num,int range)
    {
        int temp = Random.Range(0 + num, range + num);
        customer += temp;
        PlayerPrefs.SetInt("customer", customer);
    }
    public void multcustomer(int num)
    {
        int temp = Random.Range(0 + num, 1 + num);
        customer *= temp;
        PlayerPrefs.SetInt("customer", customer);
    }
    public void nextscene()
    {

        int x = Random.Range(1,4);
        if ((x < 2&&count>=1)||count>2)
        {
            count = 0;
            PlayerPrefs.SetInt("count", count);
            scene();
            
        }
        else
        {
            count++;
            PlayerPrefs.SetInt("count", count);
            int y = Random.Range(16, 28);
            
             SceneManager.LoadScene(y);
        }
    }

    public void gameWon(){
        int money = PlayerPrefs.GetInt("moneynum");
        PlayerPrefs.SetString("endmessage", "Congratulation! You made it through the 12 months with $" + money + " left.");
        SceneManager.LoadScene("gameover");
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
        GameObject nextButton = Instantiate(NextButton, position, Quaternion.identity, canvas.transform);
        EventSystem.current.SetSelectedGameObject(nextButton);
    }

    public void pay()
    {
        int temp = (int)((customer*moralenum)*((double)percent/100))-(debtnum/12)-(employeecount*1000)-monPay;
        Debug.Log(temp);
        addmoney(temp);
        adddebt(-(debtnum / (12)));
    }

    void Update()
    {
        morale.GetComponent<Slider>().value = moralenum;
        debt.text = debtnum.ToString();
        money.text = moneynum.ToString();
    }
}
