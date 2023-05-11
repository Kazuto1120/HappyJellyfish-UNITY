using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class textmanager : MonoBehaviour
{
    [SerializeField] TMP_Text textField;
    [SerializeField] int option;
    [SerializeField] bool picked = false;
    [SerializeField] bool next = false;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (picked) {
            if (option == 1)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, textField));
                textField.text = "You got a decent amount of funds, but investors requested 40% equity and 20% of the money given to you will be consider as debt. You are left to run your business on 60% of your profits. ";
                picked = false;
            }
            if (option == 2)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, textField));
                textField.text = "You got a decent amount of funds, but the loan interest rate was 25%. Get ready to pay up! ";
                picked = false;
            }
            if (option == 3)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, textField));
                textField.text = "You didn't get much funds, but there is no interest and you can pay back whever you want. Get ready to budget!";
                picked = false;
            } }
    }
    public IEnumerator FadeTextToFullAlpha(float t, TMP_Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }
    public void choose(int num)
    {
        option = num;
        picked = true;
        next = true;
        
    }
    public void playInvestorScene()
    {
        if (next) {
            SceneManager.LoadScene("InvestorChoice"); }
    }

}
