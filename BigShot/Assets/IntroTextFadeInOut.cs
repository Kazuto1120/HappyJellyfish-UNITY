using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroTextFadeInOut : MonoBehaviour
{
    [SerializeField] int spaceBarCount;
    [SerializeField] TMP_Text textField;
    // Start is called before the first frame update
    void Start()
    {
        spaceBarCount = 0;
        textField = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            spaceBarCount++;
            if(spaceBarCount==1){
                StartCoroutine(FadeTextToFullAlpha(1f, textField));
                textField.fontSize = 400;
                textField.text = "WITH THE CURRENT STATE OF THE ECONOMY, THE ONLY WAY TO BECOME TRULY SUCESSFUL TO BE ABLE TO RUN A SUCCESSFUL BUSINESS";
            }
            if(spaceBarCount==2){
                StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TMP_Text>()));
                textField.fontSize = 500;
                textField.text = "LET'S SEE IF YOU HAVE WHAT IT TAKES TO RUN A SUCCESSFUL BUSINESS";
            }
            if(spaceBarCount==3){
                StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TMP_Text>()));
                textField.fontSize = 600;
                textField.text = "CAN YOU BECOME THE NEXT BIGSHOT";
            }
        }
    }

    public IEnumerator FadeTextToFullAlpha(float t, TMP_Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while(i.color.a<1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime/t));
            yield return null;
        }
    }
}
