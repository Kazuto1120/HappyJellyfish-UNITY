using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceButtonsToNext : MonoBehaviour
{
    [SerializeField] GameObject NextButton; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void ReplaceWithNextButton()
    {
        GameObject choiceButtons = GameObject.Find("ChoiceButtonsCanvas");
        Destroy(choiceButtons);
        SpawnNextButton();
    }

    public void SpawnNextButton()
    {
        Vector3 position = new Vector3((float)550, (float)225, 0);
        GameObject canvas = GameObject.Find("Canvas");
        Instantiate(NextButton, position, Quaternion.identity, canvas.transform);
    }
}
