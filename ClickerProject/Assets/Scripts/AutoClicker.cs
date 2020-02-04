using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoClicker : MonoBehaviour
{
    public bool autoClicker = false;
    public static int valueIcrease = 1;
    public int internalIncrease;
    int delay = 1;
    int value = 20;
    bool buy = false;
    [SerializeField] GameObject statusBox;

    void Update()
    {
        if (ClickerScript.score < value & !buy)
        {
            statusBox.GetComponent<Text>().text = "Not enough value";
            statusBox.GetComponent<Animation>().Play("statusAnimation");
        }
        if (ClickerScript.score >= value & !buy)
        {
            buy = true;
            ClickerScript.score -= value;
        }
        internalIncrease = valueIcrease;
        if (autoClicker == false & buy)
        {
            autoClicker = true;
            StartCoroutine(CreateTheClick());
        }
    }
    IEnumerator CreateTheClick()
    {
        yield return new WaitForSeconds(delay);
        ClickerScript.score += internalIncrease;
        autoClicker = false;
    }
}
