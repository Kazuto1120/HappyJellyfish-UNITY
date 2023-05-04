using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scenevent : MonoBehaviour
{
    [SerializeField] GameObject logicmanager;
    [SerializeField] TMP_Text textfield;
    // Start is called before the first frame update
    private void Awake()
    {
        textfield = GameObject.Find("Main Prompt").GetComponent<TMP_Text>();
        logicmanager = GameObject.Find("logicmanager");
    }
    public void changetext(string word)
    {
        textfield.text = word;
    }
    public void changesupplier()
    {
        int x = (int)Random.Range(-200, 1000);
        if(x == 0)
        {
            changetext("you were able to find a supplier with the same price with as before");}
        else if (x > 0)
        {
            changetext("the new suppier you from is saddly asking for more then the previous supplier");
        }
        else
        {
            changetext("You are super lucky and was able to find a supplier with cheaper price");
        }
        logicmanager.GetComponent<logic>().addMonpay(x);


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
