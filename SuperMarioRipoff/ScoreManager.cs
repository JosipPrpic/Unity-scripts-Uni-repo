using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;    
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        if (score == 8)
        {
            text.text = "You Won! \nAchieved score: " + score.ToString();
        }
        else
        {
            text.text = "Score: " + score.ToString();
        }
    }
}
