using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonscript : MonoBehaviour
{
    public static bool Pause = false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Pause = false;
    }
    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Pause = true;
    }
    
}
