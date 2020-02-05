using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerScript : MonoBehaviour
{
    public static int score = 0;

    [SerializeField] AudioSource clip;
    

    public void AddScore()
    {
        score += 1;
        clip.Play();
    }
    
    public int GetScore()
    {
        return score;
    }
}
