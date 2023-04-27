using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame1Script : MonoBehaviour
{
    public Slider slider;
    private float lossSpeed = 0.01f;
    private float gainSpeed = 0.07f;
    public GameObject gamePanel;
    public float startTime = 10;
    public float currentTime;
    public bool countBegan = false;
    public bool miniGameOver = false;
    [SerializeField] Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
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
            if (slider.value - lossSpeed < 0) {
                slider.value = 0;
            } else {
                slider.value -= lossSpeed;
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
            }
    }
}