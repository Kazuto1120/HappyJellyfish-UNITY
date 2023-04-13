using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playInvestorScene(){
        SceneManager.LoadScene("InvestorChoice");
    }

    public void playBankLoanScene(){
        SceneManager.LoadScene("BankLoanChoice");
    }

    public void playFamilyLoanScene(){
        SceneManager.LoadScene("FamilyLoanChoice");
    }
}
