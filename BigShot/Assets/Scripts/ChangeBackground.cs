using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBackground : MonoBehaviour
{
    [SerializeField] GameObject basicBackground;
	[SerializeField] GameObject highEndBackground;
	[SerializeField] GameObject humbleBackground;
	[SerializeField] GameObject garageBackground;

    // Start is called before the first frame update
    void Start()
    {
        highEndBackground.SetActive(false);
	    humbleBackground.SetActive(false);
	    garageBackground.SetActive(false);
	    DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) {
			Destroy(gameObject);
		}
    }

    public void LoadHighEndBG(){
		basicBackground.SetActive(false);
		highEndBackground.SetActive(true);
	}

	public void LoadHumbleBG(){
		basicBackground.SetActive(false);
		humbleBackground.SetActive(true);
	}

	public void LoadGarageBG(){
		basicBackground.SetActive(false);
		garageBackground.SetActive(true);
	}
}
