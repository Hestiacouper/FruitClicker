using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreDisplay;
    [SerializeField] ClickerScript clickerScript;


    void Update()
    {
        String textScore = clickerScript.GetScore().ToString();
        scoreDisplay.text = "Calorie : " + textScore;
    }
}
