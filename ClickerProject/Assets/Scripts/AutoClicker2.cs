using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AutoClicker2 : MonoBehaviour
{
    public bool autoClicker = false;
    [SerializeField] int valueIncrease = 0;
    int delay = 1;
    int value = 100;
    [SerializeField] TextMeshProUGUI NotEnoughValue;

    private void Start()
    {
    }
    void Update()
    {
        if (!autoClicker)
        {
            autoClicker = true;
            StartCoroutine(CreateTheClick());
        }
    }
    IEnumerator CreateTheClick()
    {
        yield return new WaitForSeconds(delay);
        ClickerScript.score += valueIncrease;
        autoClicker = false;
    }
    public void UpgradeClicker2()
    {
        if (ClickerScript.score >= value)
        {
            ClickerScript.score -= value;
            valueIncrease+= 5;
        }
        else
        {
            NotEnoughValue.text = "Not enough value";
            NotEnoughValue.GetComponent<Animation>().Play("statusAnimation");
        }
    }
}

