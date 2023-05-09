using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class endscript : MonoBehaviour
{
    public TMP_Text end;

    private void Awake()
    {
        end.text = PlayerPrefs.GetString("endmessage");
    }
}
