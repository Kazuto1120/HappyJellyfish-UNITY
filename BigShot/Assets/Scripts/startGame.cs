using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("moneynum", 0);
        PlayerPrefs.SetInt("debtnum", 0);
        PlayerPrefs.SetInt("moralenum",100);
        PlayerPrefs.SetInt("interest", 0);
        PlayerPrefs.SetInt("customer", 0);
        PlayerPrefs.SetInt("month", 0);
        PlayerPrefs.SetInt("monPay", 5000);
        PlayerPrefs.SetInt("employeecount", 3);
        PlayerPrefs.SetInt("percent",100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadGame(){
        SceneManager.LoadScene("InvestorsEvent");
    }
}
