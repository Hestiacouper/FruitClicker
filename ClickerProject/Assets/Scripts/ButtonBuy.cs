using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBuy : MonoBehaviour
{
    int value = 20;
    [SerializeField] GameObject statusBox;

    void Start()
    {
        
    }

    void Update()
    {
        if (ClickerScript.score < value)
        {
            Debug.Log("arrive");
            //statusBox.GetComponent<text>().text = "Not enough value";
            Debug.Log("no value");
            statusBox.GetComponent<Animation>().Play("statusAnimation");
            Debug.Log("part");
        }
    }
}
