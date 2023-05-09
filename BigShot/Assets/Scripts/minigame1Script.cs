using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame1Script : MonoBehaviour
{
    public Slider slider;
    private float lossSpeed = 0.3f;
    private float gainSpeed = 0.06f;
    public GameObject gamePanel;
    public float startTime = 10;
    public float currentTime;
    public bool countBegan = false;
    public bool miniGameOver = false;
    [SerializeField] Text countDownText;
    [SerializeField] GameObject NextButton;
    public logic logicScript;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !miniGameOver) {
            IncrementProgress();
        }

        if (countBegan) {
            countDown();
        }
    }
    [ContextMenu("Increase progress")]
    public void IncrementProgress() {
        if (slider.value + gainSpeed > 1) {
            slider.value = 1;
        } else {
            slider.value += gainSpeed;
        }
    }

    private void FixedUpdate() {
        if (slider.value > 0 && !miniGameOver) {
            if (slider.value - lossSpeed * Time.deltaTime < 0) {
                slider.value = 0;
            } else {
                slider.value -= lossSpeed * Time.deltaTime;
            }
        }

    }
    public void startGame() {
        gamePanel.SetActive(true);
        countBegan = true;
    }
    public void countDown() {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 5) {
                countDownText.color = Color.red;
            }

        if (currentTime <= 0) {
                currentTime = 0;
                countBegan = false;
                miniGameOver = true;
            Vector3 position = new Vector3((float)7.67, (float)0.83, 0);
            GameObject canvas = GameObject.Find("Canvas");
            Instantiate(NextButton, position, Quaternion.identity, canvas.transform);
            if (slider.value >= .9) {
                logicScript.addmoney(10000);
            } else if (slider.value >= .6) {
                logicScript.addmoney(7500);
            } else if (slider.value >= .25) {
                logicScript.addmoney(3000);
            }
        }
    }
}
