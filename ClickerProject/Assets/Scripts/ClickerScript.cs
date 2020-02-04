using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerScript : MonoBehaviour
{
    private int score = 0;


    

    public void AddScore()
    {
        score += 1;
    }
    
    public int GetScore()
    {
        return score;
    }
}
