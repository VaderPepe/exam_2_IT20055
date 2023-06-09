using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public static float timer = 0f;

    private void Start()
    {
        timer = 0f;
    }
    
    private void Update()
    {
        timer += Time.deltaTime;
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = Mathf.Floor(timer % 60).ToString("00");
        timerText.text = "Time: " + minutes + ":" + seconds;
    }
}
