using UnityEngine;
using TMPro;

public class DisplayHighestScore : MonoBehaviour
{
    public TMP_Text highestScoreText;

    private void Start()
    {
        float highestScore = PlayerPrefs.GetFloat("HighScore", 0f);

        string minutes = Mathf.Floor(highestScore / 60).ToString("00");
        string seconds = Mathf.Floor(highestScore % 60).ToString("00");

        highestScoreText.text = "Highest Score: " + minutes + ":" + seconds;
    }
}

