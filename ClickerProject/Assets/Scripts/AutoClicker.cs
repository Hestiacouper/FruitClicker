using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AutoClicker : MonoBehaviour
{
    public bool autoClicker = false;
    [SerializeField] int valueIncrease = 0;
    int delay = 1;
    int value = 20;
    [SerializeField] TextMeshProUGUI NotEnoughValue;
    [SerializeField] GameObject Texte;

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
    public void UpgradeClicker()
    {
        if (ClickerScript.score >= value)
        {
            ClickerScript.score -= value;
            valueIncrease++;
        }
        else
        {
           StartCoroutine(NotEnough());
        }
    }
    IEnumerator NotEnough()
    {
        Debug.Log("on");
        Texte.SetActive(true);
        NotEnoughValue.text = "Not enough value";
        NotEnoughValue.GetComponent<Animation>().Play("statusAnimation");
        yield return new WaitForSeconds(delay);
        Texte.SetActive(false);
        Debug.Log("off");
    }
}

