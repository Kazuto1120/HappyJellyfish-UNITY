using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject logic;
    // Start is called before the first frame update
    [SerializeField] int num = 10;
    public void add()
    {
        num++;
        logic.AddComponent<logic>().adddebt(num);
        logic.AddComponent<logic>().addmoney(num);
        logic.AddComponent<logic>().addmorale();
    }

}
