using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreDisplay;
    [SerializeField] ClickerScript clickerScript;

    [SerializeField] TextMeshProUGUI bonusClicker;
    [SerializeField] AutoClicker autoclicker;

    [SerializeField] TextMeshProUGUI BonusClicker2;
    [SerializeField] AutoClicker2 autoclicker2;

    void Update()
    {
        String textScore = clickerScript.GetScore().ToString();
        scoreDisplay.text = "Calorie : " + textScore;

        String bonus = autoclicker.GetValueIncrease().ToString();
        bonusClicker.text = "Bonus : +" + bonus;

        String bonus2 = autoclicker2.GetValueIncrease().ToString();
        BonusClicker2.text = "Bonus : +" + bonus2;
    }
}
